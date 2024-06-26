using MenteAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteAcademy.DAL
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = BILGEYIS-VIVOBO\\SQLEXPRESS01; Database = MenteAcademyTask3; Encrypt = False; Trusted_Connection = True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }


    }
}
