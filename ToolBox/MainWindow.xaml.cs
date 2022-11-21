using System.Windows;
using ToolBox.Utils;
using ToolBox.Windows;

namespace ToolBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        public void onClickInsertProjectSettingBtn(object sender, RoutedEventArgs e)
        {
            CustomFunctions.InsertSettingValuesForRensaRevitApiProject();
        }
        
        public void onClickCreateBranchBtn(object sender, RoutedEventArgs e)
        {
            var window = new BranchCreateWindow();
            window.ShowDialog();
        }
    }
}
