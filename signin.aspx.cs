using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        UserClass user1 = new UserClass();
        if (user1.UserExist(this.userEmailBox.Text, this.passwordBox.Text))
        {
            Session["Type"] = "User";
            Session["user"] = user1.UserDetails(this.userEmailBox.Text);
            Session["bday"] = user1.UserBday(this.userEmailBox.Text);
            Session["email"] = this.userEmailBox.Text;
            Response.Redirect("~/homeU.aspx");
        }
        else
        {

            this.Label3.Visible = true;
        }
    }
}