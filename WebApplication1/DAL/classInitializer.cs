using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class classInitializer : IclassInitializer
    {
        private classData ctx;

        public classInitializer(classData _ctx)
        {
            ctx = _ctx;
        }

        public int addStu()
        {
            var students = new List<stuClass>
              {
                  new stuClass{FirstName="shubham", LastName="digole"},
                  new stuClass{FirstName="mahesh", LastName="digole"},
                  new stuClass{FirstName="samu", LastName="digole"},
                  new stuClass{FirstName="anita", LastName="digole"},
              };
            students.ForEach(s =>
            {
                ctx.stuClasses.Add(s);
            });

            return ctx.SaveChanges();

        }

    
    }
}
