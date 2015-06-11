using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;


namespace PT3.BLL
{
    public class Question
    {
        int questionID;
        string question;
        string correctAnswer;
        int marks;

        String [] answers;

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

            q.questionText = question;
            q.questionAnswer = correctAnswer;
            q.questionType = 1;
            q.questionMarks = marks;

            data.questions.InsertOnSubmit(q);
            data.SubmitChanges();

        }

        public void addObjectiveQuestion()
        {
            DataDataContext data = new DataDataContext();
            LINQ.objectiveanswer oa = new objectiveanswer();

            addQuestion();

            oa.questionID = questionID;
            oa.AnswerA = answers[0];
            oa.AnswerB = answers[1];
            oa.AnswerC = answers[2];
            oa.AnswerD = answers[3];

            data.objectiveanswers.InsertOnSubmit(oa);
            data.SubmitChanges();
        }
    }
}