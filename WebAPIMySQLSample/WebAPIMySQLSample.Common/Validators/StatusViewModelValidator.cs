
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentValidation;
using WebAPIMySQLSample.Common.ViewModel;

namespace WebAPIMySQLSample.Common.Validators
{
    public class StatusViewModelValidator : AbstractValidator<StatusViewModel>
    {
        public StatusViewModelValidator()
        {
            
        }

        private bool ValidTrailerURI(string trailerURI)
        {
            return (!string.IsNullOrEmpty(trailerURI) && trailerURI.ToLower().StartsWith("https://www.youtube.com/watch?"));
        }
    }
}