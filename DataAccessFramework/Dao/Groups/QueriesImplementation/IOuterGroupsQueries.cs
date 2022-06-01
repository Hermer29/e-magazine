using System.Collections.Generic;

namespace DataAccessFramework.Dao.Groups
{
    internal interface IOuterGroupsQueries
    {
        IEnumerable<GroupDao> GetAllGroups();
        void AddGroup(string name, int cource);
    }
}
