using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contactU : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void message_TextChanged(object sender, EventArgs e)
    {
        if (message.Text.Count() == 0 || !agree.Checked)
        {
            send.Visible = false;
        }
        else
        {
            send.Visible = true;
        }
    }


    protected void send_Click(object sender, EventArgs e)
    {
        UserClass user0 = new UserClass();
        user0.UserFirstName = (string)Session["user"];
        user0.Email = (string)Session["email"];
        user0.Insertmessage(message.Text, DateTime.Now);
    }
}