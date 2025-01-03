using System.Data;
using System.Data.SqlClient;

namespace OnlineLearningApp.Api.Domain.DbConnection;

public class DbConnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;
    
    public DbConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;   
    }
 
    [Obsolete("Obsolete")]
    public IDbConnection CreateConnection(CancellationToken token = default)
    {
        var connection = new SqlConnection(_connectionString);
        connection.OpenAsync(token);
        return connection;
    }
}