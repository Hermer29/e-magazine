using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessFramework.Dao.Users
{
    public class UserDao
    {
        internal UserDao()
        {

        }

        public string Login { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
        public string Token { get; set; }
    }
}
