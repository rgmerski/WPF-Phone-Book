using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Phone_Book.Data;

namespace WPF_Phone_Book
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Contact> AllContacts { get; set; }

        public MainWindow()
        {
            DataContext = this;

            InitializeComponent();

            //using (var db = new Context())
            //{
            //    // TODO - SQLite error 14 - don't know why is it showing when I'm doing everything like in Microsoft Docs... 
            //    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio, https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs,
            //    // https://docs.microsoft.com/en-us/ef/core/
            //    List<Contact> contacts = new();
            //    contacts = db.Contacts.ToList();

            //    AllContacts = new ObservableCollection<Contact>(contacts);

            //}


            //if (AllContacts.Count == 0)
            //{

            //    var contact = new Contact
            //    {
            //        Name = "Kontakt testowy",
            //        Address = "Wroclaw, ul. Uliczna",
            //        Email = "google@gmail.com",
            //        Number = "600000000",
            //        Other = "Dodatkowe informacje",
            //        UserID = 1
            //    };
            //    var contact2 = new Contact
            //    {
            //        Name = "Kontakt testowy 2",
            //        Address = "Wroclaw, ul. Miejska",
            //        Email = "google2@gmail.com",
            //        Number = "600000001",
            //        Other = "Dodatkowe informacje",
            //        UserID = 1
            //    };
            //    AllContacts.Add(contact);
            //    AllContacts.Add(contact2);

            //    using (var db = new Context())
            //    {
            //        db.Contacts.Add(contact);
            //        db.Contacts.Add(contact2);
            //    }
            //}

            AllContacts=new ObservableCollection<Contact>
            {
                new Contact("Kontakt testowy", "Wroclaw, ul. Uliczna", "600000000", new Uri("mailto:google@gmail.com"), "Dodatkowe informacje"),
                new Contact("Kontakt testowy 2", "Wroclaw, ul. Miejska", "610000000", new Uri("mailto:google2@gmail.com"), "Dodatkowe informacje"),
            };
            data_grid.ItemsSource = AllContacts;

        }

        // PROFILE (USER)
        private void LoadP_BTN_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteP_BTN_Click(object sender, RoutedEventArgs e)
        {
        }

        private void SaveP_BTN_Click(object sender, RoutedEventArgs e)
        {
        }

        // CONTACT
        private void Save_BTN_Click(object sender, RoutedEventArgs e)
        {
            string mail = "mailto:";
            mail += Email_TXT.Text;
            AllContacts.Add(new Contact(Name_TXT.Text, Address_TXT.Text, Telephone_TXT.Text, new Uri(mail), Other_TXT.Text));
        }

        private void Delete_BTN_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = data_grid.SelectedItem as Contact;
            if (contact != null) AllContacts.Remove(contact);
        }

        private void Clear_BTN_Click(object sender, RoutedEventArgs e)
        {
            AllContacts.Clear();
        }

        private void Search_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
            }
        }

        private void data_grid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();
            if (headername == "Id" || headername == "UserID") e.Cancel = true;
        }
    }
}