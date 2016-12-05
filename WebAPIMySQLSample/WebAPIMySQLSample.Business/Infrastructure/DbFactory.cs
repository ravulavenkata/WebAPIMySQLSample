using InSiteApplication.Data;
using InSiteApplication.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSiteApplication.Business.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        InSiteApplicationDataContext dbContext;

        public InSiteApplicationDataContext Init()
        {
            return dbContext ?? (dbContext = new InSiteApplicationDataContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
