using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.InteropServices;

namespace WebAPIMySQLSample.Common.ViewModel
{
    [Bind(Exclude = "Image")]
    public class CompanyViewModel : IValidatableObject
        {
            public int CompanyId { get; set; }
            public Guid CompanyUniqueID { get; set; }
            public string CompanyName { get; set; }
            public string CompanyAddress { get; set; }
            public string CompanyCity { get; set; }

            

            public DateTime? CreatedOn { get; set; }
            public DateTime? LastModifiedDatetime { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
        }
    
}