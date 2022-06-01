using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Marks
{
    internal class SqlMarksQueries : IOuterMarkQueries, IInnerMarkDaoQueries
    {
        private readonly ISqlConnectionFacade _connectionFacade;

        public SqlMarksQueries(ISqlConnectionFacade connectionFacade)
        {
            _connectionFacade = connectionFacade;
        }
    }
}
