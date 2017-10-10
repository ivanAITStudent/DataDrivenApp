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
        HttpContext.Current.Session["UserName"] = username;
    }
    public static string getUserName()
    {
        return (string)HttpContext.Current.Session["UserName"];
        //return HttpContext.Current.Session["UserName"] as string;
    }
    public static bool IsLoggedIn()
    {
        string username = getUserName();
        if (username != null && username.Length > 0)
            return true;
        else
            return false;

    }
    public static int getQuestionNumber()
    {
        //if question number not set in current session
        if (HttpContext.Current.Session["questionNumber"] == null)
            HttpContext.Current.Session["questionNumber"] = 1; //then set it

        return (int)HttpContext.Current.Session["questionNumber"];
    }
    public static void incrementQuestionNumber()
    {
        int q = getQuestionNumber();
        q++;
        HttpContext.Current.Session["questionNumber"] = q;
    }
}