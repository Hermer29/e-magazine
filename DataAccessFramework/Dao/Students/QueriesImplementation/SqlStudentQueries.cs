using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Students
{
    internal class SqlStudentQueries : IOuterStudentQueries, IInnerStudentDaoQueries
    {
        private readonly ISqlConnectionFacade _connectionFacade;

        public SqlStudentQueries(ISqlConnectionFacade connectionFacade)
        {
            _connectionFacade = connectionFacade;
        }
    }
}
