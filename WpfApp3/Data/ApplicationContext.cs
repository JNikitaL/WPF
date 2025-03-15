using System.Collections.ObjectModel;  // Добавьте пространство имен для ObservableCollection
using WpfApp3.Models;

namespace WpfApp3.Data
{
    public static class ApplicationContext
    {
        // Используем ObservableCollection для автоматического обновления UI
        public static ObservableCollection<RepairRequest> Applications { get; set; } = new ObservableCollection<RepairRequest>();

        static ApplicationContext()
        {
            // Добавляем начальные данные в список заявок
            Applications.Add(new RepairRequest
            {
                ClientName = "Иванов Иван",
                PhoneNumber = "89001234567",
                DeviceType = "Телевизор",
                ProblemDescription = "Не включается"
            });
            Applications.Add(new RepairRequest
            {
                ClientName = "Петров Петр",
                PhoneNumber = "89002345678",
                DeviceType = "Холодильник",
                ProblemDescription = "Не охлаждает"
            });
            Applications.Add(new RepairRequest
            {
                ClientName = "Сидоров Сидор",
                PhoneNumber = "89003456789",
                DeviceType = "Стиральная машина",
                ProblemDescription = "Течет вода"
            });
        }
    }
}
