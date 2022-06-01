using DataAccessFramework.Dao.Groups;

namespace DataAccessFramework.Dao.Students
{
    public class StudentDao
    {
        internal StudentDao()
        {

        }

        public int Id { get; }
        public string Name { get; set; }
        public GroupDao RelatedGroup { get; set; }
    }
}
