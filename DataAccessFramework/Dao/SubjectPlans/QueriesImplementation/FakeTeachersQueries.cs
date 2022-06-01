using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Teachers
{
    internal class FakeSubjectPlansQueries : IOuterTeachersQueries, IInnerTeacherDaoQueries
    {
        private Dictionary<int, string> _teachers = new Dictionary<int, string>();

        public void AddTeacher(string name)
        {
            var newId = _teachers.OrderBy(x => x.Key).Last().Key + 1;
            _teachers.Add(newId, name);
        }

        public void ChangeTeacherNameWithId(int id, string newName)
        {
            if (_teachers.ContainsKey(id) == false)
                throw new InvalidOperationException("Teacher not found");

            _teachers[id] = newName;
        }

        public void DeleteTeacherWithId(int id)
        {
            if (_teachers.ContainsKey(id) == false)
                throw new InvalidOperationException("Teacher not found");

            _teachers.Remove(id);
        }

        public string GetTeacherNameById(int id)
        {
            if (_teachers.ContainsKey(id) == false)
                throw new InvalidOperationException("Teacher not found");

            return _teachers[id];
        }

        public IEnumerable<TeacherDao> GetTeachers()
        {
            foreach(var teacher in _teachers)
            {
                yield return new TeacherDao(teacher.Key, this);
            }
        }
    }
}
