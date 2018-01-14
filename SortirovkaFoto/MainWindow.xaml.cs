using SortirovkaFoto.ViewModel;
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

namespace SortirovkaFoto
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

        private void NotifyDone()
        {
            DialogResult = ((SelectFolderViewModel)DataContext).SelectedCredential != null;
        }
        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NotifyDone();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NotifyDone();
        }
    }
}
