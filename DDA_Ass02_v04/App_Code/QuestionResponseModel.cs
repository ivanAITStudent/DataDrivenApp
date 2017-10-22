using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for QuestionResponseModel
/// </summary>
public class QuestionResponseModel
{
    private SurveyQuestionModel question;
    private SurveyQuestionAnswerOption options;
    private ResponseModel response;

    public QuestionResponseModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public SurveyQuestionModel Question
    {
        get
        {
            return question;
        }

        set
        {
            question = value;
        }
    }

    public SurveyQuestionAnswerOption Options
    {
        get
        {
            return options;
        }

        set
        {
            options = value;
        }
    }

    public ResponseModel Response
    {
        get
        {
            return response;
        }

        set
        {
            response = value;
        }
    }
}