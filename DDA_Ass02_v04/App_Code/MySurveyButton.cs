using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

/// <summary>
/// Summary description for MySurveyButton
/// </summary>
public class MySurveyButton: Button
{
    int surveyID;
    string surveyName;
    
    public MySurveyButton(int id, string name)
    {
        surveyID = id;
        surveyName = name;
        this.ID = surveyID.ToString();
        this.Text = surveyName;
        this.Attributes.Add("class", "btn btn-primary btn-lg myButton");
        this.Attributes.Add("runat", "server");
        this.Click += new EventHandler(button_Click);
    }

    private void button_Click(object sender, EventArgs e)
    {
        //set session survey
        SessionController.SetCurrentSurvey (((MySurveyButton)sender).surveyID, ((MySurveyButton)sender).surveyName);
        //debug
        System.Diagnostics.Debug.WriteLine("Button Info: " + ((MySurveyButton)sender).surveyID + ":" + ((MySurveyButton)sender).surveyName);

        //open survey page

    }

    public void changeAttribute(string attribute, string value)
    {
        this.Attributes.Add(attribute, value);
    }
}