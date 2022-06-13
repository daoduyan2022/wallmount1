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
using WallMount1.UI;
namespace WallMount1.UI
{
    /// <summary>
    /// Interaction logic for Setup_Model.xaml
    /// </summary>
    public partial class Setup_Model : Window
    {
        MainWindow mainWindow = null;
        public Setup_Model(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NewModel newModelWindow = new NewModel(mainWindow);
            newModelWindow.ShowDialog();
            foreach(string model in mainWindow._ListModel)
            {
                cbx_SelectModel.Items.Add(model);
            }


        }

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectStream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_subStream_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_addStream_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectStep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_addStep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_subStep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_getImage_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btn_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectIndexRoi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_download_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_CamDevice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Port_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbx_SelectModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
