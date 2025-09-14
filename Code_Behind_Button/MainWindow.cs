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

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        bool running = true;
        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                tbHello.Text = "Stopped";
                btnRun.Content = "Start";
            }
            else
            {
                tbHello.Text = "Started";
                btnRun.Content = "Stop";
            }
            running = !running ;
        }
    }
}