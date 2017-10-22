using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Survey : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if survey is commencing
        //then 
        //build survey model (survey id)
        //commence survey##
        //else if survey is in progress 
        //then
        //build next question
        //display next question
        //capture response
        //store response
        //else if survey has ended
        //then 
        //finalise survey
        //save all details
        //show thankyou message
        //reset all session variables
        //return to survey menu


        //check to see if survey is beginning or in progress or ended
        if (SessionController.GetSessionState() == null)
        {
            //Survey is beginning

            //build survey model

            //update session details
            SessionController.SetSessionState("In Progress");
            SessionController.SetCurrentQuestionNumber(1);

            HttpContext.Current.Session["CurrentQuestionID"] = "inProgress";
            HttpContext.Current.Session["PreviousQuestionID"] = null;
            HttpContext.Current.Session["NextQuestionID"] = getNextQuestionID(HttpContext.Current.Session["CurrentQuestionID"];

            //commence survey
        } else if (SessionController.GetSessionState() == "In Progress)
        {

        }
        //Survey in Progress
        //get survey session details and update page to reflect details
        //display current question
        //Check if the survey has just started else set current question


        if (HttpContext.Current.Session["questionNumber"] == null)
        {
            HttpContext.Current.Session["questionNumber"] = 1;

            //set question to first questin
            currentQuestion = 1;

            //set current previous and next id
            previousSurveyQuestionID = -1; // null reference

            List<QuestionResponseModel> surveyQuestionSet = new List<QuestionResponseModel>();
            surveyQuestionSet = getSurveyQuestionSet();
            currentHttpContext.Current.Session["surveyQuestion"] = surveyQuestionList[0].;



        }
        else
            currentQuestion = (int)HttpContext.Current.Session["questionNumber"];

        //display question type with options

        //capture response

        //update question number
    }
}