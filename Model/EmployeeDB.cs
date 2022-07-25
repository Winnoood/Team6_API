using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team6_API.Model
{
    public class EmployeeDB
    {
        //EmployeeDB Model
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Email { get; set; }
        public string Password { get; set; }
        public long Emp_Phone { get; set; }
        public DateTime Emp_Doj { get; set; }
        public string Emp_Dept { get; set; }
        public int Emp_LeaveBal { get; set; }
        public int Man_Id { get; set; }
        [ForeignKey("Man_Id")]
        public virtual ManagerDB manager { get; set; }
    }
}
