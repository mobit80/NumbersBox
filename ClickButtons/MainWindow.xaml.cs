using System.Numerics;
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

namespace ClickButtons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double total; 

        public double updateTotal(double amount)
        {
            total = total + amount;
            return total;
        }

        public MainWindow()
        {
            total = 0;
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double callValue = Convert.ToInt32((sender as Button).Uid);
            
            updateTotal(callValue);      

            if (total.ToString().Length > 22 ) {
                total = total - callValue;
            }
            else {
                mainText.Content = total.ToString("N0");
            }
            
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            total = 0;
            mainText.Content = total.ToString();
        }
    }
}