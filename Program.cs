using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary
{
    public static class UserSession
    {
        public static int CurrentID { get; set; }
    }
    public class Movie
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public string Gen { get; set; }
        public string Regizor { get; set; }
        public string Actori { get; set; }
        public string Durata { get; set; }
        public string Lansare { get; set; }

        public Movie(string title, string description, string type, string director,string actor,string runtime, string releaseDate)
        {
            Titlu = title;
            Descriere = description;
            Gen = type;
            Regizor = director;
            Actori = actor;
            Durata = runtime;
            Lansare = releaseDate;
        }
    }
    public class MovieImageData
    {
        public int MovieId { get; set; }
        public byte[] ImageBytes { get; set; }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
