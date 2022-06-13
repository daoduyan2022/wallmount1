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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WallMount1.MainController;
using WallMount1.UI;

namespace WallMount1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainController.MainController mainController = null;
        public List<string> _ListModel = new List<string>();//List cac model da duoc setup
        public MainWindow()
        {
            InitializeComponent();
            mainController = new MainController.MainController();
        }

        private void btn_open_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void SetupModel_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.ShowDialog();
            if (loginWindow.resultOfLogin == ResultOfLogin.Pass)
            {
                Setup_Model setupModelWindow = new Setup_Model(this);
                setupModelWindow.ShowDialog();
            }
        }

        private void HardwareConfig_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.ShowDialog();
            if (loginWindow.resultOfLogin == ResultOfLogin.Pass)
            {
                Hardware_Config hardwareWindow = new Hardware_Config();
                hardwareWindow.ShowDialog();
            }

        }
    }
}
