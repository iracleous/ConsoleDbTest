using ConsoleDbTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTest.Service
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}
