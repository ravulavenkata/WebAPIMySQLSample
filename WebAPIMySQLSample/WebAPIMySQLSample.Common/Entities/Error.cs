using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Entities
{
    public class Error : IEntityBase
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
    }
}
