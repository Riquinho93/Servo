using Microsoft.EntityFrameworkCore;
using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindonsServo.Data;
using WindonsServo.Model;

namespace WindonsServo.ViewModel
{
    public class AddressViewModel
    {

        public void createAddress(Product product, Address address)
        {

            using (var context = new ApplicationDBContent())
            {
                if (address.Id > 0)
                {
                    context.Attach(address);
                    context.Update(address);
                }
                else
                {
                   context.Addresses.Include(a => a.Product);
                   
                }

                context.SaveChanges();
            }


        }

        public static void delete(Address address)
        {

            using (var context = new ApplicationDBContent())
            {
                context.Remove(address);
                context.SaveChanges();

            }
        }

        public static List<Address> ListAll()
        {
            using (var context = new ApplicationDBContent())
            {
                return context.Addresses.ToList();
            }

        }

        public static Address getById(int id)
        {
            using (var context = new ApplicationDBContent())
            {
                return context.Addresses.Where(c => c.Id == id).Include(p => p.Product).FirstOrDefault();
                // return (from p in context.Addresses
                //        where p.Id.Equals(id)
                //       select p).FirstOrDefault();
            }
        }

    }
}
