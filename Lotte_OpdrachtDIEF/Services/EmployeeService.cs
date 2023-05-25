using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lotte_OpdrachtDIEF.Db;
using Lotte_OpdrachtDIEF.Models;

namespace Lotte_OpdrachtDIEF.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<Employee> employeeLIst = new List<Employee>();

        public EmployeeService()
        {
            if (employeeLIst.Count == 0)
            {
                var employeeDefault = new Employee();
                employeeDefault.EmployeeId = 1;
                employeeDefault.Name = "Lotte Beelen";
                employeeDefault.Address = "Mechelseweg 282, 1880 Kqpelle-op-den-bos";
                employeeDefault.EmailAddress = "lotte.beelencapgemini.com";
                employeeDefault.BirthDate = "17/09/1998";
                employeeDefault.StartDate = "05/07/2021";
                employeeLIst.Add(employeeDefault);
            }
        }

        public Employee GetEmployee(int employeeId)
        {
            var employee = employeeLIst.FirstOrDefault(x => x.EmployeeId == employeeId);
            return employee;
        }

    
        public List<Employee> GetEmployees()
        {
            return employeeLIst;
        }

        public void addEmployee(Employee employee)
        {
            employeeLIst.Add(employee);
        }

        public void deleteEmployeeById(int employeeId)
        {
            var employee = employeeLIst.FirstOrDefault(x => x.EmployeeId == employeeId);
            employeeLIst.Remove(employee);
        }
        public Employee UpdateEmployeeById(int employeeId, Employee employeeEditValue)
        {
            using (var db = new ProductDbContext())
            {
                var employeeToEdit = db.Employees.First(employee => employee.EmployeeId == employeeId);
                employeeToEdit.Name = employeeEditValue.Name;
                employeeToEdit.Address = employeeEditValue.Address;
                employeeToEdit.EmailAddress = employeeEditValue.EmailAddress;
                employeeToEdit.BirthDate = employeeEditValue.BirthDate;
                employeeToEdit.StartDate = employeeEditValue.StartDate;
                db.Employees.Update(employeeToEdit);
                db.SaveChanges();
                return employeeToEdit;
            }
        }

      
    }
}
