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
    public class ProductViewModel
    {
        public Category Category { get; set; }
        public static  void createProduct(Category category, Product product)
        {

            using (var context = new ApplicationDBContent())
            {
                if (product.Id > 0)
                {
                    context.Attach(product);
                    context.Update(product);
                }
                else
                {
                    // context.Products.Add(product);
                    category.Products.Add(product);
                    
                }

                context.SaveChanges();
            }


        }

        public static void delete(Product product)
        {

            using (var context = new ApplicationDBContent())
            {
                context.Remove(product);
                context.SaveChanges();

            }
        }

        public static List<Product> ListAll()
        {
            using (var context = new ApplicationDBContent())
            {
                return context.Products.Include(c => c.Category).ToList();
            }

        }

        public static Product getById(int id)
        {
            using (var context = new ApplicationDBContent())
            {
                return (from p in context.Products
                        where p.Id.Equals(id)
                        select p).FirstOrDefault();
            }
        }


    }
}