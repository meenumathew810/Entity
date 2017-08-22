using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //User newUser = new User();
            //newUser.ID = 1;
            //newUser.Name = "Meenu";
            //newUser.Age = 20;
            //newUser.Address = "kochi";

            UserDbEntities db = new UserDbEntities();
            //db.Users.Add(newUser);
            //db.SaveChanges();

            //var user = db.Users.Where(x => x.Name == "Meenu").FirstOrDefault();
            //Console.WriteLine(user.Name);

            //User user = db.Users.Where(x => x.Name == "meenu").FirstOrDefault();
            //user.Name = "mathew";
            //db.SaveChanges();

            //User user = db.Users.Where(x => x.Name == "mathew").FirstOrDefault();
            //db.Users.Remove(user);
            //db.SaveChanges();

            //List<User> user = db.Users.ToList();
            //foreach (var item in user)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //user.Reverse();
            //foreach (var item in user)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var curUsers = (from user in db.Users
            //                 where user.Name == "Meenu"
            //                 select user);
            //foreach (var item in curUsers)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var curUsers = from user in db.Users
            //               orderby user.ID descending
            //               select user;

            //foreach (var item in curUsers)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var curUsers = (from user in db.Users
            //                 join a in db.UserDetails on user.Name equals a.Name
            //                 orderby user.ID 
            //                 select user);
            //foreach (var item in curUsers)
            //{
            //    Console.WriteLine(item.ID+" "+item.Name + " "+item.Age + " "+item.Address);
            //}
            //Console.ReadLine();

            //var curUsers = (from u in db.Users
            //               group u by u.Name into g
            //               select new
            //               {
            //                 myresult = g.Max(x=>x.Age),

            //               });
            //foreach (var item in curUsers)
            //{

            //        Console.WriteLine(item.myresult);

            //}

            //foreach (var item in curUsers)
            //{

            //    foreach (var names in item)
            //        Console.WriteLine(names);
            //}

            var filteredResult = from u in db.Users
                                 where u.Age > 12 && u.Age < 20
                                 select u.Name;
            foreach (var names in filteredResult)
            { 
                Console.WriteLine(names);
            }
        Console.ReadLine();
        }
    }
}
