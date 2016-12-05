using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.ViewModel
{
    public class EmployeeViewModel { 
        public Guid CompanyUniqueID { get; set; }
        public Guid AccountUniqueID { get; set; }
        public Guid EmployeeUniqueID { get; set; }
        public Guid CompanyRoleUniqueID { get; set; }

        public string CompanyRoleName { get; set; }
        public string CompanyRoleDescription { get; set; }
        
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeePasswordSalt { get; set; }
        public Boolean IsPasswordReset { get; set; }
        public int AccountStateId { get; set; }
        public int LicenseId { get; set; }
        public int StatusId { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }

        public string StatusName { get; set; }
    }

}
