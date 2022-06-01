using System;

namespace DataAccessFramework.Dao.Lessons
{
    internal interface IInnerLessonDaoQueries
    {
        int GetSubjectIdById(int id);
        void SetSubjectIdById(int id, int value);
        int GetTeacherIdById(int id);
        void SetTeacherIdById(int id, int value);
        int GetGroupIdById(int id);
        void SetGroupIdById(int id, int value);
        DateTime GetLessonDayById(int id);
        void SetLessonDayById(int id, DateTime value);
        bool IsHighWeekOfLessonById(int id);
        void SetIsHighWeekOfLesson(int id, bool value);
    }
}
