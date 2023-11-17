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
        List<Student> students = new List<Student>();
        List<object> anonymous = new List<object>();

        public MainWindow()
        {
            InitializeComponent();

            students.Add(new Student("Will"));

            var randoObject = new
            {
                Name="Will"
            };

            object rainaObject = new
            {
                Name = "Raina"
            };

            anonymous.Add(randoObject);
            anonymous.Add(rainaObject);

            lvStudents.ItemsSource = anonymous;
        }

    } // class

    public class Student
    {
        string _name;
        string _studentId;
        static Random rand = new Random();

        public string Name { get => _name; set => _name = value; }
        public string StudentId { get => _studentId; set => _studentId = value; }

        public Student(string name)
        {
            _name = name;
            _studentId = rand.Next(100000000,1000000000).ToString();
        }
    }


} // namespace
