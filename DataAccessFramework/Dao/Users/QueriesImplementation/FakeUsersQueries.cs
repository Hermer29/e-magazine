using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Users
{
    internal class FakeUsersQueries : IOuterUsersQueries, IInnerUserDaoQueries
    {
        private Dictionary<int, string> _teachers = new Dictionary<int, string>();

    }
}
