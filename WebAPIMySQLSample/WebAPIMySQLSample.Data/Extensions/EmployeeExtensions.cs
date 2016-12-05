using WebAPIMySQLSample.Data.Repositories;
using WebAPIMySQLSample.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Data.Extensions
{
    public static class EmployeeExtensions
    {
        public static Employee GetSingleByUsername(this IEntityBaseRepository<Employee> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(x => x.EmployeeUserName == username);
        }
    }
}
