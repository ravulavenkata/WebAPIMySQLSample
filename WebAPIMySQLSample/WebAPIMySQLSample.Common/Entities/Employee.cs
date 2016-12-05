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
     [Table("employee")]
    public class Employee : IEntityBase
    {
        public Employee()
        {
            
           
           
        }

        [Key]
        [Required]
        public Guid EmployeeUniqueID { get; set; }

        [Required]
        public Guid AccountUniqueID { get; set; }

        [Required]
        public Guid CompanyUniqueID { get; set; }


        [Required]
        public Guid CompanyRoleUniqueID { get; set; }

        [Required]
        public string EmployeeFirstName { get; set; }

        [Required]
        public string EmployeeLastName { get; set; }

        [Required]
        public string EmployeeUserName { get; set; }

        [Required]
        public string EmployeePassword { get; set; }

        [Required]
        public string EmployeePasswordSalt { get; set; }

        [JsonIgnore]
        public Boolean IsPasswordReset { get; set; }

        [Required]
        public int StatusId { get; set; }


        [JsonIgnore]
        public DateTime? CreatedOn { get; set; }

        [JsonIgnore]
        public DateTime? LastModifiedDateTime { get; set; }



        [JsonIgnore]
        public virtual Accounts Accounts { get; set; }

        [JsonIgnore]
        public virtual Company Company { get; set; }
    }

}
