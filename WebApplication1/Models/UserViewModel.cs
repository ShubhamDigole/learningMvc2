using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserViewModel
    {
        public UserModel user { get; set; }

        public UserViewModel(UserModel u)
        {
            user = u;
        }
        public int age { 
            get {
                int age = DateTime.Now.Year - user.DateOfBirth.Year;
                if(user.DateOfBirth > DateTime.Now.AddYears(-age))
                {
                    age--;
                }

                return age;
            } 

        
        }


        public string salaryColor
        {
            get
            {
                if (user.Salary > 10000)
                {
                    return "red";
                }
                else
                {
                    return "green";
                }
            }
        }
    }
}
