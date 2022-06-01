using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessFramework.Dao.Marks
{
    internal class FakeMarksQueries : IOuterMarkQueries, IInnerMarkDaoQueries
    {
        private Dictionary<int, string> _data = new ();

    }
}
