using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SortirovkaFoto.ViewModel
{
    public class SelectFolderViewModel:BaseViewModel
    {
        public SelectFolderViewModel()
        {
//            Credentials = new ObservableCollection<Auskey>();
//            var elsTestConfig = new ElsTestConfig(Application.ExecutablePath);
//            KeystorePath = elsTestConfig.KeyStorePath;
        }

        private string _selectedFolder;

        public string SelectedCredential
        {
            get { return _selectedFolder; }
            set
            {
                _selectedFolder = value;
                OnPropertyChanged("SelectedFolder");
            }
        }
        private string _keystorePath;

        public string KeystorePath
        {
            get
            {
                return string.IsNullOrEmpty(_keystorePath) ? null : Path.GetFileName(_keystorePath);
            }
            set
            {
                _keystorePath = value;
                OnPropertyChanged("KeystorePath");
                if (!File.Exists(_keystorePath)) return;
                //selectedcredential = null;
                //credentials.clear();
                //foreach (var credential in new keystorereader().getcredentialsfromkeystore(_keystorepath))
                //{
                //    credentials.add(credential);
                //}
            }
        }

        private void BrowseFolderStore(object parameter)
        {
            var dlg = new OpenFileDialog
            {
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".jpeg",
                Filter = "ABR Keystore Files (*.jpg)|*.jpeg",
                Multiselect = false,
                Title = "Select keystore to open"
            };
            if (dlg.ShowDialog() == true)
            {
                KeystorePath = dlg.FileName;
            }
        }

        public ICommand CommandBrowseFolderStore
        {
            get { return new SimpleActionCommand(BrowseFolderStore); }
        }

    }
}
