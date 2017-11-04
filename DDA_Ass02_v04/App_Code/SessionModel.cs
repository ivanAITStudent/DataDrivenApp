using System;

/// <summary>
/// Summary description for SessionModel
/// </summary>
public class SessionModel
{
    private string _ipaddress;
    private DateTime _sessionOpenDate;
    private DateTime _sessionClosedDate;
    private int respondentID;
    private string respondentType;
    private int sysUserID;
    private string username;

    public SessionModel(string ip, DateTime date)
    {
        this._ipaddress = ip;
        this._sessionOpenDate = date;
    }

    public string Ipaddress
    {
        get
        {
            return _ipaddress;
        }

    }

    public DateTime SessionOpenDate
    {
        get
        {
            return _sessionOpenDate;
        }
    }

    public int RespondentID
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

    public int SysUserID
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

    public string RespondentType
    {
        get
        {
            return respondentType;
        }

        set
        {
            respondentType = value;
        }
    }

    public DateTime SessionClosedDate
    {
        get
        {
            return _sessionClosedDate;
        }

        set
        {
            _sessionClosedDate = value;
        }
    }
}