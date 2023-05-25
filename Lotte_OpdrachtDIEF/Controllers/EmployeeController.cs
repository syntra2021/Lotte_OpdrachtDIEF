using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lotte_OpdrachtDIEF.Models;
using Lotte_OpdrachtDIEF.Services;

namespace Lotte_OpdrachtDIEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _emplyeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _emplyeeService = employeeService;
        }

        [HttpGet("One")]
        public ActionResult<Employee> GetEmployee(int employeeId)
        {

            var employee = _emplyeeService.GetEmployee(employeeId);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpGet("Many")]
        public ActionResult<List<Employee>> GetAllPEmployees()
        {
            return Ok(_emplyeeService.GetEmployees());
        }

        [HttpPost]
        public ActionResult CreateNewEmployee(Employee newEmployee)
        {
            _emplyeeService.addEmployee(newEmployee);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteEmployeeById(int employeeId)
        {
            _emplyeeService.deleteEmployeeById(employeeId);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Employee> UpdateEmployeeById(int employeeIdToEdit, Employee employeeEditValues)
        {
            var updatedEmployee = _emplyeeService.UpdateEmployeeById(employeeIdToEdit, employeeEditValues);
            return Ok(updatedEmployee);
        }


    }
}
