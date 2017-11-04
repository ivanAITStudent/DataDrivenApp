using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Session Controller Sets and Gets Http Session Variables 
/// </summary>
public class SessionController
{
    public static string Anonymous = "anonymous";
    public static string Guest = "guest";
    public static string User = "registered-user";
    public static string Staff = "registered-staff";


    public static string setIP(string _ip)
    {
        /// returns the existing IP address or if null the new ip address
        /// so that it can be verified by caller
        
        if (HttpContext.Current.Session["IPAddress"] == null)
        {
            HttpContext.Current.Session["IPAddress"] = _ip;
        }//end if

        return HttpContext.Current.Session["IPAddress"].ToString();
    }

    public static string getIP()
    {
        return HttpContext.Current.Session["IPAddress"].ToString();
    }

    public static void setDateTime(DateTime entry)
    {
        HttpContext.Current.Session["Date_Time"] = entry;
    }

    public static DateTime getDateTime()
    {
        if (HttpContext.Current.Session["Date_Time"] == null)
        {
            //set null date
            DateTime nullDate = new DateTime(1900, 1, 1, 0, 0, 0);
            HttpContext.Current.Session["Date_Time"] = nullDate;
        }

        return (DateTime)HttpContext.Current.Session["Date_Time"];
    }

    public static string GetUsername()
    {
        return (string)HttpContext.Current.Session["Username"];
    }

    public static void SetUsernreame(string username)
    {
        HttpContext.Current.Session["Username"] = username;
    }

    public static void SetSessionState(string state)
    {
        HttpContext.Current.Session["SessionState"] = state;
    }

    public static string GetSessionState()
    {
        return HttpContext.Current.Session["SessionState"].ToString();
    }

    public static void SetSurveyState(string state)
    {
        HttpContext.Current.Session["SurveyState"] = state;
    }

    public static string GetSurveyState()
    {
        return HttpContext.Current.Session["SurveyState"].ToString();
    }

    public static bool IsLoggedIn()
    {
        string username = GetUsername();
        if (username != null && username.Length > 0)
            return true;
        else
            return false;
    }

    public static void SetRespondentType(string typeName)
    {
        HttpContext.Current.Session["RespondentType"] = typeName;
    }

    public static string GetRespondentType()
    {
        return HttpContext.Current.Session["RespondentType"].ToString();
    }

    public static void SetRespondentID (int _id)
    {
        HttpContext.Current.Session["RespondentID"] = _id;
    }

    public static int GetRespondentID()
    {
        if (HttpContext.Current.Session["RespondentID"] == null)
           return -1;
        else 
            return (int)HttpContext.Current.Session["CurrentSurveyQuestionID"];

    }

    public static int GetCurrentQuestionNumber()
    {
        if (HttpContext.Current.Session["CurrentQuestionNumber"] == null)
            HttpContext.Current.Session["CurrentQuestionNumber"] = -1; //then set it to the int null -1

        return (int)HttpContext.Current.Session["CurrentQuestionNumber"];
    }

    public static void SetCurrentQuestionNumber(int num)
    {
        HttpContext.Current.Session["CurrentQuestionNumber"] = num;
    }


    public static void IncrementQuestionNumber()
    {
        int q = GetCurrentQuestionNumber();
        q++;
        HttpContext.Current.Session["CurrentQuestionNumber"] = q;
    }

    public static void SetCurrentSurveyQuestionID(int id)
    {
        HttpContext.Current.Session["CurrentSurveyQuestionID"] = id;
    }

    public static int GetCurrentSurveyQuestionID()
    {
        if (HttpContext.Current.Session["CurrentSurveyQuestionID"] == null)
            HttpContext.Current.Session["CurrentSurveyQuestionID"] = -1;

        return (int)HttpContext.Current.Session["CurrentSurveyQuestionID"];
    }

    public static void SetPreviousSurveyQuestionID(int id)
    {
        HttpContext.Current.Session["PreviousSurveyQuestionID"] = id;
    }

    public static int GetPreviousSurveyQuestionID()
    {
        if (HttpContext.Current.Session["PreviousSurveyQuestionID"] == null)
            HttpContext.Current.Session["PreviousSurveyQuestionID"] = -1;

        return (int)HttpContext.Current.Session["PreviousSurveyQuestionID"];
    }

    public static void SetNextSurveyQuestionID(int id)
    {
        HttpContext.Current.Session["NextSurveyQuestionID"] = id;
    }

    public static int GetNextSurveyQuestionID()
    {
        if (HttpContext.Current.Session["NextSurveyQuestionID"] == null)
            HttpContext.Current.Session["NextSurveyQuestionID"] = -1;

        return (int)HttpContext.Current.Session["NextSurveyQuestionID"];
    }

    public static void SetCurrentSurvey(int _id, string _name)
    {
        HttpContext.Current.Session["CurrentSurveyID"] = _id;
        HttpContext.Current.Session["CurrentSurveyName"] = _name;
    }

    public static int GetSurveyID()
    {
        if (HttpContext.Current.Session["NextSurveyQuestionID"] == null)
            return -1;
        else
            return (int)HttpContext.Current.Session["CurrentSurveyID"];
    }

    public static string GetSurveyName()
    {
        return (string)HttpContext.Current.Session["CurrentSurveyName"];
    }
}