using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PT3
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int marks = (int)Session["marks"];
            int totalMarks = (int)Session["totalMarks"];
            Label1.Text = marks.ToString() + " / " + totalMarks.ToString() ;
        }
    }
}