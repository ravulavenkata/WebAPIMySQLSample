using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Configurations
{
    public class CompanyConfiguration : EntityBaseConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            Property(r => r.CreatedOn).IsOptional();
            Property(r => r.LastModifiedDateTime).IsOptional();
            //HasMany(m => m.Employee).WithRequired().HasForeignKey(s => s.EmployeeUniqueID);
            HasMany(m => m.Accounts).WithRequired().HasForeignKey(s => s.AccountUniqueID);
         

        }
    }
}

