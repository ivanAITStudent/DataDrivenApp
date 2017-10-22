using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SurveyQuestionAnswerOption
/// </summary>
public class SurveyQuestionAnswerOption
{
    private int surveyQuestionID;
    private int answerOptionID;
    private int supQuestionID;
    private string group;
    private string answerOptionText;

    public SurveyQuestionAnswerOption(int surveyQuestionID, int answerOptionID, int supQuestionID, string group, string answerOptionText)
    {
        this.SurveyQuestionID = surveyQuestionID;
        this.AnswerOptionID = answerOptionID;
        this.SupQuestionID = supQuestionID;
        this.Group = group;
        this.AnswerOptionText = answerOptionText;
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

    public int AnswerOptionID
    {
        get
        {
            return answerOptionID;
        }

        set
        {
            answerOptionID = value;
        }
    }

    public int SupQuestionID
    {
        get
        {
            return supQuestionID;
        }

        set
        {
            supQuestionID = value;
        }
    }

    public string Group
    {
        get
        {
            return group;
        }

        set
        {
            group = value;
        }
    }

    public string AnswerOptionText
    {
        get
        {
            return answerOptionText;
        }

        set
        {
            answerOptionText = value;
        }
    }
}