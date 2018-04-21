using Redis.Business;
using Redis.Common.Models;
using Redis.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserBL userBL = new UserBL();
            //Guardar texto
            bool b = userBL.Save("User", "user2");
            string s = userBL.Read<string>("User");

            //Guardar un objeto
            User user = new User("Pepi", "Loli");
            b = userBL.Save("User", user);
            user = userBL.Read<User>("User");

            //Guardar una lista
            List<User> users = new List<User>();
            User user2 = new User("Mario", "Garcia");
            users.Add(user);
            users.Add(user2);
            b = userBL.Save("Users", users);
            users = userBL.Read<List<User>>("Users");
            Console.Read();
        }
    }
}
