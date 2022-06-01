namespace DataAccessFramework.Dao.Groups
{
    internal interface IInnerGroupDaoQueries
    {
        string GetNameById(int id);
        void SetNameToGroupWithId(int id, string value);
        int GetCourceById(int id);
        void SetCourceToGroupWithId(int id, int value);
    }
}
