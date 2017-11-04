using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Boundry_ConductSurvey
/// </summary>
public interface Boundry_ConductSurvey
{
    RespondentSurveyModel BeginSurvey(SessionModel sessionDetails, SurveyModel surveyDetails);
    List<SurveyQuestionModel> BuildSurvey(int surveyID);
    SurveyQuestionAnswerOption BuildQuestion(SurveyQuestionModel question);
    int StoreResponse(ResponseModel response);
    int ConcludeSurvey(SessionModel sessionDetails, RespondentSurveyModel respondentSurveyDetails); //
}