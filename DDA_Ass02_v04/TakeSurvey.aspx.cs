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
            surveySet_plc.Controls.Add(b);
        }
    }
}