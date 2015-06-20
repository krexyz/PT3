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
        int _questionType;
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

        public int questionType
        {
            get { return _questionType; }
            set { _questionType = value; }
        }

        public string A
        {
            get { return answers[0]; }
        }
        public string B
        {
            get { return answers[1]; }
        }
        public string C
        {
            get { return answers[2]; }
        }
        public string D
        {
            get { return answers[3]; }
        }

        

        public Question()
        {

        }

        public Question(int questionID)
        {
            _questionID = questionID;
        }

        public void getQuestion()
        {
            DataDataContext data = new DataDataContext();

            var getQ = from a in data.questions 
                       where (a.questionID == _questionID)
                       select new {a.questionText, a.questionType, a.questionMarks, a.questionAnswer, a.objectiveanswers};

            _questionText = getQ.First().questionText;
            _correctAnswer = getQ.First().questionAnswer;
            _marks = (int)getQ.First().questionMarks;
            _questionType = (int)getQ.First().questionType;

            answers = new string[4];

            if (_questionType == 1)
            {
                answers[0] = getQ.First().objectiveanswers.AnswerA;
                answers[1] = getQ.First().objectiveanswers.AnswerB;
                answers[2] = getQ.First().objectiveanswers.AnswerC;
                answers[3] = getQ.First().objectiveanswers.AnswerD;
            }
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