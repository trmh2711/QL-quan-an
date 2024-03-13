namespace QL_QuanAn
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_foodCategory = new System.Windows.Forms.ComboBox();
            this.cbo_food = new System.Windows.Forms.ComboBox();
            this.nud_numFod = new System.Windows.Forms.NumericUpDown();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.flp_tableField = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_goiPhong = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.txt_totalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tienPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_discount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_billInfo = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txt_roomName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numFod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_discount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_billInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_foodCategory
            // 
            this.cbo_foodCategory.FormattingEnabled = true;
            this.cbo_foodCategory.Location = new System.Drawing.Point(169, 3);
            this.cbo_foodCategory.Name = "cbo_foodCategory";
            this.cbo_foodCategory.Size = new System.Drawing.Size(240, 24);
            this.cbo_foodCategory.TabIndex = 1;
            this.cbo_foodCategory.SelectionChangeCommitted += new System.EventHandler(this.cbo_foodCategory_SelectionChangeCommitted);
            // 
            // cbo_food
            // 
            this.cbo_food.FormattingEnabled = true;
            this.cbo_food.Location = new System.Drawing.Point(169, 48);
            this.cbo_food.Name = "cbo_food";
            this.cbo_food.Size = new System.Drawing.Size(240, 24);
            this.cbo_food.TabIndex = 2;
            // 
            // nud_numFod
            // 
            this.nud_numFod.Location = new System.Drawing.Point(169, 88);
            this.nud_numFod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_numFod.Name = "nud_numFod";
            this.nud_numFod.Size = new System.Drawing.Size(120, 22);
            this.nud_numFod.TabIndex = 3;
            this.nud_numFod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addFood
            // 
            this.btn_addFood.Location = new System.Drawing.Point(310, 83);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(99, 30);
            this.btn_addFood.TabIndex = 4;
            this.btn_addFood.Text = "thêm móm";
            this.btn_addFood.UseVisualStyleBackColor = true;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // flp_tableField
            // 
            this.flp_tableField.Location = new System.Drawing.Point(12, 12);
            this.flp_tableField.Name = "flp_tableField";
            this.flp_tableField.Size = new System.Drawing.Size(479, 498);
            this.flp_tableField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "danh mục ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "tên mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "số lượng";
            // 
            // btn_goiPhong
            // 
            this.btn_goiPhong.Location = new System.Drawing.Point(6, 91);
            this.btn_goiPhong.Name = "btn_goiPhong";
            this.btn_goiPhong.Size = new System.Drawing.Size(104, 29);
            this.btn_goiPhong.TabIndex = 11;
            this.btn_goiPhong.Text = "đặt phòng";
            this.btn_goiPhong.UseVisualStyleBackColor = true;
            this.btn_goiPhong.Click += new System.EventHandler(this.btn_goiPhong_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(344, 87);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(104, 29);
            this.btn_ThanhToan.TabIndex = 12;
            this.btn_ThanhToan.Text = "thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.Location = new System.Drawing.Point(81, 45);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.ReadOnly = true;
            this.txt_totalPrice.Size = new System.Drawing.Size(152, 22);
            this.txt_totalPrice.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "tiền phòng";
            // 
            // txt_tienPhong
            // 
            this.txt_tienPhong.Location = new System.Drawing.Point(81, 8);
            this.txt_tienPhong.Name = "txt_tienPhong";
            this.txt_tienPhong.ReadOnly = true;
            this.txt_tienPhong.Size = new System.Drawing.Size(152, 22);
            this.txt_tienPhong.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "giảm giá";
            // 
            // nud_discount
            // 
            this.nud_discount.Location = new System.Drawing.Point(317, 5);
            this.nud_discount.Name = "nud_discount";
            this.nud_discount.Size = new System.Drawing.Size(92, 22);
            this.nud_discount.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv_billInfo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(497, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 498);
            this.panel1.TabIndex = 19;
            // 
            // dtgv_billInfo
            // 
            this.dtgv_billInfo.AllowUserToAddRows = false;
            this.dtgv_billInfo.AllowUserToDeleteRows = false;
            this.dtgv_billInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_billInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv_billInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_billInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.count,
            this.totalPrice});
            this.dtgv_billInfo.Location = new System.Drawing.Point(0, 135);
            this.dtgv_billInfo.Name = "dtgv_billInfo";
            this.dtgv_billInfo.ReadOnly = true;
            this.dtgv_billInfo.RowHeadersWidth = 51;
            this.dtgv_billInfo.RowTemplate.Height = 24;
            this.dtgv_billInfo.Size = new System.Drawing.Size(497, 225);
            this.dtgv_billInfo.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "tên món";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "đơn giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "số lượng";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "total";
            this.totalPrice.HeaderText = "tổng tiền";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_tam);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.txt_roomName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_goiPhong);
            this.panel3.Controls.Add(this.nud_discount);
            this.panel3.Controls.Add(this.btn_ThanhToan);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_totalPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_tienPhong);
            this.panel3.Location = new System.Drawing.Point(27, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 126);
            this.panel3.TabIndex = 0;
            // 
            // txt_tam
            // 
            this.txt_tam.Location = new System.Drawing.Point(315, 45);
            this.txt_tam.Name = "txt_tam";
            this.txt_tam.ReadOnly = true;
            this.txt_tam.Size = new System.Drawing.Size(142, 22);
            this.txt_tam.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "tạm tính";
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.Lime;
            this.btnDiscount.Location = new System.Drawing.Point(415, 5);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(33, 25);
            this.btnDiscount.TabIndex = 20;
            this.btnDiscount.Text = "V";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txt_roomName
            // 
            this.txt_roomName.BackColor = System.Drawing.Color.White;
            this.txt_roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_roomName.ForeColor = System.Drawing.Color.Red;
            this.txt_roomName.Location = new System.Drawing.Point(155, 87);
            this.txt_roomName.Name = "txt_roomName";
            this.txt_roomName.ReadOnly = true;
            this.txt_roomName.Size = new System.Drawing.Size(143, 30);
            this.txt_roomName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbo_foodCategory);
            this.panel2.Controls.Add(this.cbo_food);
            this.panel2.Controls.Add(this.nud_numFod);
            this.panel2.Controls.Add(this.btn_addFood);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(43, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 126);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1007, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_tableField);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_numFod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_discount)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_billInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_foodCategory;
        private System.Windows.Forms.ComboBox cbo_food;
        private System.Windows.Forms.NumericUpDown nud_numFod;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.FlowLayoutPanel flp_tableField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_goiPhong;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.TextBox txt_totalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tienPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_discount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_roomName;
        private System.Windows.Forms.DataGridView dtgv_billInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txt_tam;
        private System.Windows.Forms.Label label7;
    }
}

