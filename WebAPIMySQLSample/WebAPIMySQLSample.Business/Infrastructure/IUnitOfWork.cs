using InSiteApplication.Data;
using InSiteApplication.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSiteApplication.Business.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
