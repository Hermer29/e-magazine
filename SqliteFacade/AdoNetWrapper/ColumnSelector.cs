using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SqlFacade.AdoNetWrapper
{
    internal class ColumnSelector : IColumnSelector
    {
        private IEnumerable _values;

        public ColumnSelector(IEnumerable values)
        {
            _values = values;
        }

        public IEnumerable<string> GetAllColumns()
        {
            foreach (var value in _values)
            {
                yield return value.ToString();
            }
        }

        public string GetColumn(int index)
        {
            return _values.Cast<object>().ElementAt(index).ToString();
        }
    }
}
