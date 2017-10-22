public class RespodentSurveyModel
{
    int respondentSurveyID;
    int respondentID;
    int surveyID;
    bool completed;

    public RespodentSurveyModel(int respondentSurveyID, int respondentID, int surveyID, bool completed)
    {
        this.RespondentSurveyID = respondentSurveyID;
        this.RespondentID = respondentID;
        this.SurveyID = surveyID;
        this.Completed = completed;
    }

    public int RespondentSurveyID
    {
        get
        {
            return respondentSurveyID;
        }

        set
        {
            respondentSurveyID = value;
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

    public int SurveyID
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

    public bool Completed
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
}