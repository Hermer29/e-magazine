using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Themes
{
    internal class SqlThemesQueries : IOuterThemesQueries, IInnerThemeDaoQueries
    {
        private readonly ISqlConnectionFacade _db;

        public SqlThemesQueries(ISqlConnectionFacade dbConnection)
        {
            _db = dbConnection;
        }

        public void AddTheme(string name, int subject_id, string description)
        {
            _db.Execute($"INSERT INTO themes (name, subject_id, description) VALUES ({name}, {subject_id}, {description})");
        }

        public string GetDescriptionById(int id)
        {
            return _db.GetValue($"SELECT description FROM themes WHERE id = {id}");
        }

        public string GetNameById(int id)
        {
            return _db.GetValue($"SELECT name FROM themes WHERE id = {id}");
        }

        public int GetSubjectIdByThemeId(int themeId)
        {
            return int.Parse(_db.GetValue($"SELECT subject_id FROM themes WHERE id = {themeId}"));
        }

        public IEnumerable<ThemeDao> GetThemes()
        {
            var ids = _db.GetValues($"SELECT id FROM themes");
            foreach(var id in ids)
            {
                yield return new ThemeDao(int.Parse(id), this);
            }
        }

        public void SetDescriptionToThemeWithId(int id, string value)
        {
            _db.Execute($"UPDATE themes SET description = {value} WHERE id = {id}");
        }

        public void SetNameById(int id, string value)
        {
            _db.Execute($"UPDATE themes SET name = {value} WHERE id = {id}");
        }

        public void SetSubjectIdOfThemeWithId(int themeId, int subjectId)
        {
            _db.Execute($"UPDATE themes SET subject_id = {subjectId} WHERE id = {themeId}");
        }
    }
}
