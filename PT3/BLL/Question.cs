using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;


namespace PT3.BLL
{
    public class Question
    {
        int _questionID;
        string _questionText;
        string _correctAnswer;
        int _marks;

        String[] answers;

        public int questionID { get { return _questionID; } }
        public string questionText {
            get { return _questionText; }
            set { _questionText = value; }
        }
        public string correctAnswer { 
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }
        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        

        public Question()
        {

        }

        public void getQuestion()
        {

        }

        public void addQuestion()
        {
            DataDataContext data = new DataDataContext();

            LINQ.question q = new question();

            q.questionText = _questionText;
            q.questionAnswer = _correctAnswer;
            q.questionType = 1;
            q.questionMarks = _marks;

            data.questions.InsertOnSubmit(q);
            data.SubmitChanges();

            _questionID = q.questionID;
        }

        public void addObjectiveQuestion()
        {
            DataDataContext data = new DataDataContext();
            LINQ.objectiveanswer oa = new objectiveanswer();

            addQuestion();

            oa.questionID = _questionID;
            oa.AnswerA = answers[0];
            oa.AnswerB = answers[1];
            oa.AnswerC = answers[2];
            oa.AnswerD = answers[3];

            data.objectiveanswers.InsertOnSubmit(oa);
            data.SubmitChanges();
        }

        
    }
}