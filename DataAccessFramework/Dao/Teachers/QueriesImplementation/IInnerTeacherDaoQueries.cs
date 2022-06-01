namespace DataAccessFramework.Dao.Teachers
{
    internal interface IInnerTeacherDaoQueries
    {
        string GetTeacherNameById(int id);
        void ChangeTeacherNameWithId(int id, string newName);
        void DeleteTeacherWithId(int id);
        
    }
}
