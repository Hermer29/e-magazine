using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace SqlFacade.AdoNetWrapper
{
    internal static class DataReaderExtensions
    {
        public static IEnumerable<IEnumerable> Enumerate(this IDataReader reader)
        {
            while (reader.Read())
            {
                yield return new Row(reader);
            }
        }
    }

    internal class Row : IEnumerable
    {
        private IDataRecord _record;

        public Row(IDataRecord record)
        {
            _record = record;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _record.FieldCount; i++)
            {
                yield return _record.GetValue(i);
            }
        }
    }
}
