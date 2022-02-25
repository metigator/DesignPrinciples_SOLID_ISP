
using System;
using System.Collections.Generic; 

namespace SOLID.ISP.After
{
    static class Repository
    {

        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee> 
            {
                    new Staff
                    {
                         EmployeeNo = "2017-FI-1343",
                         Name = "Cochran Cole",
                         Salary = 1000
                    },
                    new Consultant
                    {
                         EmployeeNo = "2018-FI-1755",
                         Name = "Jaclyn Wolfe", 
                         Salary = 1000, 
                    },
                    new Daylabourer
                    {
                         EmployeeNo = "2016-IT-1441",
                         Name = "Cochran Cole", 
                         Salary = 1000, 
                    }
            };
        } 
    }
}
