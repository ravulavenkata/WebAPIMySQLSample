
using WebAPIMySQLSample.Common.Configurations;
using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIMySQLSample.Data;

namespace WebAPIMySQLSample.Data
{
    public class SampleMySQLApplicationDataContext : DbContext
    {
        public SampleMySQLApplicationDataContext()
            : base("WebAPIMySQLSampleDbConnection")
        {
            Database.SetInitializer<SampleMySQLApplicationDataContext>(null);
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new Test1Configuration());
            //modelBuilder.Configurations.Add(new TestCommentConfiguration());
            

        }
        #region Entity Sets

        //public DbSet<T> Records { get; set; }
        //public IDbSet<test> Test { get; set; }
        //public IDbSet<test1> Test1 { get; set; }

       

        public IDbSet<Error> ErrorSet { get; set; }

        #endregion


        public virtual RepositoryActionResults Commit()
        {
            try
            {
                base.SaveChanges();
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Created,
                    ExceptionMessage = String.Empty
                };
            }
            catch (Exception ex)
            {
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Error,
                    ExceptionMessage = ex.InnerException.Message
                };
            }
        }

        public virtual RepositoryActionResults Create()
        {
            try
            {
                base.SaveChanges();
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Created,
                    ExceptionMessage = String.Empty
                };
            }
            catch (Exception ex)
            {
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Error,
                    ExceptionMessage = ex.InnerException.Message
                };
            }
        }

        public virtual RepositoryActionResults Update()
        {
            try
            {
                base.SaveChanges();
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Updated,
                    ExceptionMessage = String.Empty
                };
            }
            catch (Exception ex)
            {
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Error,
                    ExceptionMessage = ex.InnerException.Message
                };
            }
        }

        public virtual RepositoryActionResults Delete()
        {
            try
            {
                base.SaveChanges();
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Deleted,
                    ExceptionMessage = String.Empty
                };
            }
            catch (Exception ex)
            {
                return new RepositoryActionResults
                {
                    RepositoryActionStatus = RepositoryActionStatus.Error,
                    ExceptionMessage = ex.InnerException.Message
                };
            }
        }
    }
}
