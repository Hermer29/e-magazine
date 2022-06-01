using System.Collections.Generic;

namespace SqlFacade
{
    public interface ISqlConnectionFacade
    {
        void Execute(string sql);

        string GetValue(string sql);

        IEnumerable<string> GetValues(string sql);

        IMultiColumnResponse GetMultiColumnValues(string sql);
    }
}
