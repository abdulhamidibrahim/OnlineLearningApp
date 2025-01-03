using System.Data;

namespace OnlineLearningApp.Api.Domain.DbConnection;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection(CancellationToken token);
}