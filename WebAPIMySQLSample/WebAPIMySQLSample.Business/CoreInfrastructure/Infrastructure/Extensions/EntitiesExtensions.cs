using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIMySQLSample.Common.Entities;
using WebAPIMySQLSample.Common.ViewModel;

namespace WebAPIMySQLSample.Business.Infrastructure.Extensions
{
    public static class EntitiesExtensions
    { 
        public static void UpdateCustomer(this Company customer, CompanyViewModel customerVm)
        {
            //customer.FirstName = customerVm.FirstName;
            //customer.LastName = customerVm.LastName;
            //customer.IdentityCard = customerVm.IdentityCard;
            //customer.Mobile = customerVm.Mobile;
            //customer.DateOfBirth = customerVm.DateOfBirth;
            //customer.Email = customerVm.Email;
            //customer.UniqueKey = (customerVm.UniqueKey == null || customerVm.UniqueKey == Guid.Empty)
            //    ? Guid.NewGuid() : customerVm.UniqueKey;
            //customer.RegistrationDate = (customer.RegistrationDate == DateTime.MinValue ? DateTime.Now : customerVm.RegistrationDate);
        }

    }
}