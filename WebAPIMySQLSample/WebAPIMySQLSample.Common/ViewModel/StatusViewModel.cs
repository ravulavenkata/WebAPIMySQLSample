
using WebAPIMySQLSample.Common.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using WebAPIMySQLSample.Common.Entities;

namespace WebAPIMySQLSample.Common.ViewModel
{
    [Bind(Exclude = "Image")]
    public class StatusViewModel : IValidatableObject
    {
        public StatusViewModel()
        {

        }

        public int ID { get; set; }
        public Guid AccountUniqueID { get; set; }
        public int StatusId { get; set; }

        public string StatusName { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedDatetime { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            var validator = new StatusViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }

    }

}