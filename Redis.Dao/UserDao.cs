using Redis.Common.Models;
using StackExchange.Redis;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.LegacyConfiguration;
using StackExchange.Redis.Extensions.Newtonsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Redis.Dao
{
    public class UserDao
    {
        private StackExchangeRedisCacheClient database;

        public UserDao()
        {
            var serializer = new NewtonsoftSerializer();
            var redisConfiguration = RedisCachingSectionHandler.GetConfig();
            this.database = new StackExchangeRedisCacheClient(serializer, redisConfiguration);
        }

        public T Read<T>(string key)
        {
            return this.database.Get<T>(key);
        }

        public bool Save<T>(string key, T value)
        {
            return this.database.Add(key, value);
        }
    }
}
