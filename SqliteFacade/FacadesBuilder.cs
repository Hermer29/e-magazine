using Microsoft.Data.Sqlite;
using SqlFacade.AdoNetWrapper;
using System.Data;

namespace SqlFacade
{
    public class FacadeBuilder
    {
        private ISqlConnectionFacade _sqlConnectionFacade;
        private IDbConnection _dbConnection;

        public ISqlConnectionFacade GetFacade()
        {
            AssignValuesIfNull();

            return _sqlConnectionFacade;
        }

        private void AssignValuesIfNull()
        {
            if (_dbConnection == null)
            {
                _dbConnection = new SqliteConnection("Data Source=main.db");
            }
            if (_sqlConnectionFacade == null)
            {
                _sqlConnectionFacade = new AdoNetFacade(_dbConnection);
            }
        }
    }
}
