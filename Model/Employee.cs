using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team6_API.Model
{
    public class Employee
    {
        //Employee model
        [Required]
        public int Emp_Id { get; set; }
        [Required]
        public string Emp_Name { get; set; }
        [Required]
        public string Emp_Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public long Emp_Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Emp_Doj { get; set; }
        [Required]
        public string Emp_Dept { get; set; }
        [Required]
        public int Emp_LeaveBal { get; set; }
        [Required]
        public int Man_id { get; set; }
    }
}
