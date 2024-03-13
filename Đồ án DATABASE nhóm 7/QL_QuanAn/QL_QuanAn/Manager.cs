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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        public Manager(AccountDTO acc)
        {
            InitializeComponent();
            this.acc = acc;
        }
        AccountDTO acc = new AccountDTO();
        private void Manager_Load(object sender, EventArgs e)
        {
            loadFoodCategory();
            loadFood();
            loadRoom();
            loadAccount();
            loadCategory();

        }

        private void loadFoodCategory()
        {
            var foodCategorys = FoodCategoryDAO.Instance.getAll();
            dtgv_foodCate.DataSource = foodCategorys;
        }

        private void loadFood()
        {
            var foods = FoodDAO.Instance.getAll();
            dtgv_food.DataSource = foods;
        }

        private void loadRoom()
        {
            var room = RoomDAO.Instance.getAll();
            dtgv_room.DataSource = room;
        }

        private void loadAccount()
        {
            var account = AccountDAO.Instance.getAll();
            foreach (var item in account)
            {
                item.Password = "*****";
            }
            dtgv_account.DataSource = account;
        }





        private void dtgv_foodCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dtgv_foodCate.SelectedCells[0].OwningRow.Cells[0].Value;
            FoodCategoryDTO selectedCate = FoodCategoryDAO.Instance.getFoodCateByID(id);
            txt_idFoodCategory.Text = selectedCate.ID.ToString();
            txt_nameFoodCategory.Text = selectedCate.Name.ToString();
        }

        private void dtgv_food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dtgv_food.SelectedCells[0].OwningRow.Cells[0].Value;
            FoodDTO food = FoodDAO.Instance.getFoodByID(id);
            txt_idFood.Text = food.ID.ToString();
            txt_nameFood.Text = food.Name.ToString();
            txt_priceFood.Text = food.Price.ToString();
            cbo_category.SelectedValue = food.IDCategory;
        }
        private void loadCategory()
        {
            List<FoodCategoryDTO> cate = FoodCategoryDAO.Instance.getAll();
            cbo_category.DataSource = cate;
            cbo_category.DisplayMember= "Name";
            cbo_category.ValueMember= "id";
        }
        private void dtgv_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dtgv_room.SelectedCells[0].OwningRow.Cells[0].Value;
            RoomDTO room = RoomDAO.Instance.getRoomByID(id);
            txt_idRoom.Text = room.ID.ToString();
            txt_nameRoom.Text = room.Name.ToString();
            txt_pricePerM.Text = room.price.ToString();
        }

        private void dtgv_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dtgv_account.SelectedCells[0].OwningRow.Cells[0].Value;
            AccountDTO acc = AccountDAO.Instance.getAccountByID(id);
            txt_idAccount.Text = acc.ID.ToString();
            txt_displayNAccount.Text = acc.DisplayName.ToString();
            txt_userNAccount.Text = acc.UserName.ToString();
            txt_passwordAccount.Text = acc.Password.ToString();
            txt_typeAccount.Text = acc.Type.ToString();
        }

        private void btn_searchAcc_Click(object sender, EventArgs e)
        {
            if(txt_searchAcc.Text.Length == 0)
            {
                loadAccount();
                return;
            }
            var account = AccountDAO.Instance.searchAccount(txt_searchAcc.Text);
            foreach (var item in account)
            {
                item.Password = "*****";
            }
            dtgv_account.DataSource = account;
        }
        private void btn_searchRoom_Click(object sender, EventArgs e)
        {
            if (txt_searchRoom.Text.Length == 0)
            {
                loadRoom();
                return;
            }
            var room = RoomDAO.Instance.searchRoom(txt_searchRoom.Text);
            dtgv_room.DataSource = room;
        }

        private void btn_searchFood_Click(object sender, EventArgs e)
        {
            if (txt_searchFood.Text.Length == 0)
            {
                loadFood();
                return;
            }
            var foods = FoodDAO.Instance.searchFood(txt_searchFood.Text);
            dtgv_food.DataSource = foods;
        }

        private void btn_searchCate_Click(object sender, EventArgs e)
        {
            if (txt_searchCate.Text.Length == 0)
            {
                loadFoodCategory();
                return;
            }
            var foodCategorys = FoodCategoryDAO.Instance.searchFoodCategory(txt_searchCate.Text);
            dtgv_foodCate.DataSource = foodCategorys;
        }

        private void btn_addFoodCategory_Click(object sender, EventArgs e)
        {
            FoodCategoryDAO.Instance.addFoodCategory(txt_nameFoodCategory.Text);
            loadFoodCategory();
        }

        private void btn_editCategory_Click(object sender, EventArgs e)
        {
            if (txt_idFoodCategory.Text.Length <= 0)
            {
                return;
            }
            FoodCategoryDAO.Instance.editFoodCategory(Convert.ToInt32(txt_idFoodCategory.Text), txt_nameFoodCategory.Text);
            loadFoodCategory();
        }

        private void btn_deleteFoodCategory_Click(object sender, EventArgs e)
        {   
            if (txt_idFoodCategory.Text.Length <= 0)
            {
                return;
            }
            int id = Convert.ToInt32(txt_idFoodCategory.Text);
            if (FoodDAO.Instance.getFoodByIdCategory(id).Count > 0)
            {
                MessageBox.Show("không thể xóa trường này");
                return;
            }
            FoodCategoryDAO.Instance.deleteFoodCategory(id);
            loadFoodCategory();
        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {
            FoodDAO.Instance.addFood(txt_nameFood.Text, (int)cbo_category.SelectedValue, Convert.ToDouble(txt_priceFood.Text));
            loadFood();
        }

        private void btn_editFood_Click(object sender, EventArgs e)
        {
            if (txt_idFood.Text.Length <= 0)
            {
                return;
            }
            FoodDAO.Instance.editFood(Convert.ToInt32(txt_idFood.Text), txt_nameFood.Text, (int)(cbo_category.SelectedValue), Convert.ToDouble(txt_priceFood.Text));
            loadFood();
        }

        private void btn_deleteFood_Click(object sender, EventArgs e)
        {
            if (txt_idFood.Text.Length <= 0)
            {
                return;
            }
            FoodDAO.Instance.deleteFood(Convert.ToInt32(txt_idFood.Text));
            loadFood();
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            RoomDAO.Instance.addRoom(txt_nameRoom.Text, Convert.ToDouble(txt_pricePerM.Text));
            loadRoom();
        }

        private void btn_editRoom_Click(object sender, EventArgs e)
        {
            if (txt_idRoom.Text.Length <= 0)
            {
                return;
            }
            RoomDAO.Instance.editRoom(Convert.ToInt32(txt_idRoom.Text),txt_nameRoom.Text, Convert.ToDouble(txt_pricePerM.Text));
            loadRoom();
        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            if(txt_idRoom.Text.Length <= 0)
            {
                return;
            }
            int id = Convert.ToInt32(txt_idRoom.Text);
            if (BillDAO.Instance.getUnpaidBill(id) != null)
            {
                MessageBox.Show("không thể xóa trường này");
                return;
            }
            RoomDAO.Instance.deleteRoom(id);
            loadRoom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = txt_passwordAccount.UseSystemPasswordChar == true ? txt_passwordAccount.UseSystemPasswordChar = false : txt_passwordAccount.UseSystemPasswordChar = true;
        }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.addAccount(txt_userNAccount.Text, txt_passwordAccount.Text, Convert.ToInt32(txt_typeAccount.Text));
            loadAccount();
        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            if (txt_idAccount.Text.Length <= 0)
            {
                return;
            }
            AccountDAO.Instance.deleteAccount(Convert.ToInt32(txt_idAccount.Text));
            loadAccount();
        }
    }
}
