using System;

public class SurveyModel
{
    private Int32 surveyID;
    private string surveyName;
    private string surveyDescription;
    private string availablitiy;
    private string completed;
    private string status;

    public SurveyModel()
    {

    }

    public SurveyModel(int _id, string _name)
    {
        SurveyID = _id;
        SurveyName = _name;
    }

    public Int32 SurveyID
    {
        get
        {
            return surveyID;
        }

        set
        {
            surveyID = value;
        }
    }

    public string SurveyName
    {
        get
        {
            return surveyName;
        }

        set
        {
            surveyName = value;
        }
    }

    public string SurveyDescription
    {
        get
        {
            return surveyDescription;
        }

        set
        {
            surveyDescription = value;
        }
    }

    public string Availablitiy
    {
        get
        {
            return availablitiy;
        }

        set
        {
            availablitiy = value;
        }
    }

    public string Completed
    {
        get
        {
            return completed;
        }

        set
        {
            completed = value;
        }
    }

    public string Status
    {
        get
        {
            return status;
        }

        set
        {
            status = value;
        }
    }
}