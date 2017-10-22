using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SQL_Conncetion
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;

            //testConnectionString from webconfig
            string connectionString = ConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString;

            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            connection.Open();//open the sql connection using the connection string info

            //just setup a basic sql command (referencing the connection)
            command = new SqlCommand("SELECT * FROM TabUser", connection);

          

            SqlDataReader reader = command.ExecuteReader(); //execute command, give results to reader

            DataTable dt = new DataTable(); //can hold any kind of data
            //setup the column names
            dt.Columns.Add("UserId", typeof(Int32));
            dt.Columns.Add("UserName", typeof(String));
            dt.Columns.Add("UserLevel", typeof(Int32));

            while (reader.Read())
            {
                //generate an empty row of data based on our datatables columns
                DataRow row = dt.NewRow();
                //fill in row with data from this row of results from the reader
                row["UserId"] = reader["UID"];
                row["UserName"] = reader["UserName"];
                row["UserLevel"] =reader["UserLevel"];
                //add this row to our datatable
                dt.Rows.Add(row);
            }

            UsersGridView.DataSource = dt;
            UsersGridView.DataBind();

            connection.Close();

        }

        const int USER_LEVEL_COLUMN = 2;

        protected void UsersGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType.Equals(DataControlRowType.DataRow)){

                Image img = new Image();

                if (e.Row.Cells[USER_LEVEL_COLUMN].Text.Equals("1"))
                {
                    img.ImageUrl = "~/images/pawn.gif";
                }
                else if (e.Row.Cells[USER_LEVEL_COLUMN].Text.Equals("2"))
                {
                    img.ImageUrl = "~/images/knight.gif";
                }
                else
                {
                    img.ImageUrl = "~/images/king.gif";
                }
                e.Row.Cells[USER_LEVEL_COLUMN].Controls.Add(img);
            }
        }
    }
}
