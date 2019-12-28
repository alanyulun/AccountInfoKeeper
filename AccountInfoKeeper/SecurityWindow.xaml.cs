using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccountInfoKeeper
{
    /// <summary>
    /// SecurityWindow.xaml 的互動邏輯
    /// </summary>
    public partial class SecurityWindow : Window
    {
        public enum WindowsResult
        {
            OK,
            Cancel
        };

        private WindowsResult windowsResult = WindowsResult.OK;
        private string password = "";

        public SecurityWindow()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, RoutedEventArgs e)
        {
            password = txt_Password.Text;
            windowsResult = WindowsResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            password = string.Empty;
            windowsResult = WindowsResult.Cancel;
            Close();
        }

        public WindowsResult Result
        {
            get { return windowsResult; }
        }

        public string Password
        {
            get { return password; }
        }
    }
}
