using System;
using System.Windows;

namespace ToolBox.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BranchCreateWindow : Window
    {
        public BranchCreateWindow()
        {
            InitializeComponent();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        public void onClickSubmitBtn(object sender, RoutedEventArgs e)
        {
            int storyNumber = 0;
            if(int.TryParse(storyNumberInput.Text, out int number))
            {
                storyNumber = number;
            }
            else
            {
                MessageBox.Show("Story number should be in int!");
            }

            var storyName = string.Join('-', storyNameInput.Text.Split(' '));

            if((isFeature.IsChecked ?? true) && (isBugfix.IsChecked ?? true))
            {
                MessageBox.Show("Choose one - either Feature or Bugfix!");
            }
            else if(isFeature.IsChecked??false)
            {
                message.Text = CreateFeatureBranch(storyNumber, storyName);
            }
            else if(isBugfix.IsChecked ?? false)
            {
                message.Text = CreateBugFixBranch(storyNumber, storyName);
            }
            else
            {
                MessageBox.Show("Complete the form correctly!");
            }
        }

        private string CreateFeatureBranch(int num, string name)
        {
            var branchName = "feature/" + num + '-' + name;
            TextCopy.ClipboardService.SetText(branchName);
            return branchName + Environment.NewLine + "(Copied in the clipboard!)";
        }
        
        private string CreateBugFixBranch(int num, string name)
        {
            var branchName = "bugfix/" + num + '-' + name;
            TextCopy.ClipboardService.SetText(branchName);
            return branchName + Environment.NewLine + "(Copied in the clipboard!)";
        }
    }
}
