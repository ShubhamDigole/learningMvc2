using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DAL
{
    public class classData : DbContext
    {

        //}
        public classData(DbContextOptions<classData> options) : base(options)
        {

        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<stuClass>().ToTable("Students");

        }

        public DbSet<stuClass> stuClasses { get; set; }

    }
}
