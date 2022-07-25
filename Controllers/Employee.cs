using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Team6_API.Model;
using Team6_API.Repository;
using Team6_API.DataAccessLayer;

namespace Team6_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        
        private readonly IEmployeeRepo employeeRepo;
        

        public Employee(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
            
        }

        // To show all employees
        [HttpGet]
        [Route("DisplayAll")]
        public async Task<IActionResult> GetEmp()
        {
            var ar = await employeeRepo.GetEmployeesAsync();
            return Ok(ar);
        }

        //Search any employee with employee id
        [HttpGet]
        [Route("SearchById")]
        public async Task<IActionResult> Search(int id)
        {
            var ar = await employeeRepo.GetEmpByIdAsync(id);
            return Ok(ar);
        }

        //Delete record from employee table
        [HttpDelete]
        [Route("DeleteEmp")]
        public async Task<IActionResult> DeleteEmployee(int? id)
        {
            if (id != null)
            {
                await employeeRepo.DeleteEmpAsync(id);
                return Ok();
            }
            return NotFound();
        }

        //update Employee
        [HttpPut]
        [Route("UpdateEmp/{id?}")]
        public async Task<IActionResult> UpdateEmployee(int? id, Model.Employee employee)
        {
            if (id != null)
            {
                await employeeRepo.UpdateEmpAsync(id, employee);
                return Ok();
            }
            return NotFound();
        }

        //Register an employee
        [HttpPost]
        [Route("InsertEmp")]
        public async Task<IActionResult> EmpSignUp(Model.Employee employee)
        {
            var ar = await employeeRepo.EmpSignUpAsync(employee);
            return Ok(ar);
        }

        //Login for Employee
        [HttpGet]
        [Route("EmpLogin/{Emp_Email}/{Password}")]
        public async Task<int> Emp_Login(string Emp_Email, string Password)
        {
            var lg = await employeeRepo.LoginAsync( Emp_Email, Password);
            if (lg == 0)
                return 0;
            else
                return 1;
        }

        //Login for Manager
        [HttpGet]
        [Route("ManLogin/{Man_Id}/{Password}")]
        public async Task<int> ManagerLogin(int Man_Id, string Password)
        {
            var lg = await employeeRepo.ManagerLoginAsync(Man_Id, Password);
            if (lg == 0)
                return 0;
            else
                return 1;
        }
        //Manager to approve or deny the leave

        [HttpPatch]
        [Route("ApproveDeny/{id}")]
        public int ApproveDeny(int? id, LeaveDetails leaveDetails)
        {
            var data = employeeRepo.ManagerAction(id, leaveDetails);
            return 1;
        }

        //Logged in  employee details 
        [HttpGet]
        [Route("MyDetails/{Emp_Email}")]
        public async Task<IActionResult> MyDetails(string Emp_Email)
        {
            var ar = await employeeRepo.MyDetailsAsync(Emp_Email);
            return Ok(ar);
        }

        //Manager details of Employee
        [HttpGet]
        [Route("MyManagerDetails/{Man_Id}")]
        public async Task<IActionResult> MyManager(int? Man_Id)
        {
            var mk = await employeeRepo.MyManagerAsync(Man_Id);
            return Ok(mk);
        }

        // employees can apply leave
        [HttpPost]
        [Route("InsertLeave")]
        public async Task<IActionResult> ApplyLeave(LeaveDetails leaveDetails)
        {
            var ar = await employeeRepo.InsertLeaveAsync(leaveDetails);
            return Ok(ar);
        }

        // show all employee's previous Leaves
        [HttpGet]
        [Route("MyPreviousLeaves/{Emp_Id}")]
        public async Task<IActionResult> MyPreviousLeaves(int Emp_Id)
        {
            var ar = await employeeRepo.MyPreviousLeaves(Emp_Id);
            return Ok(ar);
        }

        // show all Leaves under specific manager 
        [HttpGet]
        [Route("AppliedLeaves/{Man_Id}")]
        public async Task<IActionResult> AppliedLeaves(int Man_Id)
        {
            var ar = await employeeRepo.AppliedLeaves(Man_Id);
            return Ok(ar);
        }

    }

}
