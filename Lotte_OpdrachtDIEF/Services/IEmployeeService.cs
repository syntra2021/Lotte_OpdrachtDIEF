using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lotte_OpdrachtDIEF.Models;

namespace Lotte_OpdrachtDIEF.Services
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int employeeId);
        List<Employee> GetEmployees();
        void addEmployee(Employee employee);
        void deleteEmployeeById(int employeeId);
        Employee UpdateEmployeeById(int employeeId, Employee employeeEditValue);
    }
}
