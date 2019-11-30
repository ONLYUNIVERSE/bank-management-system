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
            using (var context = new BankEntities())
            {
                AccountTable accountTable = new AccountTable()
                {
                    Name = NameTextBox.Text,
                    Sex=SexTextBox.Text,
                    IDNumber=IDNumberTextBox.Text,
                    PhoneNumber=PhoneNumberTextBox.Text,
                    BankCardNumber=BankCardNumberTextBox.Text,
                    Password=PasswdTextBox.Text
                };
            }
        }

    }
}
