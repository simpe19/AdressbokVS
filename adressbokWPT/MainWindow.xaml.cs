using adressbokWPT.Interfaces;
using adressbokWPT.Models;
using adressbokWPT.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace adressbokWPT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  ObservableCollection<Person> persons = new();
        private readonly FileService file = new();

        public MainWindow()
        {
            InitializeComponent();
            file.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
            PopulatePersonsList();
        }

        private void PopulatePersonsList()
        {
            
            try
            {
                var items = JsonConvert.DeserializeObject<ObservableCollection<Person>>(file.Read());
                if (items != null)
                    persons = items;
            }
            catch { } 

            lv_Persons.ItemsSource = persons;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            persons.Add(new Person
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                Number = tb_Phone.Text,
                Adress = tb_Adress.Text
            });
            file.Save(JsonConvert.SerializeObject(persons));
            ClearForm();
        }
        private void ClearForm()
        {
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
            tb_Email.Text = "";
            tb_Phone.Text = "";
            tb_Adress.Text = "";
            
        }
    }
}
