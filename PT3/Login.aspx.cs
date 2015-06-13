using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PT3.BLL;

namespace PT3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            BLL.User user = new User();

            user.username = txtUsername.Text;

            if (user.login(txtPassword.Text) > 0)
            {
                user = user.getUser();
                Session["user"] = user;

                Response.Redirect("./MainPage.aspx");
            }
        }
    }
}