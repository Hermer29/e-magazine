using System.Collections.Generic;

namespace SqlFacade
{
    public interface IMultiColumnResponse
    {
        public IColumnSelector GetRecord(int index);
        public IEnumerable<IColumnSelector> GetAllRows();
    }
}
