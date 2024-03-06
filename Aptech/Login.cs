using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptech
{
    public partial class Login : Form
    {
        SqlConnection connectionDb = new SqlConnection("Data Source=.;Initial Catalog=aptech;User ID=sa;Password=aptech");

        public Login()
        {
            InitializeComponent();

            try
            {
                connectionDb.Open();


            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String User_Login_Email = LoginEmail.Text;
            String User_Login_Password = Loginpassword.Text;

            String UserFind = "select * from userRegistration where useremail = '"+ User_Login_Email + "' and userpassword = '"+ User_Login_Password + "'";


            SqlCommand userAvailble = new SqlCommand(UserFind, connectionDb);

            SqlDataReader DataReaded = userAvailble.ExecuteReader();

            DataReaded.Read();

            String usernameee = DataReaded["username"].ToString();
            String useremailll = DataReaded["useremail"].ToString();
            String userRole = DataReaded["userrole"].ToString();


            if(userRole == "customer")
            {
                CustomerPanel customer = new CustomerPanel();
                customer.Show();
                this.Close();

            }else if(userRole == "admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Crediential Wrong!!");
            }


        }
    }
}
