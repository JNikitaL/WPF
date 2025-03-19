using System.Windows;
using WpfApp3.Data;
using WpfApp3.Models;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            ApplicationsListView.ItemsSource = ApplicationContext.Applications;
        }

        private void AddApplication_Click(object sender, RoutedEventArgs e)
        {
            AddApplicationWindow addWindow = new AddApplicationWindow();
            addWindow.ShowDialog();
        }

        private void EditApplication_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранную заявку
            var selectedRequest = ApplicationsListView.SelectedItem as RepairRequest;

            if (selectedRequest != null)
            {
                // Открываем окно редактирования
                EditApplicationWindow editWindow = new EditApplicationWindow(selectedRequest);
                editWindow.ShowDialog();

                // Обновляем список заявок
                ApplicationsListView.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Выберите заявку для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}