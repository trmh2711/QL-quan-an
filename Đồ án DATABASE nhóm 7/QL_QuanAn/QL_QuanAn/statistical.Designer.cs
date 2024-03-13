namespace QL_QuanAn
{
    partial class statistical
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
            this.tab_bill = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dt_starts = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_lastTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fillter = new System.Windows.Forms.Button();
            this.tab_bill.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_bill
            // 
            this.tab_bill.Controls.Add(this.tabPage1);
            this.tab_bill.Controls.Add(this.tabPage2);
            this.tab_bill.Location = new System.Drawing.Point(2, 2);
            this.tab_bill.Name = "tab_bill";
            this.tab_bill.SelectedIndex = 0;
            this.tab_bill.Size = new System.Drawing.Size(1005, 520);
            this.tab_bill.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPage1.Controls.Add(this.btn_fillter);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_lastTotal);
            this.tabPage1.Controls.Add(this.txt_total);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dt_end);
            this.tabPage1.Controls.Add(this.dt_starts);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "thống kê";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dt_starts
            // 
            this.dt_starts.Location = new System.Drawing.Point(6, 6);
            this.dt_starts.Name = "dt_starts";
            this.dt_starts.Size = new System.Drawing.Size(200, 22);
            this.dt_starts.TabIndex = 0;
            this.dt_starts.ValueChanged += new System.EventHandler(this.dt_starts_ValueChanged);
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(789, 6);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(200, 22);
            this.dt_end.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 397);
            this.dataGridView1.TabIndex = 2;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(90, 452);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(153, 22);
            this.txt_total.TabIndex = 3;
            // 
            // txt_lastTotal
            // 
            this.txt_lastTotal.Location = new System.Drawing.Point(359, 452);
            this.txt_lastTotal.Name = "txt_lastTotal";
            this.txt_lastTotal.Size = new System.Drawing.Size(153, 22);
            this.txt_lastTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "tổng thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "thực thu";
            // 
            // btn_fillter
            // 
            this.btn_fillter.Location = new System.Drawing.Point(426, 6);
            this.btn_fillter.Name = "btn_fillter";
            this.btn_fillter.Size = new System.Drawing.Size(133, 23);
            this.btn_fillter.TabIndex = 7;
            this.btn_fillter.Text = "lọc";
            this.btn_fillter.UseVisualStyleBackColor = true;
            this.btn_fillter.Click += new System.EventHandler(this.btn_fillter_Click);
            // 
            // statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1007, 522);
            this.Controls.Add(this.tab_bill);
            this.Name = "statistical";
            this.Text = "statistical";
            this.Load += new System.EventHandler(this.statistical_Load);
            this.tab_bill.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_bill;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_fillter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lastTotal;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.DateTimePicker dt_starts;
        private System.Windows.Forms.TabPage tabPage2;
    }
}