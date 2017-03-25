using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            password1.TextMode = TextBoxMode.SingleLine;
            password2.TextMode = TextBoxMode.SingleLine;
        }
        else
        {
            password1.TextMode = TextBoxMode.Password;
            password2.TextMode = TextBoxMode.Password;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (password1.Text.CompareTo(password2.Text) != 0)
        {
            alert.Visible = true;//password does not match
        }
        else
        {
            alert.Visible = false;
            UserClass user1 = new UserClass();

            user1.UserType = "User";
            user1.Email = email.Text;
            user1.UserFirstName = name.Text;
            user1.UserPassword = password1.Text;
            user1.BirthDate = DateTime.Parse(birthday.Text);
            if (user1.InsertNewUser())
            {
                Session["Type"] = "User";
                Session["user"] = user1.UserFirstName;
                Session["bday"] = user1.BirthDate;
                Session["email"] = user1.Email;
                Response.Redirect("~/homeU.aspx");
            }else
            {
                taken.Visible = true;
            }
        }
    }
}