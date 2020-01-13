using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class StudentContext : DbContext
    {
        public StudentContext(string connString) : base()
        {

        }
      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }*/

        public DbSet<stuClass> stuClasses { get; set; }
    }
}
