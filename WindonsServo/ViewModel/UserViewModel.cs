using ServoLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindonsServo.Data;

namespace WindonsServo.ViewModel
{
    public class UserViewModel
    {

        public static void createUser(User user)
        {

            using (var context = new ApplicationDBContent())
            {
                if (user.id > 0)
                {
                    context.Attach(user);
                    context.Update(user);
                }
                else
                {
                    context.Users.Add(user);
                }

                context.SaveChanges();
            }


        }

        public static void delete(User user)
        {

            using (var context = new ApplicationDBContent())
            {
                context.Remove(user);
                context.SaveChanges();

            }
        }

        public static List<User> ListAll()
        {
            using (var context = new ApplicationDBContent())
            {
                
                return context.Users.ToList();
            }

        }

        public static User getById(int id)
        {
            using (var context = new ApplicationDBContent())
            {
                return (from p in context.Users
                        where p.id.Equals(id)
                        select p).FirstOrDefault();
            }
        }

        public static User getQuery(string email,string password)
        {
            using (var context = new ApplicationDBContent())
            {
                return null;
            }
        }
    }
}
