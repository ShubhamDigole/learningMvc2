using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    [ModelBinder(BinderType = typeof(DataBinder))]
    public class stuClass
    {
        public int ID { get; set; }
     
        [Required]
        [StringLength(10)]
        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(10)]
        public string LastName { get; set; }

    }
}
