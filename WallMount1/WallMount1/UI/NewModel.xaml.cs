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

namespace WallMount1.UI
{
    /// <summary>
    /// Interaction logic for NewModel.xaml
    /// </summary>
    public partial class NewModel : Window
    {
        MainWindow mainWindow = null;
        public NewModel(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void btn_AddNewModel_Click(object sender, RoutedEventArgs e)
        {
            mainWindow._ListModel.Add(tbx_ModelName.Text);

        }
    }
}
