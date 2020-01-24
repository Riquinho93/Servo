using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServoLibrary.Model;
using WindonsServo.Model;

namespace WindonsServo.Data
{
    public class ApplicationDBContent : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                     @"Server=localhost;Initial Catalog=Servo;Integrated Security=Yes");
        }

        public object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
