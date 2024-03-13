namespace QL_QuanAn
{
    partial class Login
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
            this.txt_dataName = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dataName
            // 
            this.txt_dataName.Location = new System.Drawing.Point(137, 35);
            this.txt_dataName.Name = "txt_dataName";
            this.txt_dataName.Size = new System.Drawing.Size(201, 22);
            this.txt_dataName.TabIndex = 0;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(137, 69);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(201, 22);
            this.txt_userName.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(137, 111);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(201, 22);
            this.txt_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên máy chủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_userName);
            this.panel1.Controls.Add(this.txt_dataName);
            this.panel1.Location = new System.Drawing.Point(94, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 172);
            this.panel1.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_exit.Location = new System.Drawing.Point(240, 268);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 33);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Aqua;
            this.btn_login.Location = new System.Drawing.Point(363, 268);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 33);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đăng nhập ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(562, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dataName;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label4;
    }
}