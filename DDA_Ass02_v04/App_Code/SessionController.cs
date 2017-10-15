using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SessionController
/// </summary>
public class SessionController
{
    public static string setIP(string _ip)
    {
        //TODO TRY CATCH
        string currentValue = (string)HttpContext.Current.Session["IPAddress"];

        if (currentValue == null)
        {
            HttpContext.Current.Session["IPAddress"] = _ip;
            currentValue = (string)HttpContext.Current.Session["IPAddress"];
        }//end if

        return currentValue;
    }

    public static string getIP()
    {
        return (string)HttpContext.Current.Session["IPAddress"];
    }

    public static void setDateTime(DateTime entry)
    {
        HttpContext.Current.Session["Date_Time"] = entry;
    }

    public static DateTime getDateTime()
    {
        return (DateTime)HttpContext.Current.Session["Date_Time"];
    }

    public static void setUserName(string username)
    {
        HttpContext.Current.Session["Username"] = username;
    }

    public static string getUsername()
    {
        return (string)HttpContext.Current.Session["Username"];
        //return HttpContext.Current.Session["UserName"] as string;
    }

    public static bool IsLoggedIn()
    {
        string username = getUsername();
        if (username != null && username.Length > 0)
            return true;
        else
            return false;
    }

    public static void SetRespondentType(int typeID, string typeName)
    {
        HttpContext.Current.Session["RespondentTypeID"] = typeID;
        HttpContext.Current.Session["RespondentTypeName"] = typeName;
    }

    public static int GetRespondentTypeID()
    {
        return (int)HttpContext.Current.Session["RespondentTypeID"];
    } 

    public static string GetRespondentTypeName()
    {
        return (string)HttpContext.Current.Session["RespondentTypeName"];
    }

    public static int GetCurrentQuestionNumber()
    {
        //Set the question number to 1 if no number is set
        if (HttpContext.Current.Session["CurrentQuestionNumber"] == null)
            HttpContext.Current.Session["CurrentQuestionNumber"] = 1; //then set it

        return (int)HttpContext.Current.Session["CurrentQuestionNumber"];
    }

    public static void IncrementQuestionNumber()
    {
        int q = GetCurrentQuestionNumber();
        q++;
        HttpContext.Current.Session["CurrentQuestionNumber"] = q;
    }

    public static void SetCurrentSurvey(int _id, string _name)
    {
        HttpContext.Current.Session["CurrentSurveyID"] = _id;
        HttpContext.Current.Session["CurrentSurveyName"] = _name;
    }
}