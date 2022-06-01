using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Users
{
    internal class SqlUsersQueries : IOuterUsersQueries, IInnerUserDaoQueries
    {
        private readonly ISqlConnectionFacade _connectionFacade;

        public SqlUsersQueries(ISqlConnectionFacade connectionFacade)
        {
            _connectionFacade = connectionFacade;
        }
    }
}
