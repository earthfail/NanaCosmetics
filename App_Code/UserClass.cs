using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public class UserClass
{

    private string email;
    private string userPassword;
    private string fname;
    private DateTime birthDate;
    private string userType;//admin or user or guest
  
    

    public UserClass()

    { 
        this.userType = "Guest";
    }


    public string Email
    {
        get { return email; }
        set { this.email = value; }
    }
    
   
    public string UserPassword
    {
        get { return userPassword; }
        set { this.userPassword = value; }
    }

 
    public string UserFirstName
    {
        get { return fname; }
        set { this.fname = value; }
    }
 
    public DateTime BirthDate
    {
        set { this.birthDate = value; }
        get { return this.birthDate; }
    }
    
    public string UserType
    {
        set { this.userType = value; }
        get { return this.userType; }
    }
    
   
    // =========================================================================   
    public bool UserExist(string email, string userPassword)
    {
        string userSqlStr = "select  [email] from [userTbl] where [email]='" +
            email + "' and [password]='" + userPassword + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "projectDB.accdb");        
        if (dt.Rows.Count > 0)
            return true;        
        return false;
    }

    public string UserDetails(string email)
    {
        string userSqlStr = "select  [fname] from [userTbl] where [email]='" + email +  "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "projectDB.accdb");
        if (dt.Rows.Count > 0)
            return dt.Rows[0][0].ToString();
        return " ";

    }
    public DateTime UserBday(string email)
    {
        string userSqlStr = "select  [birthdate] from [userTbl] where [email]='" + email + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "projectDB.accdb");
        if (dt.Rows.Count > 0)
            return (DateTime)dt.Rows[0][0];
        return new DateTime();
    }

    public bool CheckAdmin(string email, string userPassword)
    {
        string userSqlStr = "select  * from [adminTbl] where [email]='" + email + "' and [password]='" + userPassword + "' and [type]='Admin' ";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "projectDB.accdb");        
         
        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
  
    public bool UserExistSignUp()
    {
        string userSqlStr = "select  [email] from [userTbl] where [email]='" + this.email + "'";
        DataTable dt = DBFunctions.SelectFromTable(userSqlStr, "projectDB.accdb");
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }

    public void UpdatePassword(string newPassword)
    {

        string userSqlStr = "Update [userTbl] Set [password]='" + newPassword + "' where [email]='" + this.email + "'";
        DBFunctions.ChangeTable(userSqlStr, "projectDB.accdb");
                

    }
 
    public void DeleteUser()
    {
        string userSqlStr = "Delete  from [userTbl] where [email]='" + this.email + "'";        
            DBFunctions.ChangeTable(userSqlStr, "projectDB.accdb");            
            
    }

    public bool InsertNewUser()
    {
        if (this.UserExistSignUp() == true)
            return false;//can not insert him
        string sqlstr = "INSERT INTO [userTbl] ([email], [password], [fname],[birthdate],[type]) ";
        sqlstr +="values ('"+this.Email+"','" + this.UserPassword + "','"+ this.UserFirstName+"','"+this.BirthDate+"','"+this.userType+"')";
        DBFunctions.ChangeTable(sqlstr, "projectDB.accdb");
        return true;
    }
    public void UpdateFname(string newFname)
    {

        string userSqlStr = "Update [userTbl] Set [fname]='" + newFname + "'";
        DBFunctions.ChangeTable(userSqlStr, "projectDB.accdb");


    }
    public void Insertmessage(string message,DateTime date)
    {
        string sqlstr = "INSERT INTO [messagesTbl] ([email],[fname],[message],[time])";//time when this message was sent
        sqlstr += "values ('" + this.Email + "','" + this.UserFirstName + "','" + message + "','" + date + "')";
        DBFunctions.ChangeTable(sqlstr, "projectDB.accdb");
    }


   

}