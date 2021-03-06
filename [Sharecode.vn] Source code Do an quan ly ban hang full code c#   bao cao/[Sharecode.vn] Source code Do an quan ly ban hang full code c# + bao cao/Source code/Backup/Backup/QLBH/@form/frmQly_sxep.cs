using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient ;
namespace QLBH._forms
{
    public partial class frmQly_sxep : Form
    {
        public frmQly_sxep()
        {
            InitializeComponent();
        }
       public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
       _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void frmQly_sxep_Load(object sender, EventArgs e)
        {
            clsCon.dataGridFill("select * from NHAN_VIEN", grid_nv, "NHAN_VIEN");
            grid_nv.Columns[0].HeaderText = "Mã nhân viên";
            grid_nv.Columns[1].HeaderText = "Họ tên nhân viên";
            grid_nv.Columns[2].HeaderText = "Địa chỉ";
            grid_nv.Columns[3].HeaderText = "Chức vụ";
            grid_nv.Columns[4].HeaderText = "Phái";
            grid_nv.Columns[5].HeaderText = "Số điện thoại";
            grid_nv.Columns[6].HeaderText = "Năm sinh";

            clsCon.dataGridFill("select * from KHACH_HANG", grid_kh, "KHACH_HANG");
            grid_kh.Columns[0].HeaderText = "Mã khách hàng";
            grid_kh.Columns[1].HeaderText = "Tên khách hàng";
            grid_kh.Columns[2].HeaderText = "Địa chỉ";
            grid_kh.Columns[3].HeaderText = "Số điện thoại";

            clsCon.dataGridFill("select * from LOAI_HANG", grid_lh, "LOAI_HANG");
            grid_lh.Columns[0].HeaderText = "Mã loại";
            grid_lh.Columns[1].HeaderText = "Diễn giải";

            clsCon.dataGridFill("select * from HANG_HOA", grid_hh, "HANG_HOA");
            grid_hh.Columns[0].HeaderText = "Mã loại";
            grid_hh.Columns[1].HeaderText = "Mã hàng";
            grid_hh.Columns[2].HeaderText = "Tên hàng";
            grid_hh.Columns[3].HeaderText = "Đơn vị tính";
            grid_hh.Columns[4].HeaderText = "Tên nhà sản xuất";
            grid_hh.Columns[5].HeaderText = "Giá đề nghị";

            clsCon.dataGridFill("select * from NHA_CUNG_CAP", grid_ncc, "NHA_CUNG_CAP");
            grid_ncc.Columns[0].HeaderText = "Mã nhà cung cấp";
            grid_ncc.Columns[1].HeaderText = "Tên nhà cung cấp";
            grid_ncc.Columns[2].HeaderText = "Địa chỉ";
            grid_ncc.Columns[3].HeaderText = "Số điện thoại";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_print_nv_Click(object sender, EventArgs e)
        {
            Report.ds_nv rp_nv = new QLBH.Report.ds_nv();
            rp_nv.SetDataSource(grid_nv.DataSource);
            QLBH._forms.frm_report frm_rp_nv = new QLBH._forms.frm_report();
            frm_rp_nv.Text = "In danh sách nhân viên";
            frm_rp_nv.ReportViewer1.ReportSource = rp_nv;
            frm_rp_nv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report.ds_kh rp_kh = new QLBH.Report.ds_kh();
            rp_kh.SetDataSource(grid_kh.DataSource);
            QLBH._forms.frm_report frm_rp_kh = new QLBH._forms.frm_report();
            frm_rp_kh.Text = "In danh sách khách hàng";
            frm_rp_kh.ReportViewer1.ReportSource = rp_kh;
            frm_rp_kh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report.ds_lh rp_lh = new QLBH.Report.ds_lh();
            rp_lh.SetDataSource(grid_lh.DataSource);
            QLBH._forms.frm_report frm_rp_lh = new QLBH._forms.frm_report();
            frm_rp_lh.Text = "In danh sách loại hàng";
            frm_rp_lh.ReportViewer1.ReportSource = rp_lh;
            frm_rp_lh.Show();
        }

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report.ds_hh rp_hh = new QLBH.Report.ds_hh();
            rp_hh.SetDataSource(grid_hh.DataSource);
            QLBH._forms.frm_report frm_rp_hh = new QLBH._forms.frm_report();
            frm_rp_hh.Text = "In danh sách hàng hóa";
            frm_rp_hh.ReportViewer1.ReportSource = rp_hh;
            frm_rp_hh.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report.ds_ncc rp_ncc= new QLBH.Report.ds_ncc();
            rp_ncc.SetDataSource(grid_ncc.DataSource);
            QLBH._forms.frm_report frm_rp_ncc = new QLBH._forms.frm_report();
            frm_rp_ncc.Text = "In danh sách nhà cung cấp";
            frm_rp_ncc.ReportViewer1.ReportSource = rp_ncc;
            frm_rp_ncc.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

      
        
       
       
      

 
      

       
       

    }
}