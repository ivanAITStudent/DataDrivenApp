using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Boundry_GetSurveySet
/// </summary>
public interface Boundry_GetSurveySet
{
    List<SurveyModel> GetSet(int respondentID);
}