using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopOnlAPI.model;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;

namespace ShopOnlAPI.dao
{
    class UserDao
    {
        private ShopContext context;
        public IEnumerable<User> Login(string usernam,string password)
        {
            using (EntityConnection con = new EntityConnection("Name=user"))
            {
                con.Open();
                EntityCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;

                return null;
            }
        }
    }
}
