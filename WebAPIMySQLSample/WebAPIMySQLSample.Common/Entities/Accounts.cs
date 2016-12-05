using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Entities
{
     [Table("accounts")]
    public class Accounts : IEntityBase
    {
        public Accounts()
        {
            Employee = new List<Employee>();
          
        }

         [Key]
        [Required]
        public Guid AccountUniqueID { get; set; }
        

        [Required]
        public string AccountName { get; set; }
        [Required]
        public string AccountAddress { get; set; }
        [Required]
        public string AccountCity { get; set; }
        [Required]
        public int AccountStateId { get; set; }
        [Required]
        public int LicenseId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [JsonIgnore]
        public DateTime? CreatedOn { get; set; }
        [JsonIgnore]
        public DateTime? LastModifiedDateTime { get; set; }

        [Required]
        public Guid CompanyUniqueId { get; set; }
        [ForeignKey("CompanyUniqueId")]
        [JsonIgnore]
        public Company Company { get; set; }


        [JsonIgnore]
        public virtual ICollection<Employee> Employee { get; set; }

    }
}
