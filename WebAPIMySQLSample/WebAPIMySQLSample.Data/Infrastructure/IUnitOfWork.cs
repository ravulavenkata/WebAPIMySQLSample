using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        RepositoryActionResults Commit();

        RepositoryActionResults Create();

        RepositoryActionResults Update();

        RepositoryActionResults Delete();
    }
}
