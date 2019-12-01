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
    /// OpenAccount.xaml 的交互逻辑
    /// </summary>
    public partial class OpenAccount : Window
    {

        public OpenAccount()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            ComboBoxType.Items.Add("仅开户");
            ComboBoxType.Items.Add("活期存款");
            ComboBoxType.Items.Add("定期存款");
            ComboBoxType.SelectedIndex = ComboBoxType.Items.IndexOf("仅开户");
            if(ComboBoxType.SelectedItem.ToString()=="定期存款")
            {
                ComboBoxTime.Items.Add("1年");
                ComboBoxTime.Items.Add("3年");
                ComboBoxTime.Items.Add("5年");
            }
            else
            {
                
            }
        }
        
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            bool failure = true;   //开户成功与否
            while (failure)
            {

                if (IDNumberTextBox.Text.ToString().Length == 18)
                {
                    if (!(ComboBoxType.SelectedItem.ToString() == "定期存款" && ComboBoxTime.SelectedItem.ToString()== ""))
                    {
                        if (BankCardNumberTextBox.Text.ToString().Length > 15 && BankCardNumberTextBox.Text.ToString().Length < 20)
                        {
                            if (PasswdTextBox.Text == PasswdAgainTextBox.Text)
                            {
                                using (var context = new BankEntities())
                                {
                                    AccountInfo accountInfo = new AccountInfo()
                                    {
                                        accountName = NameTextBox.Text.ToString(),
                                        IdCard = IDNumberTextBox.Text.ToString(),
                                        accountNo = BankCardNumberTextBox.Text.ToString(),
                                        accountPass = PasswdTextBox.Text.ToString()
                                    };
                                }
                            }
                            else
                            {
                                MessageBox.Show("两次输入的密码不一致！");
                                PasswdTextBox.Text = "";
                                PasswdAgainTextBox.Text = "";
                                PasswdTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("无效的银行卡号！");
                            BankCardNumberTextBox.Text = "";
                            BankCardNumberTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择存款期限！");
                    }
                }
                else
                {
                    MessageBox.Show("无效的身份证号！");
                    IDNumberTextBox.Text = "";
                    IDNumberTextBox.Focus();
                }


                failure = false;
            }
            Login login = new Login();
            this.Close();
            login.ShowDialog();
        }

        private void CancleOpenAccount_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
