using System.Windows;
using WpfApp3.Data;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadApplications();  // Загружаем заявки при старте
        }

        private void LoadApplications()
        {
            // Теперь обновление данных происходит автоматически через ObservableCollection
            ApplicationsListView.ItemsSource = ApplicationContext.Applications;
        }

        private void AddApplication_Click(object sender, RoutedEventArgs e)
        {
            // Открываем окно для добавления заявки
            AddApplicationWindow addWindow = new AddApplicationWindow();
            addWindow.ShowDialog();  // После закрытия окна автоматически обновится список
        }
    }
}
