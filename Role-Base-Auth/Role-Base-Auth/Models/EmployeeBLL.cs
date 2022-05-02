using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Role_Base_Auth.Models
{
    public class EmployeeBLL
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                {
                    employees.Add(new Employee()
                    {
                        ID = i,
                        Name = "Emp" + i,
                        Dept = "IT",
                        Salary = 1000 + i,
                        Gender = "Male"
                    });
                }
                else
                {
                    employees.Add(new Employee()
                    {
                        ID = i,
                        Name = "Emp" + i,
                        Dept = "HR",
                        Salary = 1000 + i,
                        Gender = "FeMale"
                    });
                }
            }
            return employees;
        }
    }
}