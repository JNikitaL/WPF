using System.Windows;
using WpfApp3.Models;
using WpfApp3.Data;

namespace WpfApp3
{
    public partial class AddApplicationWindow : Window
    {
        public delegate void ApplicationAddedEventHandler();
        public event ApplicationAddedEventHandler ApplicationAdded;

        public AddApplicationWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(ClientNameTextBox.Text) ||
            //    string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) ||
            //    string.IsNullOrWhiteSpace(DeviceTypeTextBox.Text) ||
            //    string.IsNullOrWhiteSpace(ProblemDescriptionTextBox.Text))
            //{
            //    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            RepairRequest newRequest = new RepairRequest
            {
                ClientName = ClientNameTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                DeviceType = DeviceTypeTextBox.Text,
                ProblemDescription = ProblemDescriptionTextBox.Text
            };

            ApplicationContext.Applications.Add(newRequest);

            ApplicationAdded?.Invoke();

            this.Close();
        }
    }
}
