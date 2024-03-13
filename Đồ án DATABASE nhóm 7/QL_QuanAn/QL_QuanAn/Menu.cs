using QL_QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanAn
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(AccountDTO acc)
        {
            InitializeComponent();
            this.acc = acc;
        }
        private AccountDTO acc = new AccountDTO();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(acc);
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager M = new Manager(acc);
            M.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistical M = new statistical(acc);
            M.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            txt_displayNameUser.Text = acc.DisplayName;
            if(acc.Type == 0)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            else if(acc.Type == 1)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            else if(acc.Type == 2)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
        }
    }
}
