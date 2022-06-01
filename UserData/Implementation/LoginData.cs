using Microsoft.Data.Sqlite;
using SqlFacade;

namespace EMagazine.UserData.Implementation
{
    public class LoginData : ILoginDataBridge
    {
        private ISqlConnectionFacade _connectionFacade;

        public LoginData(FacadeBuilder facades) : base()
        {
            _connectionFacade = facades.GetFacade();
        }

        public string CreateAndGetToken(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public bool FindRow(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Role GetRole(string token)
        {
            throw new System.NotImplementedException();
        }

        public void InsertNewUser(string username, string password, Role role)
        {
            throw new System.NotImplementedException();
        }

        public bool IsTokenExists(string token)
        {
            throw new System.NotImplementedException();
        }
    }
}
