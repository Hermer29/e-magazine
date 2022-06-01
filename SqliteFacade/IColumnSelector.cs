using System.Collections.Generic;

namespace SqlFacade
{
    public interface IColumnSelector
    {
        public string GetColumn(int index);
        public IEnumerable<string> GetAllColumns();
    }
}
