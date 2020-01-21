using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindonsServo.Model
{
    [Table("Product")]
    public class Product
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Age { get; set; }
       
        public User User { get; set; }
        public Category Category { get; set; }

        public Address Address { get; set; }

      //  public List<Telephone> Telephones { get; set; }

    }
}
