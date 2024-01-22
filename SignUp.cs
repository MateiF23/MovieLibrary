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

namespace MovieLibrary
{
    public partial class SignUp : Form
    {
        private SqlConnection con;
        private SqlDataReader read;
        public SignUp()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(UserBox.Text != string.Empty && PassBox.Text != string.Empty && GmailBox.Text!=string.Empty)
            {
                SqlCommand cmd = new SqlCommand("Select * from users where USERNAME ='" + UserBox.Text + "'", con);
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    MessageBox.Show("This username already exist! Please try again with another credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    read.Close();
                    Guid newKey = Guid.NewGuid();
                    cmd = new SqlCommand("insert into users(USERNAME,PASSWORD,GMAIL,GENDER,KEYS) values(@user,@pass,@gmail,@gender,@key)", con);
                    cmd.Parameters.AddWithValue("@user", UserBox.Text);
                    cmd.Parameters.AddWithValue("@pass",PassBox.Text);
                    cmd.Parameters.AddWithValue("@gmail",GmailBox.Text);
                    cmd.Parameters.AddWithValue("@key", newKey);
                    for(int i=0; i<GenderList.Items.Count; i++)
                        if(GenderList.GetItemChecked(i))
                        {
                            cmd.Parameters.AddWithValue("gender", i.ToString());
                            break;
                        }
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Your Account is created. Please login now. Your key is: " + newKey.ToString(), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GenderList.SelectedIndex;
            if (index == -1)
                return;
            for (int iIndex = 0; iIndex < GenderList.Items.Count; iIndex++)
                GenderList.SetItemCheckState(iIndex, CheckState.Unchecked);
            GenderList.SetItemCheckState(index, CheckState.Checked);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
