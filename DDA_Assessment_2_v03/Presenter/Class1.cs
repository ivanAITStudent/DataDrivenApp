using System;
using System.Collections.Generic;

namespace Presenter
{
    /* The Role fo the Presenter
    * To provide the View with details about what to display to the user
    * It does this through a data object; A View Model
    * The Presenter Prepares the model with relevant information and view attributes
    * View Model for Survey
    * RespondentID, SurveyID, SurveyTitle
    * QuestionNumber (int), QuestionText, QuestionType, QuestionResponseState (boolean)
    * QuestionStyle (radio, check, drop, text)
    * A ResponseText (string)
    * A list of QuestionAnswerText and their QuestionAnswerState (boolean)
    * Information (surveyID, ) of previous question and next question
    * Survey Progress
    */

    public class Requester
    {
        public Requester()
        {

        }

        public ViewModel getNextQuestion()
        {
            ViewModel vm = new ViewModel();
            return vm;
        }
        public void getQuestionAnswer()
        {

        }

    }//endc

    public class ViewModel
    {
        private string questionText = "";
        private string questionType = "";
        private List<string> questionAnswer;

    } // endc
}
