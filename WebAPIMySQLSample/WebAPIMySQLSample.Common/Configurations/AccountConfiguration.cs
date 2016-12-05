using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Configurations
{
    public class AccountConfiguration : EntityBaseConfiguration<Accounts>
    {
        public AccountConfiguration()
        {
            Property(r => r.StatusId).IsRequired();
            Property(r => r.CreatedOn).IsOptional();
            Property(r => r.LastModifiedDateTime).IsOptional();
            HasMany(m => m.Employee).WithRequired().HasForeignKey(s => s.EmployeeUniqueID);


        }
    }
}


