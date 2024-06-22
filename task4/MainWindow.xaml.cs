using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PriceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            summa.Content =  $"Сумма: {Math.Round(PriceSlider.Value,2)}";
            result.Content = $"Результат: {Math.Round((PriceSlider.Value*ProcentSlider.Value/100),2)}";
        }

        private void ProcentSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            percent.Content = $"Процент: {Math.Round(ProcentSlider.Value,2)}";
            result.Content = $"Результат: {Math.Round((PriceSlider.Value * ProcentSlider.Value / 100), 2)}";
        }
    }
}