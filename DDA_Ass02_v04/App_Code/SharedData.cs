using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for SharedData
/// </summary>
public class SharedData : Page
{
    protected static ASPStyleSheet _aspStyleSheet = new ASPStyleSheet();
    protected ListDictionary listOfModels = new ListDictionary();
    private static SortedList<int, QuestionResponseModel> listOfQuestionResponseModels = new SortedList<int, QuestionResponseModel>();

    public SharedData()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    protected static SortedList<int, QuestionResponseModel> ListOfQuestionResponseModels
    {
        get
        {
            return listOfQuestionResponseModels;
        }

        set
        {
            listOfQuestionResponseModels = value;
        }
    }

    public static void ResetResponseList()
    {
        ListOfQuestionResponseModels.Clear();
    }

}