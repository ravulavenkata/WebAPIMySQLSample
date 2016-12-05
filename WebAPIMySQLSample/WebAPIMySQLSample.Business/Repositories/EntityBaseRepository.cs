using System;
using System.Linq;
using System.Linq.Expressions;
using WebAPIMySQLSample.Data;
using WebAPIMySQLSample.Data.Infrastructure;
using WebAPIMySQLSample.Common.Entities;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace WebAPIMySQLSample.Business.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
            where T : class, IEntityBase, new()
    {
        private SampleMySQLApplicationDataContext dataContext;

        #region Properties
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected SampleMySQLApplicationDataContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        public EntityBaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }
        #endregion
        public virtual IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }
        public virtual IQueryable<T> All
        {
            get
            {
                return GetAll();
            }
        }
        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = DbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }
        public IQueryable<T> GetAllFilter(string[] includes)
        {
            IQueryable<T> query = this.DbContext.Set<T>();

            foreach (var include in includes)
                query = query.Include(include);

            return query;
        }
        public IQueryable<T> GetAllfiLTER(string include)
        {
            return this.DbContext.Set<T>().Include(include);
        }
        public T GetSingle(int id)
        {
            return GetAll().FirstOrDefault();  
            //.FirstOrDefault(x => x.ID == id);
        }
        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return DbContext.Set<T>().Where(predicate);
        }

        public virtual void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            DbContext.Set<T>().Add(entity);
        }
        public virtual void Edit(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            return DbContext.Set<T>().Where(predicate).Count();
        }
        
    }
}
