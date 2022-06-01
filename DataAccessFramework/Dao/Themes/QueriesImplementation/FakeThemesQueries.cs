using DataAccessFramework.Utility;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Themes
{
    internal class FakeThemesQueries : IOuterThemesQueries, IInnerThemeDaoQueries
    {
        private SimulatedDataTable<(int subjectId, string name, string description)> _data = new();

        public void AddTheme(string name, int subject_id, string description)
        {
            _data.Add((subject_id, name, description));
        }

        public string GetDescriptionById(int id)
        {
            return _data[id].description;
        }

        public string GetNameById(int id)
        {
            return _data[id].name;
        }

        public int GetSubjectIdByThemeId(int themeId)
        {
            return _data[themeId].subjectId;
        }

        public IEnumerable<ThemeDao> GetThemes()
        {
            foreach(var theme in _data)
            {
                yield return new ThemeDao(theme.Key, this);
            }
        }

        public void SetDescriptionToThemeWithId(int id, string value)
        {
            var oldValues = _data[id];
            _data[id] = (oldValues.subjectId, oldValues.name, value);
        }

        public void SetNameById(int id, string value)
        {
            var oldValues = _data[id];
            _data[id] = (oldValues.subjectId, value, oldValues.description);
        }

        public void SetSubjectIdOfThemeWithId(int themeId, int subjectId)
        {
            var oldValues = _data[themeId];
            _data[themeId] = (subjectId, oldValues.name, oldValues.description);
        }
    }
}
