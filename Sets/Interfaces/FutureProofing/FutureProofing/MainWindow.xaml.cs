using System;
using System.Windows;
using PersonLibrary;


namespace FutureProofing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PeopleRepository peopleRepo = new PeopleRepository();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            Person[] people;
            people = peopleRepo.GetPeople();

            foreach (var person in people)
                PersonList.Items.Add(person);
        }

        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonList.Items.Clear();
        }
    }
}
