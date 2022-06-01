using System.Collections.Generic;

namespace DataAccessFramework.Dao.Themes
{
    internal interface IOuterThemesQueries
    {
        IEnumerable<ThemeDao> GetThemes();
        void AddTheme(string name, int subject_id, string description);
    }
}
