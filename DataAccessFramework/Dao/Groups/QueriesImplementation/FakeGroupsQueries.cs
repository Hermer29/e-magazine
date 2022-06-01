using DataAccessFramework.Utility;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Groups
{
    internal class FakeGroupsQueries : IOuterGroupsQueries, IInnerGroupDaoQueries
    {
        private SimulatedDataTable<(string name, int cource)> _data = new ();

        public void AddGroup(string name, int cource)
        {
            _data.Add((name, cource));
        }

        public IEnumerable<GroupDao> GetAllGroups()
        {
            foreach(var record in _data)
            {
                yield return new GroupDao(record.Key, this);
            }
        }

        public int GetCourceById(int id)
        {
            return _data[id].cource;
        }

        public string GetNameById(int id)
        {
            return _data[id].name;
        }

        public void SetCourceToGroupWithId(int id, int value)
        {
            var data = _data[id];
            _data[id] = (data.name, value);
        }

        public void SetNameToGroupWithId(int id, string value)
        {
            var data = _data[id];
            _data[id] = (value, data.cource);
        }
    }
}
