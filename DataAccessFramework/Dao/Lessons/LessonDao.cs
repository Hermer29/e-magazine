using System;

namespace DataAccessFramework.Dao.Lessons
{
    public class LessonDao
    {
        private readonly IInnerLessonDaoQueries _queries;

        internal LessonDao(int id, IInnerLessonDaoQueries queries)
        {
            Id = id;
            _queries = queries;
        }

        public int Id { get; }
        public int RelatedSubjectId { get => _queries.GetSubjectIdById(Id); set => _queries.SetSubjectIdById(Id, value); }
        public int RelatedTeacherId { get => _queries.GetTeacherIdById(Id); set => _queries.SetTeacherIdById(Id, value); }
        public int RelatedGroupId { get => _queries.GetGroupIdById(Id); set => _queries.SetGroupIdById(Id, value); }
        public DateTime Day { get => _queries.GetLessonDayById(Id); set => _queries.SetLessonDayById(Id, value); }
        public bool IsHighWeek { get => _queries.IsHighWeekOfLessonById(Id); set => _queries.SetIsHighWeekOfLesson(Id, value); }
    }
}
