using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieLibrary
{
    public partial class AuthForm : Form
    {
        private SqlConnection conn;
        private SqlDataReader readd;
        public AuthForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }
        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(user.Text != string.Empty && pass.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from users where USERNAME ='" + user.Text + "' and PASSWORD = '" + pass.Text + "'",conn);
                readd = cmd.ExecuteReader();
                if(readd.Read())
                {
                    int userID = Convert.ToInt32(readd["Id"]);
                    UserSession.CurrentID = userID;
                    readd.Close();
                    this.Hide();
                    Main form = new Main();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Account avilable with this username and password","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    readd.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ForgetButton_Click(object sender, EventArgs e)
        {
            FP pass = new FP();
            pass.ShowDialog();
        }
    }
}
