using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Windows.Media.Media3D;
using System.Drawing.Imaging;

namespace MovieLibrary
{
    public partial class MovieForm : Form
    {
        private SqlConnection conn;
        int id = UserSession.CurrentID;
        public MovieForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
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
        public void DisplayImage(int movieID)
        {
            string sqlQuery = "SELECT PHOTO FROM Movie WHERE ID = @movieID";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.Add("@movieID",SqlDbType.Int).Value=movieID;
            object imageObj = cmd.ExecuteScalar();
            if(imageObj != null  && imageObj!=DBNull.Value)
            {
                byte[] imageData = (byte[])imageObj;
                MemoryStream ms = new MemoryStream(imageData);
                Image image = Image.FromStream(ms);
                Image Resize = ResizeImage(image,pictureBox1.Width,pictureBox1.Height);
                pictureBox1.Image = Resize;
            }
        }
        public void DisplayMovie(Movie movie)
        {
            label1.Text = movie.Titlu;
            label7.Text = movie.Descriere;
            label2.Text = movie.Gen;
            label3.Text = movie.Regizor;
            label4.Text = movie.Actori;
            label5.Text = movie.Durata;
            label6.Text = movie.Lansare;
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

    }
}
