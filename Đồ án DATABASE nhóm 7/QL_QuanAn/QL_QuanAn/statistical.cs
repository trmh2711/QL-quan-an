using QL_QuanAn.DAO;
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
    public partial class statistical : Form
    {
        public statistical()
        {
            InitializeComponent();
        }
        public statistical(AccountDTO acc)
        {
            InitializeComponent();
            this.acc = acc;
        }
        AccountDTO acc = new AccountDTO();

        private void statistical_Load(object sender, EventArgs e)
        {

        }

        private void updateTotal()
        {
            double total = 0;
            
        }

        private void dt_starts_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_fillter_Click(object sender, EventArgs e)
        {
            DateTime start = dt_starts.Value;
            DateTime end = dt_end.Value;
            var bills = BillDAO.Instance.fillterBills(start, end);
            dataGridView1.DataSource= bills;
            double tongThu = 0;
            double thucThu = 0;
            foreach (var b in bills)
            {
                if(b.Status == 1)
                {
                    tongThu += b.TotalPrice;
                    thucThu+= b.lastPrice;
                }
            }
            txt_total.Text = tongThu.ToString();
            txt_lastTotal.Text = thucThu.ToString();
        }
    }
}
