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

public class MyQuestionButton: Button
{
    private int questionID;
    private string buttonTitle;
    

    public MyQuestionButton(int _questionID, string _buttonTitle, bool _enabled)
    {
        this.questionID = _questionID;
        this.buttonTitle = _buttonTitle;
        this.Enabled = _enabled;
        this.ID = _buttonTitle + "_btn";
        this.Text = _buttonTitle;
        this.Attributes.Add("class", "btn btn-primary btn-lg myButton");
        this.Attributes.Add("runat", "server");
        //this.Click += new EventHandler(button_Click);
    }

    public void changeAttribute(string attribute, string value)
    {
        this.Attributes.Add(attribute, value);
    }
}