using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIMySQLSample.Business.Repositories;
using WebAPIMySQLSample.Common.Entities;

namespace WebAPIMySQLSample.Business.Extensions
{
    public static class EmployeeExtensions
    {
        public static Employee GetSingleByUsername(this IEntityBaseRepository<Employee> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(x => x.EmployeeUserName == username);
        }
    }
}
