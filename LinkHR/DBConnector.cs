using System;
using Microsoft.Data.SqlClient;


public static class DBConnector
{
    public static SqlConnection GetConnection()
    {
        

        string serverName = Environment.GetEnvironmentVariable("SQL_SERVER_NAME");
        string databaseName = Environment.GetEnvironmentVariable("SQL_DATABASE_NAME");

        if (string.IsNullOrEmpty(serverName))
        {
            throw new InvalidOperationException("SQL_SERVER_NAME environment variable is not set.");
        }

        if (string.IsNullOrEmpty(databaseName))
        {
            throw new InvalidOperationException("SQL_DATABASE_NAME environment variable is not set.");
        }

        string connectionString = $"Server={serverName};Database={databaseName};Trusted_Connection=True;TrustServerCertificate=True;";

        return new SqlConnection(connectionString);
    }
}
