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
        public static  void createProduct(Category category, Product product, User user)
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
                    context.Attach(product.Category);
                    context.Attach(product.User);
                   
                    category.Products.Add(product);
                    
                }

                context.SaveChanges();
            }


        }

        public static void delete(Product product)
        {

            using (var context = new ApplicationDBContent())
            {
                Category category = CategoryViewModel.getById(product.Category.Id);
                Address address = AddressViewModel.getById(product.Address.Id);
                context.Remove(category);
                context.Remove(address);
                context.Remove(product);
                context.SaveChanges();

            }
        }

        public static List<Product> ListAll()
        {
            using (var context = new ApplicationDBContent())
            {
                return context.Products.Include(p => p.Category).AsNoTracking().Include(p => p.User).AsNoTracking().ToList();
                //return context.Products.Include(c => c.Category).ToList();
            }

        }

        public static Product getById(int id)
        {
            using (var context = new ApplicationDBContent())
            {
                return (from p in context.Products join a in context.Addresses on p.Address.ProductId equals id into a 
                        where p.Id.Equals(id)
                        select p).FirstOrDefault();
            }
        }

        public static Product getByIdUser(int id)
        {
            using (var context = new ApplicationDBContent())
            {
                 return (from p in context.Products join c in context.Users on p.User.id equals id into c 
                         select p).FirstOrDefault();
                
            }

           
        }


    }
}