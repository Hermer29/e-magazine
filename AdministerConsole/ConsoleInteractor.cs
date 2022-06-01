using DataAccessFramework;
using DataAccessFramework.Dao.Teachers;
using SqlFacade;
using System;
using System.Collections.Generic;

namespace EMagazine.UserData
{
    public class ConsoleInteractor
    {
        private TeachersQueryFactory _queries;

        public ConsoleInteractor(QueryFactorySelector selector)
        {
            _queries = selector.TeachersQueryFactory;
        }

        public void AddTeacher(string name)
        {
            _queries.AddTeacher(name);
        }

        public IEnumerable<TeacherDao> GetAllTeachers()
        {
            return _queries.GetTeachers();
        }
    }
}
