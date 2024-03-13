using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_QuanAn.DAO;
using QL_QuanAn.DTO;

namespace QL_QuanAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txt_dataName.Text= "MANHHUNG27\\SQLEXPRESS";
            txt_userName.Focus();
            txt_userName.Text = "sa";
            txt_password.Text = "1";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string dataName = txt_dataName.Text;
            string userName = txt_userName.Text;
            string password = txt_password.Text;
            if (DataProvider.Instance.testConnect(dataName, userName, password) == 1)
            {
                AccountDTO ACC = new AccountDTO();
                ACC = AccountDAO.Instance.getAccountByUName(userName);
                this.Hide();
                Menu f = new Menu(ACC);
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("mật khẩu hoặc tài khoản không chính xác");
            }
        }
    }
}
