using EMagazine.UserData.Implementation;
using System;

namespace EMagazine.UserData
{
    public class UserLoginInteractor
    {
        private ILoginDataBridge _dataBridge;

        public UserLoginInteractor()
        {
            _dataBridge = new FakeData();
        }

        public LoginData Login(string login, string password)
        {
            if (_dataBridge.FindRow(login, password) == false)
            {
                return new LoginData
                {
                    IsSucceeded = false,
                    Token = null,
                    Role = Role.Null
                };
            }
            var token = _dataBridge.CreateAndGetToken(login, password);
            return new LoginData
            {
                IsSucceeded = true,
                Token = token,
                Role = _dataBridge.GetRole(token)
            };
        }

        public Role GetRole(string token)
        {
            if(_dataBridge.IsTokenExists(token))
            {
                return _dataBridge.GetRole(token);
            }
            throw new InvalidOperationException("Token not found");
        }
    }
}
