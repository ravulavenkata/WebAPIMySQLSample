
using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIMySQLSample.Data.Configurations;

namespace WebAPIMySQLSample.Data.Configurations
{
    public class CompanyConfiguration : EntityBaseConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            Property(u => u.CompanyName).IsRequired().HasMaxLength(100);
            Property(u => u.CompanyAddress).IsRequired().HasMaxLength(100);
            Property(u => u.CompanyCity).IsRequired().HasMaxLength(50);
            Property(u => u.CompanyUniqueID).IsRequired();
         
        }
    }
}
