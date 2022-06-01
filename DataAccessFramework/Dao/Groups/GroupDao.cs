namespace DataAccessFramework.Dao.Groups
{
    public class GroupDao
    {
        private readonly IInnerGroupDaoQueries _queries;

        internal GroupDao(int id, IInnerGroupDaoQueries queries)
        {
            Id = id;
            _queries = queries;
        }

        public int Id { get; }
        public string Name { 
            get => _queries.GetNameById(Id); 
            set => _queries.SetNameToGroupWithId(Id, value); }
        public int Cource { 
            get => _queries.GetCourceById(Id); 
            set => _queries.SetCourceToGroupWithId(Id, value); }
    }
}
