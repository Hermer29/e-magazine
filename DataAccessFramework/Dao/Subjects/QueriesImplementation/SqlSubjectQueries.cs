using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.Subjects
{
    internal class SqlSubjectQueries : IOuterSubjectsQueries, IInnerSubjectDaoQueries
    {
        private readonly ISqlConnectionFacade _connectionFacade;

        public SqlSubjectQueries(ISqlConnectionFacade connectionFacade)
        {
            _connectionFacade = connectionFacade;
        }
    }
}
