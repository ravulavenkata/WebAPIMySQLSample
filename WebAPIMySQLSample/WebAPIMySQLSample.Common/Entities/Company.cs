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
    [Table("company")]
    public class Company : IEntityBase
    {

        public Company()
        {
            Employee = new List<Employee>();
            Accounts = new List<Accounts>();
         
        }

        [Key]
        [Required]
        public Guid CompanyUniqueID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string CompanyAddress { get; set; }

        [Required]
        public string CompanyCity { get; set; }

        [Required]
        public int StatusId { get; set; }

       

        [JsonIgnore]
        public DateTime? CreatedOn { get; set; }

        [JsonIgnore]
        public DateTime? LastModifiedDateTime { get; set; }

        [JsonIgnore]
        public ICollection<Accounts> Accounts { get; set; }


        [JsonIgnore]
        public  ICollection<Employee> Employee { get; set; }

      
    }
}
