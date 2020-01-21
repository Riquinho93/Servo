using Microsoft.EntityFrameworkCore;
using System;
using WindonsServo.Data;

namespace ServoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bd = new ApplicationDBContent())
            {
                bd.Database.Migrate();
            };
        }
    }
}
