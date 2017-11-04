using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQLGateway_Implemtation
/// </summary>
public class SQLGateway_Implementation: SQLGateway
{
    //initialise
    private NameValueCollection queryList; 

    //contructor
    public SQLGateway_Implementation()
    {
        queryList = new NameValueCollection();
        BuildQueryList();
    }

    //methods
    public int createAnonymousRespondent()
    {
        //initiliase variable
        int respondentID = -1;

        // Open a new SQL connection
        SQLConnector connector = new SQLConnector();

        //query
        SqlCommand command;
        command = new SqlCommand(queryList["CreateAnonymousRespondent"], connector.GetConnection());
        command.Parameters.Add("@typeID", SqlDbType.Int);
        command.Parameters["@typeID"].Value = 1;
        int affectedRows = command.ExecuteNonQuery();

        // close connection
        connector.CloseConnection();

        // get respondent id
        // TODO: capture error if no rows affectd
        respondentID = getHighestAnonymousID();

        return respondentID;

    }

    public int getHighestAnonymousID()
    {
        // TODO Test
        // Get the new respondent id

        //initiliase types
        SqlDataReader reader;
        SqlCommand command;
        int respondentID = -1;

        // Open a new SQL connection
        SQLConnector connector = new SQLConnector();

        //query
        command = new SqlCommand(queryList["GetAnonymousRespondents"], connector.GetConnection());
        reader = command.ExecuteReader();

        // get the first id (that is the id just entered)
        reader.Read();
        respondentID = Int32.Parse((reader["r_id"].ToString()));
        

        // close connection
        connector.CloseConnection();

        return respondentID;
    }

    public int createRespondent(int typeID, int sysUerID)
    {
        //initiliase variable
        int respondentID = -1;

        // Open a new SQL connection
        SQLConnector connector = new SQLConnector();

        //query
        SqlCommand command = new SqlCommand(queryList["CreateRespondent"], connector.GetConnection());
        command.Parameters.Add("@typeID", SqlDbType.Int);
        command.Parameters["@typeID"].Value = typeID;
        command.Parameters.Add("@sysUserID", SqlDbType.Int);
        command.Parameters["@sysUserID"].Value = sysUerID;
        int affectedRows = command.ExecuteNonQuery();

        // TODO Test
        // Get the new respondent id
        command = new SqlCommand(queryList["GetRespondent"], connector.GetConnection());
        SqlDataReader reader = command.ExecuteReader();

        // get the first id (that is the id just entered)
        respondentID = Int32.Parse((reader["r_id"].ToString()));

        // close connection
        connector.CloseConnection();

        return respondentID;
    }

    public List<SurveyModel> GetListOfRespondentTypeSurveys(int respondentTypeID)
    {
        List<SurveyModel> surveySet = new List<SurveyModel>();
        // get a list of all survey_id based on respondent type id from table RespondentType_Survey
        // Open a new SQL connection
        SQLConnector connector = new SQLConnector();
        
        //query
        SqlCommand command = new SqlCommand(queryList["GetRespondentTypeSurveySet"], connector.GetConnection());
        command.Parameters.Add("@id", SqlDbType.Int);
        command.Parameters["@id"].Value = respondentTypeID;

        // get query results
        SqlDataReader reader = command.ExecuteReader(); 

        
        while (reader.Read())
        {
            // build each survey model
            SurveyModel sm = new SurveyModel();
            sm.SurveyID = Int32.Parse((reader["s_id"].ToString()));
            sm.SurveyName = (string)reader["survey_name"];

            // AND add to set
            surveySet.Add(sm);
        }

        // close connection 
        connector.CloseConnection();


        //return set
        return surveySet;
    }

    public NameValueCollection QueryList
    {
        get
        {
            return queryList;
        }
    }

    public void AddQuery(string identifier, string queryString)
    {
        queryList.Add(identifier, queryString);
    }

    public string GetQueryString(string identifier)
    {
        return queryList[identifier];
    }

    private void BuildQueryList()
    {
        queryList.Add("GetSysUserModel", "SELECT Sys_User.su_id, Sys_User.username, User_Type.ut_id, User_Type.type_name FROM Sys_User INNER JOIN User_Type ON Sys_User.user_type = User_Type.ut_id");
        queryList.Add("GetRespondentModel", 
            "SELECT R.r_ID, R.respondent_type, Respondent_Type.typename, R.sys_user " +
            "FROM Respondent AS R INNER JOIN Respondent_Type " +
            "ON Respondent.respondent_type = Respondent_Type.rt_id");
        queryList.Add("GetRespondentTypeSurveySet", 
            "SELECT RTS.s_id, S.survey_name " +
            "FROM RespondentType_Survey AS RTS INNER JOIN Survey AS S " +
            "ON RTS.s_id = S.s_ID " +
            "WHERE respondent_type = @id");
        queryList.Add("CreateAnonymousRespondent",
            "INSERT INTO Respondent (respondent_type) " +
            "VALUES (@typeID)");
        queryList.Add("CreateRespondent", 
            "INSERT INTO Respondent (respondent_type, sys_user) " +
            "VALUES (@typeID, @sysUserID)");
        queryList.Add("GetHighestRespondentID",
            "SELECT r_id " +
            "FROM Respondent " +
            "ORDER BY r_id DESC " +
            "LIMIT 1");
        queryList.Add("GetAnonymousRespondents",
            "SELECT r_id " +
            "FROM Respondent " +
            "WHERE respondent_type = 1 " +
            "ORDER BY r_id DESC");
        queryList.Add("GetRespondent", 
            "SELECT r_id " +
            "FROM Respondent " +
            "WHERE respondent_type = @typeID AND sys_user = @sysUserID " +
            "ORDER BY r_id DESC");
    }



    /*
       private DataTable GetXX()
       {
           SQLConnector c = new SQLConnector();

           //query
           SqlCommand command = new SqlCommand(queryList["GetRespondentModel"], c.GetConnection());

           SqlDataReader reader = command.ExecuteReader(); //execute command, give results to reader

           //store results in a datatable
           DataTable dt = new DataTable(); 

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

           return dt;

           //Add to the Page Gridview
           //UsersGridView.DataSource = dt;
           //UsersGridView.DataBind();
       } //end method
   */
}