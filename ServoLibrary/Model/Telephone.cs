using System;
using System.Collections.Generic;
using System.Text;
using WindonsServo.Model;

namespace ServoLibrary.Model
{
    public class Telephone
    {
        public int id { get; set; }
        public string code { get; set; }
        public string number { get; set; }

        public Product products { get; set; }
    }
}
