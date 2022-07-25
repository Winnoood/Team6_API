using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team6_API.Model
{
    public class LeaveDetailsDB
    {
        //Leave Details DB Model
        [Key]
        public int Leave_Id { get; set; }
        public int Emp_Id { get; set; }
        [ForeignKey("Emp_Id")]
        public virtual EmployeeDB EmployeeDB { get; set; }
        public int Man_Id { get; set; }
        [ForeignKey("Man_Id")]
        public virtual ManagerDB manager { get; set; }
        public int No_OfDays { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public DateTime Applied_On { get; set; }
        public string Leave_Type { get; set; }
        public string Leave_Status { get; set; }
        public string Leave_Reason { get; set; }
        public string Manager_Comment { get; set; }
    }
}
