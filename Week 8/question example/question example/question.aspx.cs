using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//ADD THESE
using System.Data.SqlClient;
using System.Configuration;

namespace question_example
{
    public partial class question : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SELECT * FROM TestQuestion, TestQuestionType WHERE TestQuestion.questionType = TestQuestionType.typeID

            //Get current question number
            int currentQuestion = 1;//TESTING, CHANGE BACK TO 1!!!!
            if (HttpContext.Current.Session["questionNumber"] == null)
                HttpContext.Current.Session["questionNumber"] = 1; //then set it
            else
                currentQuestion = (int)HttpContext.Current.Session["questionNumber"];

            //get current question from DB
            SqlConnection connection;
            SqlCommand command;

            //testConnectionString from webconfig
            string connectionString = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString;

            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            connection.Open();//open the sql connection using the connection string info

            //just setup a basic sql command (referencing the connection)
            command = new SqlCommand("SELECT * FROM TestQuestion, TestQuestionType WHERE TestQuestion.questionType = TestQuestionType.typeID AND TestQuestion.questionId = "+currentQuestion, connection);

            SqlDataReader reader = command.ExecuteReader(); //execute above query


            while (reader.Read())
            {
                string questionText = reader["text"].ToString();
                string questionType = reader["typeName"].ToString().ToLower(); //just incase, so we dont have to check for textBox vs TextBox vs textbox
                if (questionType.Equals("textbox"))
                {
                    //TODO load up textbox controls
                    TextQuestionControl textControl = (TextQuestionControl)LoadControl("~/TextQuestionControl.ascx");
                    textControl.ID = "question" + currentQuestion + "Control";
                    textControl.QuestionLabel.Text = questionText;

                    //add it to the ui
                    PlaceHolder1.Controls.Add(textControl);
                }
                else if (questionType.Equals("checkbox"))
                {
                    //TODO load up checkbox controls
                    CheckBoxQuestionControl checkBoxControl = (CheckBoxQuestionControl)LoadControl("~/CheckBoxQuestionControl.ascx");
                    checkBoxControl.ID = "question" + currentQuestion + "Control";
                    checkBoxControl.QuestionLabel.Text = questionText;

                    //TODO load up checkbox options/choices to add to checkbox control
                    SqlCommand optionCommand = new SqlCommand("SELECT * FROM TestQuestionOption WHERE questionId = "+currentQuestion, connection);

                    SqlDataReader optionReader = optionCommand.ExecuteReader();
                    //cycle through all options
                    while (optionReader.Read())
                    {
                        //                           text you see,                      value its worth
                        ListItem item = new ListItem(optionReader["text"].ToString(), optionReader["optionId"].ToString());
                        checkBoxControl.QuestionCheckBoxList.Items.Add(item); //add item to option list
                    }

                    //done, add it to placeholder
                    PlaceHolder1.Controls.Add(checkBoxControl);

                }

            }

            connection.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //reference Custom User Control.zip to get answer from custom controls on screen

            //Get to next question:
            //Note: extract out to method
            int currentQuestion = 1;//TESTING, CHANGE BACK TO 1!!!!
            if (HttpContext.Current.Session["questionNumber"] == null)
                HttpContext.Current.Session["questionNumber"] = 1; //then set it
            else
                currentQuestion = (int)HttpContext.Current.Session["questionNumber"];


            //ALSO check for bonus questions, if they are, add them into the follow up list
            List<Int32> followUpQuestions = new List<int>();
            if (HttpContext.Current.Session["followUpQuestions"] != null)
                followUpQuestions = (List<Int32>)HttpContext.Current.Session["followUpQuestions"];

            if (currentQuestion == 1) //dont do this if statement, check if question actually has follow up questions
            {
                
                //add your follow ups to the list
                followUpQuestions.Add(3);
                followUpQuestions.Add(4);
            }


            //Note: extract out to method
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString;
            connection.ConnectionString = connectionString;

            connection.Open();//open the sql connection using the connection string info


            SqlCommand command = new SqlCommand("SELECT * from TestQuestion where questionId = "+currentQuestion, connection);
            SqlDataReader reader = command.ExecuteReader(); //execute above query

          
            while (reader.Read())
            {
                //if next question is not null
                int nextQuestionColumnIndex = reader.GetOrdinal("nextQuestion");
                if (!reader.IsDBNull(nextQuestionColumnIndex))
                {
                    int nextQuestion = Int32.Parse(reader["nextQuestion"].ToString());
                    HttpContext.Current.Session["questionNumber"] = nextQuestion; //update session with new question number
                    currentQuestion = nextQuestion;

                    //IF THERE IS FOLLOW UP QUESTIONS
                    if (followUpQuestions.Count > 0)
                    {
                        int fq = followUpQuestions[0]; //get first follow up question off the stack
                        followUpQuestions.RemoveAt(0); //remove from the list
                        HttpContext.Current.Session["questionNumber"] = fq;
                    }

                    HttpContext.Current.Session["followUpQuestions"] = followUpQuestions;
                    

                    //go to same page to reload it properly
                    Response.Redirect("question.aspx");
                }
                else
                {

                    //END OF SURVEY, go to final page whatever that is
                }
            }


            //make sure we close connection at the END
            connection.Close();//<==============

        }
    }
}