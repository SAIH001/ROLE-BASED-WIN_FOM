using System.Data.SqlClient;

namespace Aptech
{
    public partial class Form1 : Form
    {
        SqlConnection connectionDb = new SqlConnection("Data Source=.;Initial Catalog=aptech;User ID=sa;Password=aptech");
        public Form1()
        {
            InitializeComponent();

            try
            {
                connectionDb.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            String User_Name = employeename.Text;
            String User_Email = employeeemail.Text;
            String User_Password = employeepassword.Text;


            String InsertQuery = "insert into userRegistration values ('" + User_Name + "','" + User_Email + "','" + User_Password + "','customer')";


            SqlCommand dlvryBoy = new SqlCommand(InsertQuery, connectionDb);

            dlvryBoy.ExecuteNonQuery();

            MessageBox.Show("Data Inserted Successfully !!");

            employeeemail.Text = "";
            employeename.Text = "";
            employeepassword.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginScreen = new Login();
            loginScreen.Show();
            
            this.Hide();
        }
    }
}