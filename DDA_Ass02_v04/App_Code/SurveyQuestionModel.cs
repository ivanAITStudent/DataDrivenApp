 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SurveyQuestionModel
/// </summary>
public class SurveyQuestionModel
{
    private int sq_id;
    private int survey_id;
    private int question_id;
    private bool is_a_main_question;
    private string questionText;
    private string questionType;

    public SurveyQuestionModel(int sq_id, int survey_id, int question_id, bool is_a_main_question, string questionText, string questionType)
    {
        this.Sq_id = sq_id;
        this.Survey_id = survey_id;
        this.Question_id = question_id;
        this.Is_a_main_question = is_a_main_question;
        this.QuestionText = questionText;
        this.QuestionType = questionType;
    }

    public int Sq_id
    {
        get
        {
            return sq_id;
        }

        set
        {
            sq_id = value;
        }
    }

    public int Survey_id
    {
        get
        {
            return survey_id;
        }

        set
        {
            survey_id = value;
        }
    }

    public int Question_id
    {
        get
        {
            return question_id;
        }

        set
        {
            question_id = value;
        }
    }

    public bool Is_a_main_question
    {
        get
        {
            return is_a_main_question;
        }

        set
        {
            is_a_main_question = value;
        }
    }

    public string QuestionText
    {
        get
        {
            return questionText;
        }

        set
        {
            questionText = value;
        }
    }

    public string QuestionType
    {
        get
        {
            return questionType;
        }

        set
        {
            questionType = value;
        }
    }
}