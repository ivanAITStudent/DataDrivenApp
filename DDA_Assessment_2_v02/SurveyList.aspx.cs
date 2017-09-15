using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SurveyList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //open connection
        //get list of surveys and survey id's from db
        //close connection
        //populate place holder

        //get selected

        SurveyList_Button but1 = new SurveyList_Button("123");
        but1.Click += new EventHandler(buttonClick);
        but1.Text = "Button name";
        tableOfSurveys.Controls.Add(but1);
        tableOfSurveys.Controls.Add(but1);

    }

    private void buttonClick(object sender, EventArgs e)
    {
        ((Button)sender).Text = "Changed";
    }
}