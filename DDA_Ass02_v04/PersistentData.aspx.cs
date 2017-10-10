using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PersistentData : Page
{
    //private static RespondentModel _respondentModel;
    //private SurveySet _surveySet;
    //private SurveyModel _surveyModel;

    private ASPStyleSheet _aspStyleSheet;

    public ASPStyleSheet AspStyleSheet
    {
        get
        {
            return _aspStyleSheet;
        }

        set
        {
            _aspStyleSheet = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }
}