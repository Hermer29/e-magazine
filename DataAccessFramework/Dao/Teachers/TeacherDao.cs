namespace DataAccessFramework.Dao.Teachers
{
    public class TeacherDao
    {
        private IInnerTeacherDaoQueries _bridge;

        internal TeacherDao(int id, IInnerTeacherDaoQueries bridge)
        {
            Id = id;
            _bridge = bridge;
        }

        public int Id { get; }
        public string Name { get => _bridge.GetTeacherNameById(Id); set => _bridge.ChangeTeacherNameWithId(Id, value); }

        public void Delete()
        {
            _bridge.DeleteTeacherWithId(Id);
        }
    }
}
