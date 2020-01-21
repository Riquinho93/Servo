using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WindonsServo.Model;

namespace ServoLibrary.Model
{
    [Table("Address")]
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public String Cidade { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

       
    }
}
