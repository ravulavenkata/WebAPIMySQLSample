using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPIMySQLSample.Common;
using WebAPIMySQLSample.Common.Utilities;

namespace WebAPIMySQLSample.Business.Repositories
{
    //public interface IEntityBaseRepository { }

    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        IQueryable<T> GetAllfiLTER(string include);
        IQueryable<T> GetAllFilter(string[] includes);
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> All { get; }
        IQueryable<T> GetAll();
        T GetSingle(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);

        //int Count(Guid guid,RecordStatus recordStatus);
      
        //int FindRecordsBy(Expression<Func<T, bool>> predicate, RecordStatus recordStatus);

    }
}
