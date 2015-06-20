using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;

namespace PT3.BLL
{
    public class Test
    {
        int testID;

        List<Question> questions;

        public Test()
        {

        }

        public Test(int testID)
        {
            this.testID = testID;
        }

        public void fillQuestion()
        {
            DataDataContext data = new DataDataContext();

            var question = from q in data.testquestions
                           where q.testID == testID
                           select q.questions;

            LINQ.question q2 = (from q in data.questions
                                where q.questionID == 3
                                select q).Single();
            q2.questionMarks = 20;
            data.SubmitChanges();

            questions = (List<Question>)question;
        }
    }
}