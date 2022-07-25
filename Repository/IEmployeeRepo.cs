using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team6_API.Model;

namespace Team6_API.Repository
{
   public interface IEmployeeRepo
    {
        Task<List<Employee>> GetEmployeesAsync();  
        Task<Employee> GetEmpByIdAsync(int id);    
        Task DeleteEmpAsync(int? id);  
        Task UpdateEmpAsync(int? id, Employee employee);  
        Task<int> EmpSignUpAsync(Employee employee); 
        Task<int> LoginAsync(string Emp_Email, string Password);  
        Task<int> ManagerLoginAsync(int Man_Id, string Password);  
        Task<Employee> MyDetailsAsync(string Emp_Email); 
        Task<Manager> MyManagerAsync(int? Man_Id); 
        Task<List<LeaveDetails>> MyPreviousLeaves(int Emp_Id); 
        Task<List<LeaveDetails>> AppliedLeaves(int Man_Id); 
        Task<int> InsertLeaveAsync(LeaveDetails leaveDetails); 
        int ManagerAction(int? id, LeaveDetails leaveDetails);

    }
}
