using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Lessons
{
    internal class FakeLessonsQueries : IOuterLessonsQueries, IInnerLessonDaoQueries
    {
        private Dictionary<int, string> _data = new Dictionary<int, string>();

        public int GetGroupIdById(int id)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLessonDayById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetSubjectIdById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetTeacherIdById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsHighWeekOfLessonById(int id)
        {
            throw new NotImplementedException();
        }

        public void SetGroupIdById(int id, int value)
        {
            throw new NotImplementedException();
        }

        public void SetIsHighWeekOfLesson(int id, bool value)
        {
            throw new NotImplementedException();
        }

        public void SetLessonDayById(int id, DateTime value)
        {
            throw new NotImplementedException();
        }

        public void SetSubjectIdById(int id, int value)
        {
            throw new NotImplementedException();
        }

        public void SetTeacherIdById(int id, int value)
        {
            throw new NotImplementedException();
        }
    }
}
