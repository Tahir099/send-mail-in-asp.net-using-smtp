using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
namespace project1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string Mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            getDropdown();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // tahir = DropDownList1.SelectedItem.Text;
       }
      
        protected void getDropdown()
        {
            SqlConnection sqlconn = new SqlConnection(Mainconn);
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlcomm.CommandText = "select_topic";
            sqlconn.Open();
            DropDownList1.DataSource = sqlcomm.ExecuteReader();
            DropDownList1.DataTextField = "topic_name";
            DropDownList1.DataValueField = "topic_id";
            DropDownList1.DataBind();
            sqlconn.Close();
            DropDownList1.Items.Insert(0, new ListItem("--Select Topic--"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage("sixlarovtahir13@gmail.com" , TextBox3.Text);
            message.Subject = DropDownList1.SelectedItem.Text; //DropDownList1.SelectedItem.Text.ToString();
            message.Body = TextBox4.Text;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com" , 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "sixlarovtahir13@gmail.com",
                Password = "iunbonstvvlpemur"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(message);
        }
    }
}