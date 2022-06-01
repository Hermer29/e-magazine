using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Teachers
{
    internal class SqlSubjectPlansQueries : IOuterTeachersQueries, IInnerTeacherDaoQueries
    {
        private readonly ISqlConnectionFacade _connectionFacade;

        public SqlSubjectPlansQueries(ISqlConnectionFacade connectionFacade)
        {
            _connectionFacade = connectionFacade;
        }

        public IEnumerable<TeacherDao> GetTeachers()
        {
            var teacherIds = _connectionFacade.GetValues("SELECT id FROM teachers");
            foreach (var id in teacherIds)
            {
                yield return new TeacherDao(int.Parse(id), this);
            }
        }

        public void AddTeacher(string name)
        {
            _connectionFacade.Execute($"INSERT INTO teachers (name) VALUES ({name})");
        }

        public string GetTeacherNameById(int id)
        {
            return _connectionFacade.GetValue($"SELECT name FROM teachers WHERE id = {id}");
        }

        public void ChangeTeacherNameWithId(int id, string newName)
        {
            _connectionFacade.Execute($"UPDATE teachers SET name = {newName} WHERE id = {id}");
        }

        public void DeleteTeacherWithId(int id)
        {
            _connectionFacade.Execute($"DELETE FROM teachers WHERE id = {id}");
        }
    }
}
