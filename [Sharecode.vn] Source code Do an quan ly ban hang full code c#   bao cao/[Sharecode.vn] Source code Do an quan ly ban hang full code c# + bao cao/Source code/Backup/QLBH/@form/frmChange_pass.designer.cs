namespace QLBH._forms
{
    partial class frmChange_pass
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckb_nhanvien = new System.Windows.Forms.CheckBox();
            this.ckb_admin = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nhanvien_old = new System.Windows.Forms.TextBox();
            this.txt_confim_nhanvien = new System.Windows.Forms.TextBox();
            this.txt_nhanvien_new = new System.Windows.Forms.TextBox();
            this.txt_confim_admin = new System.Windows.Forms.TextBox();
            this.txt_admin_new = new System.Windows.Forms.TextBox();
            this.txt_admin_old = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QLBH.Properties.Resources.title_form;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 44);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đổi mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ckb_nhanvien);
            this.panel1.Controls.Add(this.ckb_admin);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_nhanvien_old);
            this.panel1.Controls.Add(this.txt_confim_nhanvien);
            this.panel1.Controls.Add(this.txt_nhanvien_new);
            this.panel1.Controls.Add(this.txt_confim_admin);
            this.panel1.Controls.Add(this.txt_admin_new);
            this.panel1.Controls.Add(this.txt_admin_old);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 290);
            this.panel1.TabIndex = 6;
            // 
            // ckb_nhanvien
            // 
            this.ckb_nhanvien.AutoSize = true;
            this.ckb_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_nhanvien.Location = new System.Drawing.Point(12, 139);
            this.ckb_nhanvien.Name = "ckb_nhanvien";
            this.ckb_nhanvien.Size = new System.Drawing.Size(96, 20);
            this.ckb_nhanvien.TabIndex = 5;
            this.ckb_nhanvien.Text = "Nhân viên";
            this.ckb_nhanvien.UseVisualStyleBackColor = true;
            this.ckb_nhanvien.CheckedChanged += new System.EventHandler(this.ckb_nhanvien_CheckedChanged);
            // 
            // ckb_admin
            // 
            this.ckb_admin.AutoSize = true;
            this.ckb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_admin.Location = new System.Drawing.Point(12, 3);
            this.ckb_admin.Name = "ckb_admin";
            this.ckb_admin.Size = new System.Drawing.Size(70, 20);
            this.ckb_admin.TabIndex = 4;
            this.ckb_admin.Text = "Admin";
            this.ckb_admin.UseVisualStyleBackColor = true;
            this.ckb_admin.CheckedChanged += new System.EventHandler(this.ckb_admin_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(450, 157);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ok.Location = new System.Drawing.Point(450, 71);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Xác nhận mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xác nhận mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu mới";
            // 
            // txt_nhanvien_old
            // 
            this.txt_nhanvien_old.Location = new System.Drawing.Point(196, 155);
            this.txt_nhanvien_old.MaxLength = 2;
            this.txt_nhanvien_old.Name = "txt_nhanvien_old";
            this.txt_nhanvien_old.ReadOnly = true;
            this.txt_nhanvien_old.Size = new System.Drawing.Size(206, 20);
            this.txt_nhanvien_old.TabIndex = 3;
            // 
            // txt_confim_nhanvien
            // 
            this.txt_confim_nhanvien.Location = new System.Drawing.Point(196, 235);
            this.txt_confim_nhanvien.MaxLength = 2;
            this.txt_confim_nhanvien.Name = "txt_confim_nhanvien";
            this.txt_confim_nhanvien.PasswordChar = '*';
            this.txt_confim_nhanvien.Size = new System.Drawing.Size(206, 20);
            this.txt_confim_nhanvien.TabIndex = 5;
            // 
            // txt_nhanvien_new
            // 
            this.txt_nhanvien_new.Location = new System.Drawing.Point(196, 193);
            this.txt_nhanvien_new.MaxLength = 2;
            this.txt_nhanvien_new.Name = "txt_nhanvien_new";
            this.txt_nhanvien_new.PasswordChar = '*';
            this.txt_nhanvien_new.Size = new System.Drawing.Size(206, 20);
            this.txt_nhanvien_new.TabIndex = 4;
            // 
            // txt_confim_admin
            // 
            this.txt_confim_admin.Location = new System.Drawing.Point(196, 95);
            this.txt_confim_admin.MaxLength = 150;
            this.txt_confim_admin.Name = "txt_confim_admin";
            this.txt_confim_admin.PasswordChar = '*';
            this.txt_confim_admin.Size = new System.Drawing.Size(206, 20);
            this.txt_confim_admin.TabIndex = 2;
            // 
            // txt_admin_new
            // 
            this.txt_admin_new.Location = new System.Drawing.Point(196, 55);
            this.txt_admin_new.MaxLength = 150;
            this.txt_admin_new.Name = "txt_admin_new";
            this.txt_admin_new.PasswordChar = '*';
            this.txt_admin_new.Size = new System.Drawing.Size(206, 20);
            this.txt_admin_new.TabIndex = 1;
            // 
            // txt_admin_old
            // 
            this.txt_admin_old.Location = new System.Drawing.Point(196, 17);
            this.txt_admin_old.MaxLength = 150;
            this.txt_admin_old.Name = "txt_admin_old";
            this.txt_admin_old.ReadOnly = true;
            this.txt_admin_old.Size = new System.Drawing.Size(206, 20);
            this.txt_admin_old.TabIndex = 0;
            // 
            // frmChange_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 334);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmChange_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmChange_pass_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nhanvien_new;
        private System.Windows.Forms.TextBox txt_admin_old;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_admin_new;
        private System.Windows.Forms.TextBox txt_nhanvien_old;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_confim_nhanvien;
        private System.Windows.Forms.TextBox txt_confim_admin;
        private System.Windows.Forms.CheckBox ckb_nhanvien;
        private System.Windows.Forms.CheckBox ckb_admin;
    }
}