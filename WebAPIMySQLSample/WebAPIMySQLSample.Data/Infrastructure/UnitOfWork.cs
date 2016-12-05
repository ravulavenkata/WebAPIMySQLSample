using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIMySQLSample.Data;

namespace WebAPIMySQLSample.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SampleMySQLApplicationDataContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public SampleMySQLApplicationDataContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public RepositoryActionResults Commit()
        {
            return DbContext.Commit();
        }

        public RepositoryActionResults Create()
        {
            return DbContext.Create();
        }


        public RepositoryActionResults Update()
        {
            return DbContext.Update();
        }


        public RepositoryActionResults Delete()
        {
            return DbContext.Delete();
        }
    }
}
