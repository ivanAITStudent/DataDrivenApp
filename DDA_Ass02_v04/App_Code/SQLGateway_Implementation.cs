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
    private NameValueCollection queryList; 
    public SQLGateway_Implementation()
    {
        queryList = new NameValueCollection();
        BuildQueryList();
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