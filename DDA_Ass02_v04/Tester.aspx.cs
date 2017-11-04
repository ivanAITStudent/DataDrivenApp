using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tester : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
         * Test Begin Survey
         * Tested and Successful 26OCT17 5am
         *
        SessionModel snm;
        SurveyModel svym;
        RespondentSurveyModel rsm;

        // build session model
        DateTime dt = DateTime.Now;
        snm = new SessionModel("000.0.0.0", dt);
        snm.RespondentType = 1;

        // build survey model
        svym = new SurveyModel();
        svym.SurveyID = 3;
        svym.SurveyName = "Survey 1";

        //initialise resp survey model
        rsm = new RespondentSurveyModel();

        // test SQL
        Boundry_ConductSurvey survey = new Interactor_ConductSurvey();
        rsm = survey.BeginSurvey(snm, svym);

        debug_lbl.Text = "respID = " + rsm.RespondentID + "\n" + 
                            "surveyID = " + rsm.SurveyID + "\n" +
                                "respSvyID = " + rsm.RespondentSurveyID + "\n" +
                                    "completed = " + rsm.Completed;
        *///END TEST

        /*
         * Test getHighestAnonymousRespondent
         * Tested and Successful 26OCT17 5am
         *
        int id = -1;
        SQLGateway_Implementation survey = new SQLGateway_Implementation();
        id = survey.getHighestAnonymousID();
        debug_lbl.Text = "resID = " + id;
        *///END TEST
    }
}