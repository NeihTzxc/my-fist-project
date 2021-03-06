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
    public partial class frmIn_hoa_don_x : Form
    {
        public frmIn_hoa_don_x()
        {
            InitializeComponent();
        }
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();


        private void frmLoai_hang_Load_1(object sender, EventArgs e)
        {
            clsCon.comboFill(com_so_hd, "select SOHDX from hoa_don_xuat", "SO_HD", "SOHDX", "SOHDX");
        }

        private void com_so_hd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(com_so_hd.Text);
            }
            catch (Exception ex)
            {
                return;
            }
            clsCon.dataGridFill("SELECT     CHI_TIET_XUAT.MALOAI, CHI_TIET_XUAT.MAHANG, CHI_TIET_XUAT.SOLUONG, CHI_TIET_XUAT.DONGIA, CHI_TIET_XUAT.VAT, "
                      +"CHI_TIET_XUAT.TILEMIENGIAM, HANG_HOA.TENHANG FROM         HANG_HOA INNER JOIN  CHI_TIET_XUAT ON HANG_HOA.MALOAI = CHI_TIET_XUAT.MALOAI AND HANG_HOA.MAHANG = CHI_TIET_XUAT.MAHANG"
                    +" WHERE     (CHI_TIET_XUAT.SOHDX ="+com_so_hd.Text +")", grid_in_hd, "in_hd");
            grid_in_hd.Columns[0].HeaderText = "Mã loại";
            grid_in_hd.Columns[1].HeaderText = "Mã hàng";
            grid_in_hd.Columns[2].HeaderText = "Số lượng";
            grid_in_hd.Columns[3].HeaderText = "Đơn giá";
            grid_in_hd.Columns[4].HeaderText = "VAT";
            grid_in_hd.Columns[5].HeaderText = "Tỉ lệ giảm";
            grid_in_hd.Columns[6].HeaderText = "Tên hàng";
            grid_in_hd.Columns[6].DisplayIndex = 2;
            
             try
            {

                clsCon.connCheck();
                OracleCommand cmddr = new OracleCommand("select sum(soluong*dongia+ soluong*dongia*(vat/100)- soluong*dongia*tilemiengiam/100) as tt from chi_tiet_xuat where sohdx=" + com_so_hd.Text, clsCon.cn);
                OracleDataReader dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    txt_tong_tien.Text = dr["tt"].ToString();
                }
                cmddr.CommandText = "select manv as manv,MAKH as mkh,NGAYXUAT as ngayxuat from hoa_don_xuat where SOHDX=" + com_so_hd.Text;
                dr = cmddr.ExecuteReader();
                 while (dr.Read())
                {
                    txt_mnv.Text = dr["manv"].ToString();
                    txt_mkh.Text = dr["mkh"].ToString();
                    txt_ngay_lap.Text = DateTime.Parse(dr["ngayxuat"].ToString()).ToShortDateString();
                }
                cmddr.CommandText = "select hotennv as tennv from nhan_vien where manv='" + txt_mnv.Text+"'";
                dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    txt_nhvien.Text = dr["tennv"].ToString();
                    
                }
                cmddr.CommandText = "select TENKH as tenkh from  khach_hang where MAKH='" + txt_mkh.Text + "'";
                dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    
                    txt_kh.Text = dr["tenkh"].ToString();

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
            QLBH.Report.in_hoa_don_x hdx = new QLBH.Report.in_hoa_don_x();
            QLBH.Data.DataSet_in_hoa_don_xuat  dt = new Data.DataSet_in_hoa_don_xuat ();

            clsCon.get_table("SELECT CHI_TIET_XUAT.* FROM HANG_HOA INNER JOIN CHI_TIET_XUAT ON HANG_HOA.MALOAI = CHI_TIET_XUAT.MALOAI AND HANG_HOA.MAHANG = CHI_TIET_XUAT.MAHANG"
            +" WHERE  (CHI_TIET_XUAT.SOHDX ="+com_so_hd.Text +")", dt.CHI_TIET_XUAT);
            clsCon.get_table("SELECT  * FROM    HANG_HOA", dt.HANG_HOA);
            hdx.SetDataSource(dt);
            QLBH._forms.frm_report frm_hdx = new QLBH._forms.frm_report();

            ParameterValues myparameterValues = new ParameterValues();
            ParameterDiscreteValue myparamDiscreteValue = new ParameterDiscreteValue();

            myparamDiscreteValue.Value = com_so_hd.Text;
            myparameterValues.Add(myparamDiscreteValue);
            hdx.DataDefinition.ParameterFields["sohoadon"].ApplyCurrentValues(myparameterValues);

            myparamDiscreteValue.Value = txt_ngay_lap.Text;
            hdx.DataDefinition.ParameterFields["ngayxuat"].ApplyCurrentValues(myparameterValues);
            myparamDiscreteValue.Value = txt_nhvien.Text;
            hdx.DataDefinition.ParameterFields["nhanvien"].ApplyCurrentValues(myparameterValues);
            myparamDiscreteValue.Value = txt_kh.Text;
            hdx.DataDefinition.ParameterFields["khach_hang"].ApplyCurrentValues(myparameterValues);
            myparamDiscreteValue.Value = txt_tong_tien.Text;
            hdx.DataDefinition.ParameterFields["tong_tien"].ApplyCurrentValues(myparameterValues);


            frm_hdx.Text = "In hóa đơn xuất";
            frm_hdx.ReportViewer1.ReportSource = hdx;
            frm_hdx.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       



       

    }
}