using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Interactor_ConductSurvey
/// </summary>
public class Interactor_ConductSurvey:Boundry_ConductSurvey
{
    public Interactor_ConductSurvey()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public RespondentSurveyModel BeginSurvey(SessionModel sessionDetails, SurveyModel surveyDetails)
    {
        //initialise types
        int respondentID = -1;
        string respondentType = sessionDetails.RespondentType;
        int surveyID = surveyDetails.SurveyID;
        RespondentSurveyModel rsm = new RespondentSurveyModel();
        
        // set respondent id by checking respondent type
        if (respondentType.Equals("Anonymous"))// IF sessionDetails.resType is "anonymous"
        {
            respondentID = createAnonymousRespondent();
        }
        else
        {
            //fetch respondent ID associated to 
            respondentID = sessionDetails.RespondentID;
        }// END IF

        rsm.SurveyID = surveyID;
        rsm.RespondentID = respondentID;
        rsm.Completed = false;
        //TODO
        //rsm.RespondentSurveyID = createRespondentSurvey(rsm);
        //createSessionRecord(sessionDetails, rsm);

        return rsm;
    }//end method

    private int createAnonymousRespondent()
    {
        // TODO: query database for typeID corresponding to typeID
        // for now using hard code of 1
        SQLGateway gate = new SQLGateway_Implementation();
        int id = gate.createAnonymousRespondent();
        return id;
    }

    public SurveyQuestionAnswerOption BuildQuestion(SurveyQuestionModel question)
    {
        throw new NotImplementedException();
    }

    public List<SurveyQuestionModel> BuildSurvey(int surveyID)
    {
        throw new NotImplementedException();
    }

    public int ConcludeSurvey(SessionModel sessionDetails, RespondentSurveyModel respondentSurveyDetails)
    {
        throw new NotImplementedException();
    }

    public int StoreResponse(ResponseModel response)
    {
        throw new NotImplementedException();
    }
}