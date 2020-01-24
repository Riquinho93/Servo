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
    public class TelephoneViewModel
    {

        public static void createTelephone(Telephone telephone, Product prod)
        {

            using (var context = new ApplicationDBContent())
            {
                if (telephone.id > 0)
                {
                    context.Attach(telephone);
                    context.Update(telephone);
                }
                else
                {
                    // context.Products.Add(product);

                    context.Attach(telephone.products);

                  //  prod.Telephones.Add(telephone);

                }

                context.SaveChanges();
            }


        }
    }
}
