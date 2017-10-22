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
    private int surveyID;
    private string surveyName;
    
    public MySurveyButton(int id, string name)
    {
        SurveyID = id;
        SurveyName = name;
        this.ID = SurveyID.ToString();
        this.Text = SurveyName;
        this.Attributes.Add("class", "btn btn-primary btn-lg myButton");
        this.Attributes.Add("runat", "server");
        //this.Click += new EventHandler(button_Click);
    }

    public int SurveyID
    {
        get
        {
            return surveyID;
        }

        set
        {
            surveyID = value;
        }
    }

    public string SurveyName
    {
        get
        {
            return surveyName;
        }

        set
        {
            surveyName = value;
        }
    }

    public void changeAttribute(string attribute, string value)
    {
        this.Attributes.Add(attribute, value);
    }
}