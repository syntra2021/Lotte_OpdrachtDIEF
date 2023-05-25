using System;
using Lotte_OpdrachtDIEF.Db;
using Lotte_OpdrachtDIEF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Services
{
    public class DbEmployeeService : IEmployeeService
    {
        public void addEmployee(Employee employee)
        {
            using (var db = new ProductDbContext()) 
            {
                db.Add(employee);
                db.SaveChanges();
            }
        }
        public Employee GetEmployee(int employeeId)
        {
            using (var db = new ProductDbContext())
            {
                var employee = db.Employees.FirstOrDefault(employee => employee.EmployeeId == employeeId);
                return employee;
            }
        }
        public List<Employee> GetEmployees()
        {
            using (var db = new ProductDbContext())
            {
                return db.Employees.ToList();
            }
        }


        public void deleteEmployeeById(int employeeId)
        {
            using (var db = new ProductDbContext())
            {
                var employeeToDelete = db.Employees.Find(employeeId);
                db.Employees.Remove(employeeToDelete);
                db.SaveChanges();
            }
        }
        public Employee UpdateEmployeeById(int employeeId, Employee employeeEditValue)
        {
            using (var db = new ProductDbContext())
            {
                var employeeToEdit = db.Employees.First(employee => employee.EmployeeId == employeeId);
                employeeToEdit.Name = employeeEditValue.Name;
                employeeToEdit.EmailAddress = employeeEditValue.EmailAddress;
                employeeToEdit.Address = employeeEditValue.EmailAddress;
                employeeToEdit.BirthDate = employeeEditValue.BirthDate;
                employeeToEdit.StartDate = employeeEditValue.StartDate;
                db.Employees.Update(employeeToEdit);
                db.SaveChanges();
                return employeeToEdit;
            }
        }
    }
}
