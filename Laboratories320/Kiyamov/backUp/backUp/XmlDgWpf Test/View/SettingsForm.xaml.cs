using System.Windows;

namespace XmlDgWPF.ViewModel
{
    public partial class SettingsForm : Window
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.DataContext = new SettingsVM();
        }

    }

}
