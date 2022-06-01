using System.Collections;
using System.Collections.Generic;

namespace SqlFacade.AdoNetWrapper
{
    internal class MultiColumnResponse : IMultiColumnResponse
    {
        private IEnumerable<IEnumerable> _source;

        public MultiColumnResponse(IEnumerable<IEnumerable> source)
        {
            _source = source;
        }

        public IEnumerable<IColumnSelector> GetAllRows()
        {
            foreach(var row in _source)
            {
                yield return new ColumnSelector(row);    
            }
        }

        public IColumnSelector GetRecord(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}
