

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIMySQLSample.Common.Entities;

namespace WebAPIMySQLSample.Business.Configurations
{
    public class EmployeeConfiguration : EntityBaseConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(m => m.AccountUniqueID).IsRequired();
            //Property(m => m.CompanyRoleUniqueID).IsRequired();
            Property(m => m.CompanyUniqueID).IsRequired();
            Property(m => m.EmployeeFirstName).IsRequired().HasMaxLength(100);
            Property(m => m.EmployeeLastName).IsRequired().HasMaxLength(50);
            Property(m => m.EmployeePassword).IsRequired().HasMaxLength(50);
            Property(m => m.EmployeePasswordSalt).HasMaxLength(50);
            Property(m => m.EmployeeUserName).HasMaxLength(50);
            Property(m => m.EmployeeUniqueID).IsRequired();
            //HasMany(m => m.EmployeeWorkOrders).WithRequired().HasForeignKey(s => s.EmployeeUniqueId);
        }
    }
}
