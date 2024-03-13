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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(AccountDTO acc)
        {
            InitializeComponent();
            this.acc = acc;
        }
        int width = 80;
        int height = 80;
        private int? currentRoomId;
        AccountDTO acc = new AccountDTO();
        private void Form1_Load(object sender, EventArgs e)
        {
            updateCBOCategoryFood();
            loadRoomField();
            updateCBOFoodByCate((int)cbo_foodCategory.SelectedValue);
            if (acc.Type == 0)
            {
                btn_ThanhToan.Enabled = false;
                btn_addFood.Enabled = false;
                btnDiscount.Enabled = false;
                btn_goiPhong.Enabled = false;
            }
            else if (acc.Type == 1)
            {
                btn_ThanhToan.Enabled = true;
                btn_addFood.Enabled = true;
                btnDiscount.Enabled = true;
                btn_goiPhong.Enabled = true;
            }
            else if(acc.Type == 2)
            {
                btn_ThanhToan.Enabled = true;
                btn_addFood.Enabled = true;
                btnDiscount.Enabled = true;
                btn_goiPhong.Enabled = true;
            }
        }



        private void cbo_foodCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateCBOFoodByCate((int) cbo_foodCategory.SelectedValue);
        }




        // chọn phòng bằng giao diện 
        private void btn_click(object sender, EventArgs e)
        {
            resetValues();
            //lấy ra id của phòng vừa chọn 
            RoomDTO room = (RoomDTO)(sender as Button).Tag;
            currentRoomId = room.ID;
            // hiển thị tên phòng dc chọn 
            txt_roomName.Text = room.Name;
            //lấy bill của phòng dc chọn nếu không có bill kết thúc
            BillDTO bill = BillDAO.Instance.getUnpaidBill(room.ID);
            if (bill == null)
            {
                dtgv_billInfo.DataSource = BillInfoItemDAO.Instance.getAll(-1);
                return;
            }
            //lấy bill info của bill dc chon đưa lên datagridview

            UpdateBillInfo(bill.ID);
            reLoadValues(bill.ID);
            txt_tam.Text = (Convert.ToInt32(txt_totalPrice.Text) * (1 - (float)nud_discount.Value /100) ).ToString();
        }


        private void btn_goiPhong_Click(object sender, EventArgs e)
        {
            if (currentRoomId== null)
            {
                MessageBox.Show("chưa chọn phòng");
                return;
            }
            BillDTO temp = BillDAO.Instance.getUnpaidBill((int)currentRoomId);
            if (temp != null)
            {
                MessageBox.Show("Phòng này đang được đạt");
                return;
            }
            int idRoom = (int)currentRoomId;
            BillDAO.Instance.taoBill(idRoom, acc.ID);
            loadRoomField();
            BillDTO bill = BillDAO.Instance.getUnpaidBill(idRoom);
            UpdateBillInfo(bill.ID);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(currentRoomId== null)
            {
                MessageBox.Show("chưa chọn phòng");
                return;
            }
            var bill = BillDAO.Instance.getUnpaidBill((int)currentRoomId);
            if (bill == null)
            {
                MessageBox.Show("phòng này chưa được đặt");
                return;
            }
            BillDAO.Instance.traPhong(bill.ID);
            loadRoomField();
            resetValues();
        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {
            if(cbo_food.SelectedValue == null)
            {
                MessageBox.Show("chưa chọn món");
                return;
            }
            if(currentRoomId== null)
            {
                MessageBox.Show("chưa chọn bàn");
                return;
            }
            var bill = BillDAO.Instance.getUnpaidBill((int)currentRoomId);
            if(bill == null)
            {
                MessageBox.Show("phòng này chưa được đặt");
                return;
            }
            BillInfoDAO.Instance.addBillInfo(bill.ID, (int)cbo_food.SelectedValue,(int) nud_numFod.Value);
            UpdateBillInfo(bill.ID);
            resetValues();
            
            reLoadValues(bill.ID);

        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (currentRoomId== null)
            {
                MessageBox.Show("chưa chọn bàn");
                return;
            }
            var bill = BillDAO.Instance.getUnpaidBill((int)currentRoomId);
            if (bill != null)
            {
                BillDAO.Instance.updateDiscount(bill.ID, (int)nud_discount.Value);
                txt_tam.Text = (Convert.ToInt32(txt_totalPrice.Text) * (1 - (float)nud_discount.Value /100)).ToString();
                MessageBox.Show("đã thêm phiếu giảm giá");
                return;
            }

        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void updateCBOCategoryFood()
        {
            cbo_foodCategory.DataSource = null;
            cbo_foodCategory.DataSource = FoodCategoryDAO.Instance.getAll();
            cbo_foodCategory.DisplayMember= "Name";
            cbo_foodCategory.ValueMember= "ID";
        }

        private void updateCBOFood()
        {
            cbo_food.DataSource = null;
            cbo_food.DataSource = FoodDAO.Instance.getAll();
            cbo_food.DisplayMember= "Name";
            cbo_food.ValueMember= "ID";
        }
        private void updateCBOFoodByCate(int id)
        {
            cbo_food.DataSource = null;
            cbo_food.DataSource = FoodDAO.Instance.getFoodByIdCategory(id);
            cbo_food.DisplayMember= "Name";
            cbo_food.ValueMember= "ID";
        }
        public void reLoadValues(int id)
        {
            BillDTO bill = BillDAO.Instance.getBillById(id);
            txt_tienPhong.Text = bill.roomPrice.ToString();
            txt_totalPrice.Text = bill.TotalPrice.ToString();
            nud_discount.Value = bill.DisCount;
        }
        public void resetValues()
        {
            txt_tienPhong.Text = "0";
            txt_totalPrice.Text = "0";
            txt_tam.Text = "0";
            nud_discount.Value = 0;
        }
        private void UpdateBillInfo(int id)
        {
            var billInfo = BillInfoItemDAO.Instance.getAll(id);
            dtgv_billInfo.DataSource = billInfo;
        }


        private void loadRoomField()
        {
            flp_tableField.Controls.Clear();
            var RoomDTOs = RoomDAO.Instance.getAll();
            foreach (var RoomDTO in RoomDTOs)
            {
                Button btn = new Button();
                btn.Width= width;
                btn.Height= height;
                btn.Text = RoomDTO.Name;
                btn.Text += Environment.NewLine + RoomDTO.Status;
                btn.Tag = RoomDTO;
                btn.Click += btn_click;
                if (RoomDTO.Status == "trống")
                {
                    btn.BackColor = Color.Lime;
                }
                else
                {
                    btn.BackColor = Color.Pink;
                }
                flp_tableField.Controls.Add(btn);
            }
        }







        //private void btn_click(object sender, EventArgs e)
        //{
        //    lv_billInfo.Items.Clear();

        //    //lấy ra id của phòng vừa chọn 
        //    int id = (int)(sender as Button).Tag;
        //    currentRoomId = id;
        //    // hiển thị tên phòng dc chọn 
        //    lb_currentTable.Text = id.ToString();
        //    //lấy bill của phòng dc chọn nếu không có bill kết thúc
        //    var obj = 
        //    if (obj == null)
        //    {
        //        updateTotalprice();
        //        return;
        //    }
        //    //lấy bill info của bill dc chon đưa lên listview 
        //    loadListView(obj.id);
        //}

    }
}
