using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Data.Configurations
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.CreatedOn);
            HasKey(e => e.LastModifiedDateTime);
            //HasKey(e => e.Guid);
            //HasKey(e => e.ID);
        }
    }
}
