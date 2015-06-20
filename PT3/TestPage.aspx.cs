using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PT3
{
    public partial class TestPage : System.Web.UI.Page
    {
        List<BLL.Question> q = new List<BLL.Question>();
        BLL.Question currentQuestion;

        int no;
        int marks;
        int totalMarks;
        int totalQuestion;

        protected void Page_Load(object sender, EventArgs e)
        {
            no = 1;

            if (Request.QueryString["q"] != null)
                no = int.Parse(Request.QueryString["q"]);

            for (int i=1;i<=4;i++){
                BLL.Question temp = new BLL.Question(i);
                temp.getQuestion();

                q.Add(temp);
            }

            currentQuestion = q[no-1];
            totalQuestion = q.Count();

            if (Session["marks"] != null)
                marks = (int)Session["marks"];

            if (Session["totalMarks"] != null)
                totalMarks = (int)Session["totalMarks"];
            
            Label1.Text = "Question "+ no;
            Label2.Text = currentQuestion.questionText;
            if (currentQuestion.questionType ==1){
                Label3.Text = "A: "+ currentQuestion.A;
                Label3.Text += "<br/>B: "+ currentQuestion.B;
                Label3.Text += "<br/>C: " + currentQuestion.C;
                Label3.Text += "<br/>D: " + currentQuestion.D;
            }
            else
            {
                Label3.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            totalMarks += currentQuestion.marks;
            Session["totalMarks"] = totalMarks;

            if (TextBox1.Text.ToLower() == currentQuestion.correctAnswer.ToLower())
            {
                marks += currentQuestion.marks;
                Session["marks"] = marks;
            }

            no++;

            if (no <= totalQuestion)
                Response.Redirect("TestPage.aspx?q=" + no);
            else
                Response.Redirect("Result.aspx");
        }
    }
}