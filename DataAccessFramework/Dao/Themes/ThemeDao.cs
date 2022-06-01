using System;

namespace DataAccessFramework.Dao.Themes
{
    public class ThemeDao
    {
        private IInnerThemeDaoQueries _queries;
        private int _id;

        internal ThemeDao(int id, IInnerThemeDaoQueries queries)
        {
            _id = id;
            _queries = queries;
        }

        public int Id => _id;
        public int RelatedSubjectId { 
            get => _queries.GetSubjectIdByThemeId(_id); 
            set => _queries.SetSubjectIdOfThemeWithId(_id, value); }
        public string Name { 
            get => _queries.GetNameById(_id); 
            set => _queries.SetNameById(_id, value); }
        public string Description { 
            get => _queries.GetDescriptionById(_id); 
            set => _queries.SetDescriptionToThemeWithId(_id, value); }
    }
}
