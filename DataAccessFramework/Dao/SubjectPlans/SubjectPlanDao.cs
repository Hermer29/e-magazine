using System;

namespace DataAccessFramework.Dao.SubjectPlans
{
    public class SubjectPlanDao
    {
        internal SubjectPlanDao()
        {

        }

        public int Id { get; }
        public int RelatedSubjectId { get; set; }
        public int RelatedGroupId { get; set; }
        public int RelatedTeacherId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
