using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SessionModel
/// </summary>
public class SessionModel
{
    private string _ipaddress;
    private DateTime _date;
    private string respondent_survey_ID;
    private string respondentID;
    private string sysUserID;
    private string username;

    public SessionModel(string ip, DateTime date)
    {
        this._ipaddress = ip;
        this._date = date;
        Username = "";
        RespondentID = "";
        SysUserID = "";
        Respondent_Survey_ID = "";
    }

    public string Ipaddress
    {
        get
        {
            return _ipaddress;
        }

    }

    public DateTime Date
    {
        get
        {
            return _date;
        }
    }

    public string Respondent_Survey_ID
    {
        get
        {
            return respondent_survey_ID;
        }

        set
        {
            respondent_survey_ID = value;
        }
    }

    public string RespondentID
    {
        get
        {
            return respondentID;
        }

        set
        {
            respondentID = value;
        }
    }

    public string SysUserID
    {
        get
        {
            return sysUserID;
        }

        set
        {
            sysUserID = value;
        }
    }

    public string Username
    {
        get
        {
            return username;
        }

        set
        {
            username = value;
        }
    }
}