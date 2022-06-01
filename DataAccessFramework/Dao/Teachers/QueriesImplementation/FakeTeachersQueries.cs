using DataAccessFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Teachers
{
    internal class FakeTeachersQueries : IOuterTeachersQueries, IInnerTeacherDaoQueries
    {
        private SimulatedDataTable<string> _teachers = new SimulatedDataTable<string>
        {
            "Vasya Petrovich",
            "Dmitri Iliich",
            "Marina"
        };

        public void AddTeacher(string name)
        {
            _teachers.Add(name);
        }

        public void ChangeTeacherNameWithId(int id, string newName)
        {
            ThrowIfIdDosntExists(id);

            _teachers[id] = newName;
        }

        public void DeleteTeacherWithId(int id)
        {
            ThrowIfIdDosntExists(id);

            _teachers.Remove(id);
        }

        public string GetTeacherNameById(int id)
        {
            ThrowIfIdDosntExists(id);

            return _teachers[id];
        }

        public IEnumerable<TeacherDao> GetTeachers()
        {
            foreach(var teacher in _teachers)
            {
                yield return new TeacherDao(teacher.Key, this);
            }
        }

        private void ThrowIfIdDosntExists(int id)
        {
            if (_teachers.ContainsId(id) == false)
                throw new InvalidOperationException("Teacher not found");
        }
    }
}
