using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace QLBH._forms
{
    public partial class MDIParent : Form
    {
        string abc = "";
        _class.clsORACEL cls_ORACEL = new QLBH._class.clsORACEL();
        public MDIParent(string abc)
        {
            InitializeComponent();
            if (abc.ToLower() != "admin") 
            {
                btn_backup.Enabled = false;
                btn_restore.Enabled = false;
                btn_change_pass.Enabled = false;
            }
            this.abc = abc;
        }
        _class.cLsImageList cLsImage_List = new QLBH._class.cLsImageList();
        
        private void MDIParent_Load(object sender, EventArgs e)
        {
           
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Loại hàng", 0, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Nhà cung cấp",2, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Khách hàng",3, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Hàng hóa",15, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Hoá đơn nhập", 14, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Hoá đơn xuất", 17, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Chi tiết xuất", 18, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Chi tiết nhập", 19, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Quản lý sắp xếp",20, i64x64);

            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "Nhân viên", 12, this.i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "Khách hàng", 12, this.i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "Loại hàng", 12, this.i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "Hàng hóa", 12, this.i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "Nhà cung cấp", 12, this.i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "In hóa đơn nhập",12, this.i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts2, "In hóa đơn xuất", 12, this.i64x64);
            Item_hhoa_het_han();
            if (abc.ToLower() != "admin")
                return;
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Nhân viên", 1, i64x64);
            QLBH._class.cLsImageList.SetListView(lvShortcuts, "Thống kê", 21, i64x64);


        }
        private void Item_hhoa_het_han()
        {
            cls_ORACEL.connCheck();
            OracleCommand cmd = new OracleCommand("select * from chi_tiet_nhap where ((ngaysx + hansudung) < to_date(sysdate))and hansudung<>0 ", cls_ORACEL.cn);
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
                QLBH._class.cLsImageList.SetListView(lvShortcuts2, "Danh sách hàng hóa hết hạn", 12, i64x64);
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            cls_ORACEL.cn.Close();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("Bạn đang muốn thoát ra!", "OK".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void lvShortcuts_DoubleClick(object sender, EventArgs e)
        {
            switch (lvShortcuts.Items[lvShortcuts.FocusedItem.Index].SubItems[0].Text)
            {
                case "Loại hàng":
                    frmQ_Loai_hang frm_Q_Lh = new frmQ_Loai_hang();
                    frm_Q_Lh.Show();
                    break;
                case "Nhân viên":
                    frmQ_Nhan_vien frm_Q_NV = new frmQ_Nhan_vien();
                    frm_Q_NV.Show();
                    break;
                case "Nhà cung cấp":
                    frmQ_Nha_cung_cap frm_Q_NCC = new frmQ_Nha_cung_cap();
                    frm_Q_NCC.Show();
                    break;
                case "Khách hàng":
                    frmQ_Khach_hang frm_kh = new frmQ_Khach_hang();
                    frm_kh.Show();
                    break;
                case "Hàng hóa":
                    frmQ_Hang__hoa frm_Q_hh = new frmQ_Hang__hoa();
                    frm_Q_hh.Show();
                    break;
                case "Hoá đơn nhập":
                    frmQ_Hoa_don_nhap frm_Q_hdn = new frmQ_Hoa_don_nhap();
                    frm_Q_hdn.Show();
                    break;
                case "Hoá đơn xuất":
                    frmQ_Hoa_don_xuat frm_Q_hdx = new frmQ_Hoa_don_xuat();
                    frm_Q_hdx.Show();
                    break;
                case "Chi tiết nhập":
                    frmQ_Chi_tiet_nhap frm_Q_ctn = new frmQ_Chi_tiet_nhap();
                    frm_Q_ctn.Show();
                    break;
                case "Chi tiết xuất":
                    frmQ_Chi_tiet_xuat frm_Q_ctx = new frmQ_Chi_tiet_xuat();
                    frm_Q_ctx.Show();
                    break;
                case "Quản lý sắp xếp":
                    frmQly_sxep frm_Qlsxep = new frmQly_sxep();
                    frm_Qlsxep.Show();
                    break;
                case "Thống kê":
                    frmThong_ke frm_tk = new frmThong_ke();
                    frm_tk.Show();
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (panel4.Height >= 380)
            {
                panel4.Height = 30;
                panel5.Height = panel6.Height = 27;
            }
            else
            {
                panel4.Height = 380;
                panel5.Height = panel6.Height = 377;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
	       
            System.Diagnostics.Process.Start(Environment.SystemDirectory+"\\calc.exe");
        }

        private void lvShortcuts2_DoubleClick(object sender, EventArgs e)
        {
            switch (lvShortcuts2.Items[lvShortcuts2.FocusedItem.Index].SubItems[0].Text)
            {
                case "Nhân viên":
                    {
                        Report.ds_nv rp_nv = new QLBH.Report.ds_nv();
                        QLBH._class.clsORACEL con = new QLBH._class.clsORACEL();
                        OracleDataAdapter daStock = new OracleDataAdapter("select * from NHAN_VIEN", con.cn);
                        DataTable dt = new DataTable();
                        daStock.Fill(dt);
                        rp_nv.SetDataSource(dt);
                        QLBH._forms.frm_report frm_rp_nv = new QLBH._forms.frm_report();
                        frm_rp_nv.Text = "In danh sách nhân viên";
                        frm_rp_nv.ReportViewer1.ReportSource = rp_nv;
                        frm_rp_nv.Show();
                    }
                    break;
                case "Khách hàng":
                    {
                        Report.ds_kh rp_kh = new QLBH.Report.ds_kh();
                        QLBH._class.clsORACEL con = new QLBH._class.clsORACEL();
                        OracleDataAdapter daStock = new OracleDataAdapter("select * from KHACH_HANG", con.cn);
                        DataTable dt = new DataTable();
                        daStock.Fill(dt);
                        rp_kh.SetDataSource(dt);
                        QLBH._forms.frm_report frm_rp_kh = new QLBH._forms.frm_report();
                        frm_rp_kh.Text = "In danh sách khách hàng";
                        frm_rp_kh.ReportViewer1.ReportSource = rp_kh;
                        frm_rp_kh.Show();
                    }
                    break;
                case "Loại hàng":
                    {
                        Report.ds_lh rp_lh = new QLBH.Report.ds_lh();
                        QLBH._class.clsORACEL con = new QLBH._class.clsORACEL();
                        OracleDataAdapter daStock = new OracleDataAdapter("select * from LOAI_HANG", con.cn);
                        DataTable dt = new DataTable();
                        daStock.Fill(dt);
                        rp_lh.SetDataSource(dt);
                        QLBH._forms.frm_report frm_rp_lh = new QLBH._forms.frm_report();
                        frm_rp_lh.Text = "In danh sách loại hàng";
                        frm_rp_lh.ReportViewer1.ReportSource = rp_lh;
                        frm_rp_lh.Show();
                    }
                    break;
                case "Hàng hóa":
                    {
                        Report.ds_hh rp_hh = new QLBH.Report.ds_hh();
                        QLBH._class.clsORACEL con = new QLBH._class.clsORACEL();
                        OracleDataAdapter daStock = new OracleDataAdapter("select * from HANG_HOA", con.cn);
                        DataTable dt = new DataTable();
                        daStock.Fill(dt);
                        rp_hh.SetDataSource(dt);
                        QLBH._forms.frm_report frm_rp_hh = new QLBH._forms.frm_report();
                        frm_rp_hh.Text = "In danh sách hàng hóa";
                        frm_rp_hh.ReportViewer1.ReportSource = rp_hh;
                        frm_rp_hh.Show();
                    }
                    break;
                case "Nhà cung cấp":
                    {
                        Report.ds_ncc rp_ncc = new QLBH.Report.ds_ncc();
                        QLBH._class.clsORACEL con = new QLBH._class.clsORACEL();
                        OracleDataAdapter daStock = new OracleDataAdapter("select * from NHA_CUNG_CAP", con.cn);
                        DataTable dt = new DataTable();
                        daStock.Fill(dt);
                        rp_ncc.SetDataSource(dt);
                        QLBH._forms.frm_report frm_rp_ncc = new QLBH._forms.frm_report();
                        frm_rp_ncc.Text = "In danh sách nhà cung cấp";
                        frm_rp_ncc.ReportViewer1.ReportSource = rp_ncc;
                        frm_rp_ncc.Show();
                    }
                    break;
                case "Danh sách hàng hóa hết hạn":
                    {
                        Report.ds_hh_het_han rp_hh_het_han = new QLBH.Report.ds_hh_het_han();
                        QLBH._class.clsORACEL con = new QLBH._class.clsORACEL();
                        
                        Data.DataSet_in_hoa_don_nhap dt = new Data.DataSet_in_hoa_don_nhap();
                        cls_ORACEL.get_table("select * from chi_tiet_nhap where ((ngaysx + hansudung) < to_date(sysdate))and hansudung<>0", dt.CHI_TIET_NHAP);
                        cls_ORACEL.get_table("select * from Hang_hoa", dt.HANG_HOA );
                        rp_hh_het_han.SetDataSource(dt);
                        QLBH._forms.frm_report frm_rp_hh_het_han = new QLBH._forms.frm_report();
                        frm_rp_hh_het_han.Text = "In danh sách hàng hóa hết hạn";
                        frm_rp_hh_het_han.ReportViewer1.ReportSource = rp_hh_het_han;
                        frm_rp_hh_het_han.Show();
                    }
                    break;
                case "In hóa đơn nhập":
                    {
                        frmIn_hoa_don_n frm_in_hdn = new frmIn_hoa_don_n();
                        frm_in_hdn.Show();
                    }
                    break;
                case "In hóa đơn xuất":
                    {
                        frmIn_hoa_don_x frm_in_hdx = new frmIn_hoa_don_x();
                        frm_in_hdx.Show();
                    }
                    break;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            SaveFileDialog FileDialog = new SaveFileDialog();
            FileDialog.InitialDirectory = Environment.CurrentDirectory;
            FileDialog.Filter = "dump files (*.dmp)|*.dmp";
            FileDialog.FilterIndex = 1;
            FileDialog.RestoreDirectory = true;
            FileDialog.Title = "Backup database";
            FileDialog.FileName=DateTime.Now.ToShortDateString().Replace('/','-');

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string backup = "qlbh/qlbh@xe file=" + FileDialog.FileName;
                    

                    string str=Environment.GetEnvironmentVariable("path");
                    string[] s = str.Split(';');

                    foreach (string i in s)
                    {
                        if (i.Contains("oracle") & i.Contains("server\\bin"))
                           System.Diagnostics.Process.Start(i+"\\exp", backup);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.InitialDirectory = Environment.CurrentDirectory;
            FileDialog.Filter = "dump files (*.dmp)|*.dmp";
            FileDialog.FilterIndex = 1;
            FileDialog.RestoreDirectory = true;
            FileDialog.Title = "Backup database";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
               MessageBox.Show("Chương trình sẽ tự động tắt để tiến hàng việc phục hồi dữ liệu");
               System.Diagnostics.Process.Start("Restore.exe",FileDialog.FileName); 
               Application.Exit();
            }
        }

        private void btn_change_pass_Click(object sender, EventArgs e)
        {
            frmChange_pass pass = new frmChange_pass();
            pass.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLBH._forms.frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ctu.edu.vn");
        }


      

        }
    }
