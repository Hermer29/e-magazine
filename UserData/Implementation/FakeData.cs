using System.Data;
using System.Data.SqlClient;

namespace EMagazine.UserData.Implementation
{
    public class FakeData : ILoginDataBridge
    {
        private string _login = "admin";
        private string _password = "admin";

        public string CreateAndGetToken(string username, string password)
        {
            return "okay";
        }

        public bool FindRow(string username, string password)
        {
            return true;
        }

        public Role GetRole(string token)
        {
            return Role.Teacher;
        }

        public void InsertNewUser(string username, string password, Role role)
        {
            
        }

        public bool IsTokenExists(string token)
        {
            return true;
        }
    }
}
