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

        /* ALGORITHM FOR CONDUCTING A SURVEY
         * 
         * IF survey is commencing
         * then 
         *      build survey model
         *      update survey state
         *      get first question
         *      update question model
         *      display question model
         *      capture user response
         * ELSE IF survey is in progress
         *      get next question
         *      update question model
         *      display question model
         *       capture user response
         * ELSE IF survey is concluded
         *      finalise survey model
         *      conclude survey
         * END IF
         * 
         * update survey state
         * redirect user
         */





        // if survey is commencing 
        if (SessionController.GetSurveyState() == null) // survey is commencing if the survey has no set state 
        {

            //Get Session Variables For Models
            string sessionIP = SessionController.getIP();
            DateTime sessionDateTime = SessionController.getDateTime();
            int surveyID = SessionController.GetSurveyID();
            string surveyName = SessionController.GetSurveyName();
            string respondentType = SessionController.GetRespondentType();

            // Build necessary models to pass to the application
            SessionModel snm;
            snm = new SessionModel(sessionIP, sessionDateTime);
            snm.RespondentType = SessionController.GetRespondentType();
            SurveyModel svm;
            svm = new SurveyModel(SessionController.GetSurveyID(), SessionController.GetSurveyName());

            if (!respondentType.Equals(SessionController.Anonymous))
            {
                // add respondent id, and username to session model
                snm.RespondentID = SessionController.GetRespondentID();
                snm.Username = SessionController.GetUsername();
            } //end if

            //begin survey
            Boundry_ConductSurvey interactor = new Interactor_ConductSurvey();
            interactor.BeginSurvey(snm, svm);

            // update survey state
            SessionController.SetSurveyState("Survey In Progress");

            // get first question id (respondentSurveyModel.SurveyID)

            // updateQuestionModel
        }



        // UPDATE PAGE

        // Page Components 
        // Title label
        headerTitle_lbl.Text = SessionController.GetSurveyName();
        
        // Question label
        questionNumber_lbl.Text = SessionController.GetCurrentQuestionNumber().ToString();
        // buttons
        MyQuestionButton left_btn;
        MyQuestionButton right_btn;
        MyQuestionButton centre_btn;

        // setup buttons
        // set up left button
        left_btn = new MyQuestionButton(-1, "PREVIOUS", false);
        //set up right button
        right_btn = new MyQuestionButton(-1, "NEXT", true);
        //set centre button
        centre_btn = new MyQuestionButton(-1, "SUBMIT RESPONSE", true);

        // add listeners
        // upadte listerners links
        // set question id links
        //      SessionController.SetCurrentSurveyQuestionID = ;
        //      SessionController.SetPreviousSurveyQuestionID = ;
        //      SessionController.SetNextSurveyQuestionID = ;


        // add listeners
        left_btn.Click += new EventHandler(left_btn_Click);
        right_btn.Click += new EventHandler(right_btn_Click);
        centre_btn.Click += new EventHandler(centre_btn_Click);

        //add buttons to page
        surveySet_plc.Controls.Add(left_btn);
        surveySet_plc.Controls.Add(centre_btn);
        surveySet_plc.Controls.Add(right_btn);

        // display question text

        // display question options

        //debug
        debug_lbl.Text = SessionController.GetSurveyState();
    }//end method

    private void left_btn_Click(object sender, EventArgs e)
    {
        // capture response

        // update survey state

        // redirect
        // example, Response.Redirect("/Survey.aspx");
        /// string link = getLink(id);
        /// Response.Redirect(link);
    }//end method

}//end class