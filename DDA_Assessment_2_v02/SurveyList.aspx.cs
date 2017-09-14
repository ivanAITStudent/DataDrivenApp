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

        Button but1 = new Button();
        Button but2 = new Button();
        but1.Text = "button 1";
        but2.Text = "button 2";
        but1.Click += new EventHandler();
        tableOfSurveys.Controls.Add(but1);
        tableOfSurveys.Controls.Add(but2);

    }

    private void But1_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}