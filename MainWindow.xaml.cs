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

            Movie straightOuttaCompton = movies[0];
            CrewMember Lakeith = new CrewMember("LaKeith", "Stanfield", CrewMember.Role.Background);
            straightOuttaCompton.AddCastMember(Lakeith);

            Movie ironGiant = movies[1];
            CrewMember bird = new CrewMember("Brad", "Bird", CrewMember.Role.Crew);
            ironGiant.AddCastMember(bird);

            Movie fiveHeartBeats = movies[2];
            CrewMember townsend = new CrewMember("Robert", "Townsend", CrewMember.Role.Main);
            fiveHeartBeats.AddCastMember(townsend);

            // LaKeith Stanfield - Background
            // Brad Bird - Crew
            // Robert Townsend - Main Crew


            //lbDisplay.ItemsSource = movies;

            lvMovieInventory.ItemsSource = movies;
            

        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            movies.Add(new Movie("Eternal Sunshine of a Spotless Mind", "English", 2001, 176, "Micheal Gondry"));

            lvMovieInventory.Items.Refresh();
        }

        private void lvMovieInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int index = lvMovieInventory.SelectedIndex;
            Movie movie = movies[index];
            CrewMember firstMemeber = movie.Cast[0];

            lvCrew.ItemsSource = movie.Cast;

            //MessageBox.Show(firstMemeber.FName);
        }
    } // class

    public class Movie
    {
        string _name; 
        string _captions;
        int _year;
        int _duration;
        string _director;
        List<CrewMember> _cast;

        //List<> _cast;

        public Movie(string name, string captions, int year, int duration, string director)
        {
            _name = name;
            _captions = captions;
            _year = year;
            _duration = duration;
            _director = director;
            _cast = new List<CrewMember>();
        }

        public string Name { get => _name; set => _name = value; }
        public string Captions { get => _captions; set => _captions = value; }
        public int Year { get => _year; set => _year = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public string Director { get => _director; set => _director = value; }
        public List<CrewMember> Cast { get => _cast; set => _cast = value; }

        // cast

        public void AddCastMember(string fname, string lname, CrewMember.Role role)
        {
            _cast.Add(new CrewMember(fname, lname, role));
        }

        public void AddCastMember(CrewMember crewMember)
        {
            _cast.Add(crewMember);
        }

        public override string ToString()
        {
            return $"Name {Name} - Year {Year} - Director: {Director}";
        }

    }

    public class CrewMember
    {
        // enum
        public enum Role { Main, Background, Crew, Uncredited }

        string _fName;
        string _lName;     
        Role _role;

        public string FName { get => _fName; set => _fName = value; }
        public string LName { get => _lName; set => _lName = value; }
        public Role Role1 { get => _role; set => _role = value; }

        public CrewMember(string fName, string lName, Role role)
        {
            _fName = fName;
            _lName = lName;
            _role = role;
        }
    }

} // namespace
