using SqlFacade;
using System.Collections.Generic;

namespace DataAccessFramework.Dao.SubjectPlans
{
    internal class SqlSubjectPlansQueries : IOuterSubjectPlansQueries, IInnerSubjectPlanDaoQueries
    {
        private readonly ISqlConnectionFacade _connectionFacade;

        public SqlSubjectPlansQueries(ISqlConnectionFacade connectionFacade)
        {
            _connectionFacade = connectionFacade;
        }
    }
}
