using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PT3
{
    public partial class MainPage : System.Web.UI.Page
    {
        BLL.User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("./Login.aspx");

            user = (BLL.User)Session["user"];
        }
    }
}