using DataAccessFramework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Subjects
{
    internal class FakeSubjectQueries : IOuterSubjectsQueries, IInnerSubjectDaoQueries
    {
        private SimulatedDataTable<string> _teachers = new();

    }
}
