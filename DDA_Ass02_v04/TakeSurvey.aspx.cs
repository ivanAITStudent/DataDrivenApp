using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TakeSurvey : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //onload
        //get survey set based on respondent type
        Boundry_GetSurveySet boundry = new Interactor_GetSurveySet();
        List<SurveyModel> sm = boundry.GetSet(SessionController.GetRespondentTypeID());
        foreach (SurveyModel model in sm)
        {
            MySurveyButton b = new MySurveyButton(model.SurveyID, model.SurveyName);
            b.Click += new EventHandler(button_Click);
            surveySet_plc.Controls.Add(b);
        }
    }

    private void button_Click(object sender, EventArgs e)
    {
        //save session survey details
        SessionController.SetCurrentSurvey(((MySurveyButton)sender).SurveyID, ((MySurveyButton)sender).SurveyName);

        //open survey page to conduct survey
        Response.Redirect("/Survey.aspx");
    }
}