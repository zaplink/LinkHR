using System;
using Microsoft.Data.SqlClient;


public static class DBConnector
{
    public static SqlConnection GetConnection()
    {
        

        string serverName = Environment.GetEnvironmentVariable("SQL_SERVER_NAME");
        string databaseName = Environment.GetEnvironmentVariable("SQL_DATABASE_NAME");
        string username = Environment.GetEnvironmentVariable("SQL_DATABASE_USERNAME");
        string password = Environment.GetEnvironmentVariable("SQL_DATABASE_PASSWORD");

        if (string.IsNullOrEmpty(serverName))
        {
            throw new InvalidOperationException("SQL_SERVER_NAME environment variable is not set.");
        }

        if (string.IsNullOrEmpty(databaseName))
        {
            throw new InvalidOperationException("SQL_DATABASE_NAME environment variable is not set.");
        }

        string connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};Trusted_Connection=False;TrustServerCertificate=True;";

        return new SqlConnection(connectionString);
    }
}
