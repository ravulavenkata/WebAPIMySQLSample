using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Entities
{
    public interface IEntityBase
    {
         //int ID { get; set; }
         //Guid Guid { get; set; }
         DateTime? CreatedOn { get; set; }
         DateTime? LastModifiedDateTime { get; set; }
    }
}
