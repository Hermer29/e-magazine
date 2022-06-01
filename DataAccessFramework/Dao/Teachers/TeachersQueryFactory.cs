using System.Collections.Generic;

namespace DataAccessFramework.Dao.Teachers
{
    public class TeachersQueryFactory : IOuterTeachersQueries
    {
        private IOuterTeachersQueries _queries;

        internal TeachersQueryFactory(IOuterTeachersQueries queries)
        {
            _queries = queries;
        }

        public void AddTeacher(string name)
        {
            _queries.AddTeacher(name);
        }

        public IEnumerable<TeacherDao> GetTeachers()
        {
            return _queries.GetTeachers();
        }
    }
}
