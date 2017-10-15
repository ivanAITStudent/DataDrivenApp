using System;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLConnector
/// </summary>
public class SQLConnector
{
    private SqlConnection connection;
    private string connectionString;

    public SQLConnector()
    {
        //default ConnectionString
        connectionString = ConfigurationManager.ConnectionStrings["ConnectionString_Ivan"].ConnectionString;
        
        // create a new sql connection
        connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();
    }

    public SqlConnection GetConnection()
    {
        return connection;
    }

    public SqlConnection OpenNewConnection()
    {
        //always close connections before openning a new one
        //TODO CHECK IF EXCEPTION THROWN
        this.connection.Close();

        // create a new sql connection
        connection = new SqlConnection();

        if (connectionString != null)
        {
            //open the sql connection using the connection string info
            //TODO CHECK IF EXCEPTION THROWN
            this.connection.ConnectionString = connectionString;
            this.connection.Open();
        } else
        {
            throw new NullReferenceException();
        }

        return connection;
    }

    public void ChangeConnectionString(string _connectionString)
    {
        connectionString = ConfigurationManager.ConnectionStrings[_connectionString].ConnectionString;
        connection.ConnectionString = connectionString;
    }

    public void CloseConnection()
    {
        //TODO CHECK IF EXCEPTION THROWN
        this.connection.Close();
    }

}