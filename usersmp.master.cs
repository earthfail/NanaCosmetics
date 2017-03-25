using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersmp : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            uname.Text = (string)Session["user"];
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 5)
                sentence.Text = "good morning ";
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
                sentence.Text = "good afternoon ";
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 19)
                sentence.Text = "good evening ";
            else
                sentence.Text = "good night ";

        if (((DateTime)Session["bday"]).Month == DateTime.Now.Month && ((DateTime)Session["bday"]).Day == DateTime.Now.Day)
          bday.Text = "Happy birthday " + uname.Text;
       else
        bday.Text = ((((DateTime)Session["bday"]).DayOfYear - DateTime.Now.DayOfYear+365)%365).ToString()+"days left";
        
    }
}
