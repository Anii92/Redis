using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.Common.Models
{
    public class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public User(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
    }
}
