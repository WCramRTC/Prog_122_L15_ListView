using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122_L15_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Movie> movies;

        public MainWindow()
        {
            InitializeComponent();



            movies = new List<Movie>
        {
            new Movie("Straight Outta Compton", "English", 2015, 147, "F. Gary Gray"),
            new Movie("Iron Giant", "English", 1999, 86, "Brad Bird"),
            new Movie("The Five Heartbeats", "English", 1991, 121, "Robert Townsend")
        };

            //lbDisplay.ItemsSource = movies;

            lvMovieInventory.ItemsSource = movies;
            

        }

    } // class

    public class Movie
    {
        string _name; 
        string _captions;
        int _year;
        int _duration;
        string _director;

        public Movie(string name, string captions, int year, int duration, string director)
        {
            _name = name;
            _captions = captions;
            _year = year;
            _duration = duration;
            _director = director;
        }

        public string Name { get => _name; set => _name = value; }
        public string Captions { get => _captions; set => _captions = value; }
        public int Year { get => _year; set => _year = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public string Director { get => _director; set => _director = value; }
        // cast

        public override string ToString()
        {
            return $"Name {Name} - Year {Year} - Director: {Director}";
        }

    }

} // namespace
