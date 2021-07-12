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
using WpfSuperDemo.ViewModels;

namespace WpfSuperDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel();
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Joe", LastName = "Smith" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
            myComboBox.ItemsSource = people;
            ComboBox cbx = new ComboBox();
            cbx.Name = "ComboBox1";
            cbx.Width = 400;
            cbx.Height = 30;
            cbx.HorizontalAlignment = HorizontalAlignment.Center;
            ComboBoxItem item = new ComboBoxItem();
            item.Content = "Coffie";
            cbx.Items.Add(item);
            cbx.Items.Add("Tea");
            cbx.Items.Add("Orange");
            cbx.Items.Add("Milk");
            cbx.Items.Add("Iced Tea");
            cbx.Items.Add("Mango Shake");
            RootLayout.Children.Add(cbx);
        }

        private void sumbitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameText.Text}");
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
