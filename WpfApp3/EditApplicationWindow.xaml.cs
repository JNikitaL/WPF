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
using System.Windows.Shapes;
using WpfApp3.Models;

namespace WpfApp3
{
    public partial class EditApplicationWindow : Window
    {
        private RepairRequest _selectedRequest;

        public EditApplicationWindow(RepairRequest selectedRequest)
        {
            InitializeComponent();
            _selectedRequest = selectedRequest;

            // Заполняем поля данными выбранной заявки
            ClientNameTextBox.Text = _selectedRequest.ClientName;
            PhoneNumberTextBox.Text = _selectedRequest.PhoneNumber;
            DeviceTypeTextBox.Text = _selectedRequest.DeviceType;
            ProblemDescriptionTextBox.Text = _selectedRequest.ProblemDescription;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Обновляем данные выбранной заявки
            _selectedRequest.ClientName = ClientNameTextBox.Text;
            _selectedRequest.PhoneNumber = PhoneNumberTextBox.Text;
            _selectedRequest.DeviceType = DeviceTypeTextBox.Text;
            _selectedRequest.ProblemDescription = ProblemDescriptionTextBox.Text;

            // Закрываем окно
            this.Close();
        }
    }
}