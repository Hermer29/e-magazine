namespace EMagazine.UserData
{
    public readonly struct LoginData
    {
        public bool IsSucceeded { get; init; }
        public string Token { get; init; }
        public Role Role { get; init; }
    }
}
