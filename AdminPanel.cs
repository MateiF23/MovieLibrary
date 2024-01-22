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
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace MovieLibrary
{
    public partial class AdminPanel : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        int id = UserSession.CurrentID;
        public AdminPanel()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.movieTableAdapter1.Fill(this.dataBaseDataSet1.Movie);
        }
        private void Refresh()
        {
            this.movieTableAdapter1.Fill(this.dataBaseDataSet1.Movie);
            movieDataGridView.DataSource = this.dataBaseDataSet1.Movie;
        }
        public void OpenForm(Movie movie)
        {
            MovieForm form = new MovieForm();
            form.DisplayMovie(movie);
            form.DisplayImage(id);
            form.Show();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                byte[] fileData = null;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                fileData = br.ReadBytes((int)fs.Length);
                cmd = new SqlCommand("insert into Movie(TITLU,DESCRIERE,GEN,REGIZOR,ACTORI,DURATA,LANSARE,PHOTO) values(@titlu,@descriere,@gen,@regizor,@actori,@durata,@lansare,@photo)", conn);
                cmd.Parameters.AddWithValue("@titlu", TitleBox.Text);
                cmd.Parameters.AddWithValue("@descriere", DescBox.Text);
                cmd.Parameters.AddWithValue("gen", TypeBox.Text);
                cmd.Parameters.AddWithValue("@regizor", DirBox.Text);
                cmd.Parameters.AddWithValue("@actori", MainBox.Text);
                cmd.Parameters.AddWithValue("@durata", TimeBox.Text);
                cmd.Parameters.AddWithValue("@lansare", DateBox.Text);
                cmd.Parameters.Add("@photo", SqlDbType.Binary, fileData.Length).Value = fileData;
                string title = TitleBox.Text;
                string description = DescBox.Text;
                string genre = TypeBox.Text;
                string director = DirBox.Text;
                string mainActor = MainBox.Text;
                string runtime = TimeBox.Text;
                string releaseDate = DateBox.Text;
                TitleBox.Text = "";
                DescBox.Text = "";
                TypeBox.Text = "";
                DirBox.Text = "";
                MainBox.Text = "";
                TimeBox.Text = "";
                DateBox.Text = "";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("YOU SUCCESFULLY ADDED A MOVIE!","DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Movie newMovie = new Movie(title, description, genre, director,mainActor,runtime,releaseDate);
                OpenForm(newMovie);
            }
            else
            {
                MessageBox.Show("A PHOTO HAS NOT BEEN SELECTED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }
    }
}
