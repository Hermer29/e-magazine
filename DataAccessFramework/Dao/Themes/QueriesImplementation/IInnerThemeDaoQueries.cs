namespace DataAccessFramework.Dao.Themes
{
    internal interface IInnerThemeDaoQueries
    {
        int GetSubjectIdByThemeId(int themeId);
        void SetSubjectIdOfThemeWithId(int themeId, int subjectId);
        string GetNameById(int id);
        void SetNameById(int id, string value);
        string GetDescriptionById(int id);
        void SetDescriptionToThemeWithId(int id, string value);
    }
}
