using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Boundry_ConductSurvey
/// </summary>
public interface Boundry_ConductSurvey
{
    RespodentSurveyModel BeginSurvey(SessionModel sessionDetails);
    List<SurveyQuestionModel> BuildSurvey(int surveyID);
    SurveyQuestionAnswerOption GetNextQuestion(SurveyQuestionModel question);
    int StoreResponse(ResponseModel response);
}