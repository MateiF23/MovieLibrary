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
using System.IO;
using System.Drawing.Imaging;

namespace MovieLibrary
{
    public partial class Main : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        int id = UserSession.CurrentID; 
        List<MovieImageData> imageList = new List<MovieImageData>();
        public Main()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer_Tick);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadImagesFromDatabase();
            if (imageList.Count > 0)
            {
                timer1.Start();
            }
        }
        public Image ResizeImage(Image image, int w, int h)
        {
            var destRect = new Rectangle(0, 0, w, h);
            var destImage = new Bitmap(w, h);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            var graphics = Graphics.FromImage(destImage);
            graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            var wrapMode = new ImageAttributes();
            wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
            graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            return destImage;
        }

        private int currentImageIndex = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (imageList.Count == 0)
                return;

            MovieImageData currentMovieImage = imageList[currentImageIndex];
            byte[] imageBytes = currentMovieImage.ImageBytes;
            int currentMovieId = currentMovieImage.MovieId;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image Resize = ResizeImage(Image.FromStream(ms), pictureBox2.Width, pictureBox2.Height);
                pictureBox2.Image = Resize;
            }

            currentImageIndex++;
            if (currentImageIndex >= imageList.Count)
            {
                currentImageIndex = 0;
            }
        }

        private void LoadImagesFromDatabase()
        {
            string query = "SELECT ID, PHOTO FROM Movie";
            SqlCommand sqlCommand  = new SqlCommand(query, cn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                byte[] imageBytes = (byte[])reader["PHOTO"];
                imageList.Add(new MovieImageData { MovieId = 1, ImageBytes = imageBytes });
            }
            reader.Close();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT ADMIN FROM users WHERE Id = @id", cn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader reader1 = cmd.ExecuteReader();
            int admin = 0;
            if (reader1.Read())
            {
                admin = Convert.ToInt32(reader1["ADMIN"]);
                reader1.Close();
            }
            if (admin == 1)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.FormClosed += AdminPanel_FormClosed;
                this.Hide();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("FORBIDDEN! YOU ARE NOT AN ADMIN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
