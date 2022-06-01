using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Groups
{
    internal class SqlGroupsQueries : IOuterGroupsQueries, IInnerGroupDaoQueries
    {
        private readonly ISqlConnectionFacade _db;

        public SqlGroupsQueries(ISqlConnectionFacade db)
        {
            _db = db;
        }

        public void AddGroup(string name, int cource)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GroupDao> GetAllGroups()
        {
            throw new System.NotImplementedException();
        }

        public int GetCourceById(int id)
        {
            return int.Parse(_db.GetValue($"SELECT cource FROM groups WHERE id = {id}"));
        }

        public string GetNameById(int id)
        {
            return _db.GetValue($"SELECT name FROM groups WHERE id = {id}");
        }

        public void SetCourceToGroupWithId(int id, int value)
        {
            _db.Execute($"UPDATE groups SET cource = {value} WHERE id = {id}");
        }

        public void SetNameToGroupWithId(int id, string value)
        {
            _db.Execute($"UPDATE groups SET name = {value} WHERE id = {id}");
        }
    }
}
