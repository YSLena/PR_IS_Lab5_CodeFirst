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
            // Метод EnsureCreated() создаст БД при первом использовании
            Database.EnsureCreated();
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Person> Person { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                 * В строке соединения необходимо указать параметр Database
                 * В AttachDbFilename необходимо указать путь, по которому вы хотите создать БД
                 * Путь должен существовать, а сама БД - нет
                 * Если нужно переименовать БД, измените названия в параметрах Database и AttachDbFilename
                 */
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Person1;AttachDbFilename=E:\Users\Lena\NET\DB\Person1.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}
