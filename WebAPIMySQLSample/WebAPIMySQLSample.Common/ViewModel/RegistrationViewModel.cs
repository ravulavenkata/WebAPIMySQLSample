
using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIMySQLSample.Common.ViewModel
{
    [Bind(Exclude = "Image")]
    public class RegistrationViewModel : IValidatableObject
    {
        public int AccountId { get; set; }
        public Guid AccountUniqueID { get; set; }

        public Guid CompanyUniqueID { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress { get; set; }
        public string AccountCity { get; set; }

        public int AccountStateId { get; set; }

        public int LicenseId { get; set; }

        public int StatusId { get; set; }


        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedDatetime { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }

}