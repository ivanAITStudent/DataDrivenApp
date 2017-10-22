using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ResponseModel
/// </summary>
public class ResponseModel
{
    private int respondentSurveyID;
    private int surveyQuestionID;
    private int answerOptionIDSelected;
    private string typedResponse;
    private object formattedTypedResponse;

    public ResponseModel(int surveyQuestionID, int respondentSurveyID, int answerOptionIDSelected, string typedResponse, object formattedTypedResponse)
    {
        this.surveyQuestionID = surveyQuestionID;
        this.respondentSurveyID = respondentSurveyID;
        this.answerOptionIDSelected = answerOptionIDSelected;
        this.typedResponse = typedResponse;
        this.formattedTypedResponse = formattedTypedResponse;
    }

    public int SurveyQuestionID
    {
        get
        {
            return surveyQuestionID;
        }

        set
        {
            surveyQuestionID = value;
        }
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

    public int AnswerOptionIDSelected
    {
        get
        {
            return answerOptionIDSelected;
        }

        set
        {
            answerOptionIDSelected = value;
        }
    }

    public string TypedResponse
    {
        get
        {
            return typedResponse;
        }

        set
        {
            typedResponse = value;
        }
    }

    public object FormattedTypedResponse
    {
        get
        {
            return formattedTypedResponse;
        }

        set
        {
            formattedTypedResponse = value;
        }
    }
}