namespace QLBH._forms
{
    partial class frmNhan_vien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhan_vien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.com_phai = new System.Windows.Forms.ComboBox();
            this.com_cv = new System.Windows.Forms.ComboBox();
            this.date_ns = new System.Windows.Forms.DateTimePicker();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ht = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ma_nv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstv_nhan_vien = new System.Windows.Forms.ListView();
            this.ma_nv = new System.Windows.Forms.ColumnHeader();
            this.hoten_nv = new System.Windows.Forms.ColumnHeader();
            this.dc_nv = new System.Windows.Forms.ColumnHeader();
            this.cv_nv = new System.Windows.Forms.ColumnHeader();
            this.phai_nv = new System.Windows.Forms.ColumnHeader();
            this.dt_nv = new System.Windows.Forms.ColumnHeader();
            this.nam_sinh_nv = new System.Windows.Forms.ColumnHeader();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.side1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Update = new System.Windows.Forms.ToolStripButton();
            this.side2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.side3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.side4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.com_phai);
            this.groupBox1.Controls.Add(this.com_cv);
            this.groupBox1.Controls.Add(this.date_ns);
            this.groupBox1.Controls.Add(this.txt_dt);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_ht);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ma_nv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // com_phai
            // 
            this.com_phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_phai.FormattingEnabled = true;
            this.com_phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.com_phai.Location = new System.Drawing.Point(453, 38);
            this.com_phai.Name = "com_phai";
            this.com_phai.Size = new System.Drawing.Size(86, 21);
            this.com_phai.TabIndex = 2;
            this.com_phai.SelectedIndexChanged += new System.EventHandler(this.com_phai_SelectedIndexChanged);
            // 
            // com_cv
            // 
            this.com_cv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_cv.FormattingEnabled = true;
            this.com_cv.Items.AddRange(new object[] {
            "Nhân viên",
            "Thủ kho",
            "Quản lý",
            "Giám đốc"});
            this.com_cv.Location = new System.Drawing.Point(98, 117);
            this.com_cv.Name = "com_cv";
            this.com_cv.Size = new System.Drawing.Size(86, 21);
            this.com_cv.TabIndex = 5;
            // 
            // date_ns
            // 
            this.date_ns.CustomFormat = "";
            this.date_ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ns.Location = new System.Drawing.Point(98, 65);
            this.date_ns.MaxDate = new System.DateTime(2100, 10, 13, 0, 0, 0, 0);
            this.date_ns.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_ns.Name = "date_ns";
            this.date_ns.Size = new System.Drawing.Size(188, 20);
            this.date_ns.TabIndex = 3;
            this.date_ns.Value = new System.DateTime(2010, 10, 13, 0, 0, 0, 0);
            // 
            // txt_dt
            // 
            this.txt_dt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dt.Location = new System.Drawing.Point(98, 144);
            this.txt_dt.MaxLength = 15;
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(188, 20);
            this.txt_dt.TabIndex = 6;
            this.txt_dt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ml_dg_KeyDown);
            this.txt_dt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dt_KeyPress);
            // 
            // txt_dc
            // 
            this.txt_dc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dc.Location = new System.Drawing.Point(98, 91);
            this.txt_dc.MaxLength = 150;
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(368, 20);
            this.txt_dc.TabIndex = 4;
            this.txt_dc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ml_dg_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Năm sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chức vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số ĐT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // txt_ht
            // 
            this.txt_ht.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ht.Location = new System.Drawing.Point(98, 38);
            this.txt_ht.MaxLength = 50;
            this.txt_ht.Name = "txt_ht";
            this.txt_ht.Size = new System.Drawing.Size(223, 20);
            this.txt_ht.TabIndex = 1;
            this.txt_ht.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ml_dg_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(381, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ tên";
            // 
            // txt_ma_nv
            // 
            this.txt_ma_nv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ma_nv.Location = new System.Drawing.Point(98, 13);
            this.txt_ma_nv.MaxLength = 5;
            this.txt_ma_nv.Name = "txt_ma_nv";
            this.txt_ma_nv.Size = new System.Drawing.Size(86, 20);
            this.txt_ma_nv.TabIndex = 0;
            this.txt_ma_nv.Leave += new System.EventHandler(this.txt_ml_Leave);
            this.txt_ma_nv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ma_nv_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lstv_nhan_vien);
            this.panel3.Location = new System.Drawing.Point(1, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 244);
            this.panel3.TabIndex = 14;
            // 
            // lstv_nhan_vien
            // 
            this.lstv_nhan_vien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ma_nv,
            this.hoten_nv,
            this.dc_nv,
            this.cv_nv,
            this.phai_nv,
            this.dt_nv,
            this.nam_sinh_nv});
            this.lstv_nhan_vien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstv_nhan_vien.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_nhan_vien.FullRowSelect = true;
            this.lstv_nhan_vien.GridLines = true;
            this.lstv_nhan_vien.Location = new System.Drawing.Point(0, 0);
            this.lstv_nhan_vien.Name = "lstv_nhan_vien";
            this.lstv_nhan_vien.Size = new System.Drawing.Size(720, 244);
            this.lstv_nhan_vien.TabIndex = 1;
            this.lstv_nhan_vien.UseCompatibleStateImageBehavior = false;
            this.lstv_nhan_vien.View = System.Windows.Forms.View.Details;
            this.lstv_nhan_vien.SelectedIndexChanged += new System.EventHandler(this.lstv_nhan_vien_SelectedIndexChanged_1);
            // 
            // ma_nv
            // 
            this.ma_nv.Text = "Mã nhân viên";
            this.ma_nv.Width = 98;
            // 
            // hoten_nv
            // 
            this.hoten_nv.Text = "Họ tên";
            // 
            // dc_nv
            // 
            this.dc_nv.Text = "Địa chỉ";
            this.dc_nv.Width = 167;
            // 
            // cv_nv
            // 
            this.cv_nv.Text = "Chức vụ";
            this.cv_nv.Width = 92;
            // 
            // phai_nv
            // 
            this.phai_nv.Text = "Giới tính";
            this.phai_nv.Width = 63;
            // 
            // dt_nv
            // 
            this.dt_nv.Text = "ĐT";
            this.dt_nv.Width = 133;
            // 
            // nam_sinh_nv
            // 
            this.nam_sinh_nv.Text = "Năm sinh";
            this.nam_sinh_nv.Width = 103;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.side1,
            this.btn_Update,
            this.side2,
            this.btn_Delete,
            this.side3,
            this.btn_Refresh,
            this.side4,
            this.btn_Cancel,
            this.toolStripSeparator7,
            this.btn_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(832, 31);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 28);
            this.btn_Add.Text = "&Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // side1
            // 
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 28);
            this.btn_Update.Text = "&Cập nhập";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // side2
            // 
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(55, 28);
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.ToolTipText = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // side3
            // 
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(82, 28);
            this.btn_Refresh.Text = "&Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // side4
            // 
            this.side4.Name = "side4";
            this.side4.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(74, 28);
            this.btn_Cancel.Text = "&Hủy bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(79, 28);
            this.btn_close.Text = "Thoát &ra";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QLBH.Properties.Resources.title_form;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 44);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng quát";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(190, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tất cả nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QLBH.Properties.Resources.title_form;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_Mode);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 44);
            this.panel2.TabIndex = 4;
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.lbl_Mode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Mode.Location = new System.Drawing.Point(391, 27);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(49, 13);
            this.lbl_Mode.TabIndex = 9;
            this.lbl_Mode.Text = "Mode :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(336, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(190, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập vào nhân viên";
            // 
            // frmNhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 610);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmNhan_vien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhan_vien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ma_nv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstv_nhan_vien;
        private System.Windows.Forms.ColumnHeader ma_nv;
        private System.Windows.Forms.ColumnHeader dc_nv;
        private System.Windows.Forms.TextBox txt_ht;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader hoten_nv;
        private System.Windows.Forms.ColumnHeader cv_nv;
        private System.Windows.Forms.ColumnHeader phai_nv;
        private System.Windows.Forms.ColumnHeader dt_nv;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader nam_sinh_nv;
        private System.Windows.Forms.ComboBox com_cv;
        private System.Windows.Forms.DateTimePicker date_ns;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox com_phai;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripSeparator side1;
        private System.Windows.Forms.ToolStripButton btn_Update;
        private System.Windows.Forms.ToolStripSeparator side2;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripSeparator side3;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripSeparator side4;
        private System.Windows.Forms.ToolStripButton btn_Cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_close;
    }
}