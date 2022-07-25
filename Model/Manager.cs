using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team6_API.Model
{
    public class Manager
    {
        //Manager Model
        [Required]
        public int Man_Id { get; set; }
        [Required]
        public string Man_Name { get; set; }
        [Required]
        public string Man_Email { get; set; }
        [Required]
        public long Man_Phone { get; set; }
    }
}
