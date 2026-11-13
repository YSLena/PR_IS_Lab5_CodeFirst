using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lab5_CodeFirst
{
    class PersonContext : DbContext
    {
        public PersonContext()
        {
            Database.EnsureDeleted();
            // Метод EnsureCreated() створить БД під час першого використання
            Database.EnsureCreated();
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Person> Person { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            /* 
            * У рядку з'єднання необхідно вказати параметр Database 
            * В AttachDbFilename необхідно вказати шлях, яким ви хочете створити БД 
            * Шлях має існувати, а сама БД - ні 
            * Якщо потрібно перейменувати БД, змініть назви в параметрах Database та AttachDbFilename 
            */
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Person1;AttachDbFilename=E:\Users\Lena\NET\DB\Person1.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}
