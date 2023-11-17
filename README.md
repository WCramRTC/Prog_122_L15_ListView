# Prog_122_L15_ListView


Basics:

Basic Setup in XAML
```
<ListView>
    <ListView.View>
        <GridView>
            <GridViewColumn Header="Header Name" DisplayMemberBinding="{Binding Class Property }"/>
        </GridView>
    </ListView.View>
</ListView>
```

```xml
    <ListView
            x:Name="lvStudents">
            <ListView.View>
                <GridView>
                    <GridViewColumn Header="Name" DisplayMemberBinding="{Binding Name }"/>
                    <GridViewColumn
                        Header="Student ID"
                        DisplayMemberBinding="{Binding StudentId }" />
                </GridView>
            </ListView.View>
        </ListView>
```

In Code

Student class
```csharp
    public class Student
    {
        string _name;
        string _studentId;
        static Random rand = new Random();

        // Have properties
        public string Name { get => _name; set => _name = value; }
        public string StudentId { get => _studentId; set => _studentId = value; }

        public Student(string name)
        {
            _name = name;
            _studentId = rand.Next(100000000,1000000000).ToString();
        }
    }
```

MainWindow.cs

```csharp

        List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
            students.Add(new Student("Will"));
            lvStudents.ItemsSource = students; // <-- Add to Items source
        }
```





Using ListView in WPF
1. Add ListView to XAML
Add the ListView control to your XAML file within a window or a user control:

```xml
Copy code
<Window x:Class="YourNamespace.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="350" Width="525">
    <Grid>
        <ListView Name="listView">
            <!-- ListView columns and configurations go here -->
        </ListView>
    </Grid>
</Window>
```

2. Define Columns
Define columns in the ListView using GridView:

```xml
Copy code
<ListView Name="listView">
    <ListView.View>
        <GridView>
            <GridViewColumn Header="Name" DisplayMemberBinding="{Binding Name}" />
            <GridViewColumn Header="Age" DisplayMemberBinding="{Binding Age}" />
            <!-- More columns as needed -->
        </GridView>
    </ListView.View>
</ListView>
```

3. Data Binding
Bind the ListView to a collection of data:

```csharp
Copy code
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 }
            // Populate with more data
        };

        listView.ItemsSource = people;
    }
}
```


4. Event Handling (Optional)
Handle events such as item selection:

```csharp
Copy code
private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    // Event handling code here
}
```

Bind the event in XAML:

```xml
Copy code
<ListView Name="listView" SelectionChanged="listView_SelectionChanged">
    <!-- ... -->
</ListView>
```

---

Anonymous Class

```csharp

object variableName = new  {
    PropertyName1 = "word"
    PropertyName2 = 15
}

```