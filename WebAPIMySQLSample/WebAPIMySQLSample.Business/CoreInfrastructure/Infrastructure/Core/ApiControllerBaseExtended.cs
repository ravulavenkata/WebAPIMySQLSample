
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
//using System.Web.Http;
using WebAPIMySQLSample.Business.Infrastructure.Extensions;
using WebAPIMySQLSample.Common.Entities;

using WebAPIMySQLSample.Business.Repositories;
using WebAPIMySQLSample.Data.Infrastructure;


namespace WebAPIMySQLSample.Business.Infrastructure.Core
{
    public class ApiControllerBaseExtended : ApiController
    {
        protected List<Type> _requiredRepositories;

        protected readonly IDataRepositoryFactory _dataRepositoryFactory;
        protected IEntityBaseRepository<Error> _errorsRepository;
        protected IEntityBaseRepository<Company> _companyRepository;
        protected IEntityBaseRepository<Accounts> _accountsRepository;
        protected IEntityBaseRepository<Employee> _employeeRepository;
        protected IEntityBaseRepository<Status> _statusRepository;
       
        protected IUnitOfWork _unitOfWork;

        private HttpRequestMessage RequestMessage;

        public ApiControllerBaseExtended(IDataRepositoryFactory dataRepositoryFactory, IUnitOfWork unitOfWork)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
            _unitOfWork = unitOfWork;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage request, List<Type> repos, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;

            try
            {
                RequestMessage = request;
                InitRepositories(repos);
                response = function.Invoke();
            }
            catch (DbUpdateException ex)
            {
                LogError(ex);
                response = request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
        
        private void InitRepositories(List<Type> entities)
        {
            _errorsRepository = _dataRepositoryFactory.GetDataRepository<Error>(RequestMessage);

            if (entities.Any(e => e.FullName == typeof(Company).FullName))
            {
                _companyRepository = _dataRepositoryFactory.GetDataRepository<Company>(RequestMessage);
            }
            if (entities.Any(e => e.FullName == typeof(Accounts).FullName))
            {
                _accountsRepository = _dataRepositoryFactory.GetDataRepository<Accounts>(RequestMessage);
            }
            if (entities.Any(e => e.FullName == typeof(Employee).FullName))
            {
                _employeeRepository = _dataRepositoryFactory.GetDataRepository<Employee>(RequestMessage);
            }
            if (entities.Any(e => e.FullName == typeof(Status).FullName))
            {
                _statusRepository = _dataRepositoryFactory.GetDataRepository<Status>(RequestMessage);
            }

        }

        private void LogError(Exception ex)
        {
            try
            {
                Error _error = new Error()
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    DateCreated = DateTime.Now
                };

                _errorsRepository.Add(_error);
                _unitOfWork.Commit();
            }
            catch { }
        }
    }
}