using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Students
{
    internal class FakeStudentQueries : IOuterStudentQueries, IInnerStudentDaoQueries
    {
        private Dictionary<int, string> _data = new Dictionary<int, string>();

    }
}
