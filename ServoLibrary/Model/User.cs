using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WindonsServo.Model;

namespace ServoLibrary.Model
{
    [Table("Users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmaPassword { get; set; }
    }
}
