using Redis.Common.Models;
using Redis.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.Business
{
    public class UserBL
    {
        private UserDao userDao;
        public UserBL()
        {
            this.userDao = new UserDao();
        }

        public T Read<T>(string key)
        {
            return this.userDao.Read<T>(key);
        }

        public bool Save<T>(string key, T value)
        {
            return this.userDao.Save<T>(key, value);
        }
    }
}
