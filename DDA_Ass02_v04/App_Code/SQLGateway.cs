using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQLGateway
/// </summary>
public interface SQLGateway
{
    List<SurveyModel> GetListOfRespondentTypeSurveys(int RespondentTypeID);
    int createAnonymousRespondent(); // returns highest respondentID
    int createRespondent(int typeID, int sysUerID); // returns respondentID
}