using WebAPIMySQLSample.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SampleMySQLApplicationDataContext dbContext;

        public SampleMySQLApplicationDataContext Init()
        {
            return dbContext ?? (dbContext = new SampleMySQLApplicationDataContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
