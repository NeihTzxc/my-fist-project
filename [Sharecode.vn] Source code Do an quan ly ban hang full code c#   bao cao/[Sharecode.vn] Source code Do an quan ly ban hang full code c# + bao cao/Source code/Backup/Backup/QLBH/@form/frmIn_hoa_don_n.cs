using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient ;
using CrystalDecisions.Shared;
namespace QLBH._forms
{
    public partial class frmIn_hoa_don_n : Form
    {
        ToolTip toolTip1 = null;
        public frmIn_hoa_don_n()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 300;
            toolTip1.ShowAlways = true;
        }
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();


        private void frmLoai_hang_Load_1(object sender, EventArgs e)
        {
            clsCon.comboFill(com_so_hd, "select sohdn from hoa_don_nhap", "SO_HD", "SOHDN", "SOHDN");
        }

        private void com_so_hd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(com_so_hd.Text);
            }
            catch (Exception )
            {
                return;
            }
            clsCon.dataGridFill("SELECT CHI_TIET_NHAP.MALOAI, CHI_TIET_NHAP.MAHANG, CHI_TIET_NHAP.SOLUONGN, CHI_TIET_NHAP.DONGIAN, CHI_TIET_NHAP.HANSUDUNG, CHI_TIET_NHAP.NGAYSX, HANG_HOA.TENHANG"
            +" FROM CHI_TIET_NHAP INNER JOIN  HANG_HOA ON CHI_TIET_NHAP.MALOAI = HANG_HOA.MALOAI AND CHI_TIET_NHAP.MAHANG = HANG_HOA.MAHANG WHERE     (CHI_TIET_NHAP.SOHDN ="+com_so_hd.Text +") ORDER BY CHI_TIET_NHAP.DONGIAN",grid_in_hd,"in_hd");
            grid_in_hd.Columns[0].HeaderText = "Mã loại";
            grid_in_hd.Columns[1].HeaderText = "Mã hàng";
            grid_in_hd.Columns[2].HeaderText = "Số lượng";
            grid_in_hd.Columns[3].HeaderText = "Đơn giá";
            grid_in_hd.Columns[4].HeaderText = "Hạn sử dụng";
            grid_in_hd.Columns[5].HeaderText = "Ngày sản xuất";
            grid_in_hd.Columns[6].HeaderText = "Tên hàng";
            grid_in_hd.Columns[6].DisplayIndex = 2;
             try
            {

                clsCon.connCheck();
                OracleCommand cmddr = new OracleCommand("select sum(dongian* soluongn) as tt from chi_tiet_nhap where sohdn="+com_so_hd.Text, clsCon.cn);
                OracleDataReader dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    txt_tong_tien.Text = dr["tt"].ToString();
                }
                cmddr.CommandText = "select manv as manv,mancc as mncc,ngaynhap as ngaynhap from hoa_don_nhap where SOHDN=" + com_so_hd.Text;
                dr = cmddr.ExecuteReader();
                 while (dr.Read())
                {
                    txt_mnv.Text = dr["manv"].ToString();
                    txt_mncc.Text = dr["mncc"].ToString();
                    txt_ngay_lap.Text = DateTime.Parse(dr["ngaynhap"].ToString()).ToShortDateString();
               
                }
                cmddr.CommandText = "select hotennv as tennv from nhan_vien where manv='" + txt_mnv.Text+"'";
                dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    txt_nhvien.Text = dr["tennv"].ToString();
                    
                }
                cmddr.CommandText = "select tenncc as tenncc from  nha_cung_cap where mancc='"+ txt_mncc.Text+"'";
                dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    
                    txt_ncc.Text = dr["tenncc"].ToString();

                }
            
                 dr.Close();
                clsCon.cn.Close();
                cmddr.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void txt_tong_tien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Report.in_hoa_don_n hdn = new QLBH.Report.in_hoa_don_n();
            QLBH.Data.DataSet_in_hoa_don_nhap  dt = new Data.DataSet_in_hoa_don_nhap ();
            clsCon.get_table("SELECT     MALOAI, MAHANG, SOHDN, SOLUONGN, DONGIAN, HANSUDUNG, NGAYSX"
            + " FROM         CHI_TIET_NHAP WHERE     (SOHDN = " +com_so_hd.Text+")", dt.CHI_TIET_NHAP);
            clsCon.get_table("SELECT  * FROM    HANG_HOA", dt.HANG_HOA );
            //dt.CHI_TIET_NHAP.g
            
            hdn.SetDataSource(dt);
          
            ParameterValues myparameterValues = new ParameterValues();
            ParameterDiscreteValue myparamDiscreteValue = new ParameterDiscreteValue();
            
            myparamDiscreteValue.Value = com_so_hd.Text;
            myparameterValues.Add(myparamDiscreteValue);
            hdn.DataDefinition.ParameterFields["sohoadon"].ApplyCurrentValues(myparameterValues);

            myparamDiscreteValue.Value = txt_ngay_lap.Text;
            hdn.DataDefinition.ParameterFields["ngaynhap"].ApplyCurrentValues(myparameterValues);
            myparamDiscreteValue.Value = txt_nhvien.Text;
            hdn.DataDefinition.ParameterFields["nhanvien"].ApplyCurrentValues(myparameterValues);
            myparamDiscreteValue.Value = txt_ncc.Text;
            hdn.DataDefinition.ParameterFields["nha_cc"].ApplyCurrentValues(myparameterValues);
            myparamDiscreteValue.Value = txt_tong_tien.Text;
            hdn.DataDefinition.ParameterFields["tong_tien"].ApplyCurrentValues(myparameterValues); 
  

            QLBH._forms.frm_report frm_hdn = new QLBH._forms.frm_report();
            frm_hdn.Text = "In hóa đơn nhập";
            frm_hdn.ReportViewer1.ReportSource = hdn;
            frm_hdn.Show();
        }

        private void grid_in_hd_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       



       

    }
}