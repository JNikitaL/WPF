using System.Windows;
using WpfApp3.Models;
using WpfApp3.Data;

namespace WpfApp3
{
    public partial class AddApplicationWindow : Window
    {
        // Делаем событие для уведомления MainWindow
        public delegate void ApplicationAddedEventHandler();
        public event ApplicationAddedEventHandler ApplicationAdded;

        public AddApplicationWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Валидация данных
            //if (string.IsNullOrWhiteSpace(ClientNameTextBox.Text) ||
            //    string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) ||
            //    string.IsNullOrWhiteSpace(DeviceTypeTextBox.Text) ||
            //    string.IsNullOrWhiteSpace(ProblemDescriptionTextBox.Text))
            //{
            //    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            // Создаем новую заявку
            RepairRequest newRequest = new RepairRequest
            {
                ClientName = ClientNameTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                DeviceType = DeviceTypeTextBox.Text,
                ProblemDescription = ProblemDescriptionTextBox.Text
            };

            // Добавляем заявку в список
            ApplicationContext.Applications.Add(newRequest);

            // Вызываем событие, сообщающее о добавлении новой заявки
            ApplicationAdded?.Invoke();

            // Закрываем окно
            this.Close();
        }
    }
}
