using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
            [Key]
            public int ID { get; set; }

            [Required]
            [StringLength(20)]
            [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]
            public string EmpName { get; set; }

            [Required]
            [StringLength(30)]
            public string EmpDepartment { get; set; }

        
    }
}
