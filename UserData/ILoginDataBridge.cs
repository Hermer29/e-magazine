namespace EMagazine.UserData
{
    internal interface ILoginDataBridge
    {
        bool FindRow(string username, string password);
        string CreateAndGetToken(string username, string password);
        bool IsTokenExists(string token);
        Role GetRole(string token);
        void InsertNewUser(string username, string password, Role role);
    }
}
