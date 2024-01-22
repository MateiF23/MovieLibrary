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
    public partial class FP : Form
    {
        private SqlConnection _con;
        private SqlDataReader _read;
        public FP()
        {
            InitializeComponent();
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();
        }
        private void FP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from users where KEYS = '" + textBox1.Text + "'", _con);
            _read = cmd.ExecuteReader();
            if (_read.Read())
            {
                string pas = _read["PASSWORD"].ToString();
                MessageBox.Show(pas);
                _read.Close();
            }
        }
    }
}
