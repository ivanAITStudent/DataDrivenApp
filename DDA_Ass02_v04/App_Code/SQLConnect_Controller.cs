using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQLConnect_Controller
/// </summary>
public class SQLConnect_Controller
{
    public SQLConnect_Controller()
    {
        SqlConnection connection;
        SqlCommand command;

        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString_Ivan"].ConnectionString;

        connection = new SqlConnection();
        connection.ConnectionString = connectionString;

        connection.Open();//open the sql connection using the connection string info

        //query
        command = new SqlCommand("SELECT Sys_User.su_id, Sys_User.username, User_Type.ut_id, User_Type.type_name FROM Sys_User INNER JOIN User_Type ON Sys_User.user_type = User_Type.ut_id", connection);

        SqlDataReader reader = command.ExecuteReader(); //execute command, give results to reader

        DataTable dt = new DataTable(); //can hold any kind of data
                                        //setup the column names
        dt.Columns.Add("UserId", typeof(Int32));
        dt.Columns.Add("UserName", typeof(String));
        dt.Columns.Add("UserLevel", typeof(Int32));
        dt.Columns.Add("UserType", typeof(String));

        while (reader.Read())
        {
            //generate an empty row of data based on our datatables columns
            DataRow row = dt.NewRow();
            //fill in row with data from this row of results from the reader
            row["UserId"] = reader["su_id"];
            row["UserName"] = reader["username"];
            row["UserLevel"] = reader["ut_id"];
            row["UserType"] = reader["type_name"];
            //add this row to our datatable
            dt.Rows.Add(row);
        }

        //Add to the Page Gridview
        //UsersGridView.DataSource = dt;
        //UsersGridView.DataBind();

        //always close connection
        connection.Close();

    }
}