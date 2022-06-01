using System.Collections.Generic;

namespace DataAccessFramework.Dao.Teachers
{
    internal interface IOuterTeachersQueries
    {
        IEnumerable<TeacherDao> GetTeachers();
        void AddTeacher(string name);
    }
}
