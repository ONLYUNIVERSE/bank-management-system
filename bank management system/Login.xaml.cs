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

namespace bank_management_system
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            UserName.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "登录":
                    break;
                case "开户":                                          //开户
                    OpenAccount openAccount = new OpenAccount();
                    this.Close();
                    openAccount.ShowDialog();
                    break;
            }

        }
        /// <summary>
        /// 登录框退出验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)   //登录框退出验证
        {
            MessageBoxResult result = MessageBox.Show("是否退出应用程序？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
            else                        //取消退出
            {
                this.Passwd.Password = "";
                e.Cancel = true;   
            } 
        }
    }
}
