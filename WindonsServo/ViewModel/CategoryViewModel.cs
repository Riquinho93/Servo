using Microsoft.EntityFrameworkCore;
using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindonsServo.Data;

namespace WindonsServo.ViewModel
{
    public class CategoryViewModel
    {

        public static void createCategory(Category category)
        {

            using (var context = new ApplicationDBContent())
            {
                if (category.Id > 0)
                {
                    context.Attach(category);
                    context.Update(category);
                }
                else
                {
                    context.Categories.Add(category);
                }

                context.SaveChanges();
            }


        }

        public static void delete(Category category)
        {

            using (var context = new ApplicationDBContent())
            {
                context.Remove(category);
                context.SaveChanges();

            }
        }

        public static List<Category> ListAll()
        {
            using (var context = new ApplicationDBContent())
            {
           /*     List<Category> lista  = new List<Category>();
                Category cat = new Category();
                Category cat2 = new Category();
                Category cat3 = new Category();

                cat.Id = 1;
                cat.Name = "Domésticos";

                cat2.Id = 2;
                cat2.Name = "Eventos";

                cat3.Id = 3;
                cat3.Name = "Reparações e Mudanças";
                lista.Add(cat);
                lista.Add(cat2);
                lista.Add(cat3);
                return lista; */
                return context.Categories.ToList();
            }

        }

        public static Category getById(int id)
        {

            using (var context = new ApplicationDBContent())
            {
                return context.Categories.Where(c => c.Id == id).Include(p => p.Products).FirstOrDefault();
                //return (from p in context.Categories
                //        where p.Id.Equals(id)
                //        select p).FirstOrDefault();
            }
        }


    }
}
