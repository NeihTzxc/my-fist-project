namespace QLBH._forms
{
    partial class frmThong_ke
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
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thong_ke = new System.Windows.Forms.Button();
            this.radio_nhap = new System.Windows.Forms.RadioButton();
            this.radio_xuat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.com_thang = new System.Windows.Forms.ComboBox();
            this.com_nam = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid_view = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(639, 44);
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
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.txt_tt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_thong_ke);
            this.panel1.Controls.Add(this.radio_nhap);
            this.panel1.Controls.Add(this.radio_xuat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.com_thang);
            this.panel1.Controls.Add(this.com_nam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 100);
            this.panel1.TabIndex = 5;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_print.Location = new System.Drawing.Point(535, 49);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(92, 29);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_tt
            // 
            this.txt_tt.Location = new System.Drawing.Point(99, 70);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.ReadOnly = true;
            this.txt_tt.Size = new System.Drawing.Size(167, 20);
            this.txt_tt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền";
            // 
            // btn_thong_ke
            // 
            this.btn_thong_ke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.btn_thong_ke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thong_ke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thong_ke.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thong_ke.Location = new System.Drawing.Point(535, 14);
            this.btn_thong_ke.Name = "btn_thong_ke";
            this.btn_thong_ke.Size = new System.Drawing.Size(92, 29);
            this.btn_thong_ke.TabIndex = 3;
            this.btn_thong_ke.Text = "Thống kê";
            this.btn_thong_ke.UseVisualStyleBackColor = false;
            this.btn_thong_ke.Click += new System.EventHandler(this.btn_thong_ke_Click);
            // 
            // radio_nhap
            // 
            this.radio_nhap.AutoSize = true;
            this.radio_nhap.Checked = true;
            this.radio_nhap.Location = new System.Drawing.Point(35, 41);
            this.radio_nhap.Name = "radio_nhap";
            this.radio_nhap.Size = new System.Drawing.Size(98, 17);
            this.radio_nhap.TabIndex = 2;
            this.radio_nhap.TabStop = true;
            this.radio_nhap.Text = "Thống kê nhập";
            this.radio_nhap.UseVisualStyleBackColor = true;
            // 
            // radio_xuat
            // 
            this.radio_xuat.AutoSize = true;
            this.radio_xuat.Location = new System.Drawing.Point(35, 14);
            this.radio_xuat.Name = "radio_xuat";
            this.radio_xuat.Size = new System.Drawing.Size(94, 17);
            this.radio_xuat.TabIndex = 2;
            this.radio_xuat.Text = "Thống kê xuất";
            this.radio_xuat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn tháng";
            // 
            // com_thang
            // 
            this.com_thang.FormattingEnabled = true;
            this.com_thang.Location = new System.Drawing.Point(412, 6);
            this.com_thang.Name = "com_thang";
            this.com_thang.Size = new System.Drawing.Size(88, 21);
            this.com_thang.TabIndex = 0;
            this.com_thang.SelectedIndexChanged += new System.EventHandler(this.com_nam_SelectedIndexChanged);
            // 
            // com_nam
            // 
            this.com_nam.FormattingEnabled = true;
            this.com_nam.Location = new System.Drawing.Point(412, 33);
            this.com_nam.Name = "com_nam";
            this.com_nam.Size = new System.Drawing.Size(88, 21);
            this.com_nam.TabIndex = 0;
            this.com_nam.SelectedIndexChanged += new System.EventHandler(this.com_nam_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_view);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 288);
            this.panel3.TabIndex = 6;
            // 
            // grid_view
            // 
            this.grid_view.AllowUserToAddRows = false;
            this.grid_view.AllowUserToDeleteRows = false;
            this.grid_view.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_view.Location = new System.Drawing.Point(0, 0);
            this.grid_view.Name = "grid_view";
            this.grid_view.ReadOnly = true;
            this.grid_view.Size = new System.Drawing.Size(639, 288);
            this.grid_view.TabIndex = 0;
            // 
            // frmThong_ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmThong_ke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThong_ke_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grid_view;
        private System.Windows.Forms.ComboBox com_nam;
        private System.Windows.Forms.ComboBox com_thang;
        private System.Windows.Forms.RadioButton radio_nhap;
        private System.Windows.Forms.RadioButton radio_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thong_ke;
        private System.Windows.Forms.TextBox txt_tt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_print;
    }
}