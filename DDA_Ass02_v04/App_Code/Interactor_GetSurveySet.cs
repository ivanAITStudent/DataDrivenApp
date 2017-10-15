using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Interactor_GetSurveySet
/// </summary>
public class Interactor_GetSurveySet: Boundry_GetSurveySet
{
    public Interactor_GetSurveySet()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<SurveyModel> GetSet(int respondentID)
    {
        SQLGateway gate = new SQLGateway_Implementation();
        List<SurveyModel> set = gate.GetListOfRespondentTypeSurveys(respondentID);
        return set;
    }
}