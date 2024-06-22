using System.Windows;
using System.Windows.Controls;

namespace LabWork31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            datePicker.DisplayDateStart = new DateTime(1900, 1, 1);
            datePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(LoginTextBox.Text) && !String.IsNullOrEmpty(PasswordTextBox.Password) &&
                 PasswordTextBox.Password == ConfirmPasswordBox.Password)
            {
                MessageBox.Show(LoginTextBox.Text + ", вы зарегистрированы.");
            }
            else 
            {
                MessageBox.Show("Введены не все данные или пароли не совпадают.");
            }

        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime birthDate = datePicker.SelectedDate ?? DateTime.Now;

            TimeSpan age = DateTime.Now - birthDate;
            int years = (int)(age.Days / 365.25);

            ageLabel.Text = $"Age: {years} years";
        }
    }
}