using System;

namespace DataAccessFramework.Dao.Marks
{
    public class MarkDao
    {
        internal MarkDao()
        {

        }

        public int Id { get; }
        public int Mark { get; set; }
        public DateTime Day { get; set; }
        public int RelatedStudentId { get; set; }
        public int RelatedSubjectId { get; set; }
    }
}
