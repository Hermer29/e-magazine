using System.Collections.Generic;
using System.Data;

namespace SqlFacade.AdoNetWrapper
{
    internal class AdoNetFacade : ISqlConnectionFacade
    {
        private IDbConnection _dbConnection;

        public AdoNetFacade(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        void ISqlConnectionFacade.Execute(string sql)
        {
            var command = PrepareCommand(sql);
            command.ExecuteNonQuery();
        }

        IMultiColumnResponse ISqlConnectionFacade.GetMultiColumnValues(string sql)
        {
            var command = PrepareCommand(sql);
            return new MultiColumnResponse(command.ExecuteReader().Enumerate());
        }

        string ISqlConnectionFacade.GetValue(string sql)
        {
            var command = PrepareCommand(sql);
            return (string) command.ExecuteScalar();
        }

        IEnumerable<string> ISqlConnectionFacade.GetValues(string sql)
        {
            var command = PrepareCommand(sql);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                    yield return reader.GetValue(0).ToString();
            }
            yield break;
        }

        private void OpenConnectionIfRequired()
        {
            if (_dbConnection.State == ConnectionState.Closed)
                _dbConnection.Open();
        }

        private IDbCommand PrepareCommand(string command)
        {
            OpenConnectionIfRequired();
            var commandInstance = _dbConnection.CreateCommand();
            commandInstance.CommandText = command;
            return commandInstance;
        }
    }
}
