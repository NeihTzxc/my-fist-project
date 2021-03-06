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
    public partial class frmChi_tiet_xuat: Form
    {
        ToolTip toolTip1 = null;
        public frmChi_tiet_xuat()
        {
            InitializeComponent();
             toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 300;
            toolTip1.ShowAlways = true;
        }
        public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
        OracleCommand cmdForm = new OracleCommand();
        _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();
        string edit_shd="",edit_ml="",edit_mh="";
        int soluong_cu = 0;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_so_luong.Text = "0";
            txt_don_gia.Text = "0";
            txt_vat.Text = "0";
            txt_mien_giam.Text = "0";
            lstv_Function();
            com_ml.Focus();
            edit_shd = edit_mh=edit_ml="";

        }
        private void lstv_Function()
        {
            clsCon.comboFill(com_ml, "select * from LOAI_HANG", "LOAI_HANG", "MALOAI", "MALOAI");
            clsCon.comboFill(com_mh, "select * from HANG_HOA where MALOAI='"+com_ml.SelectedValue.ToString()+"'", "HANG_HOA", "TENHANG", "MAHANG");
            clsCon.comboFill(com_shdx, "select * from HOA_DON_XUAT", "HOA_DON_XUAT", "SOHDX", "SOHDX");
            clsCon.list_DataView("SELECT CHI_TIET_XUAT.MALOAI, CHI_TIET_XUAT.MAHANG, CHI_TIET_XUAT.SOHDX, CHI_TIET_XUAT.SOLUONG, CHI_TIET_XUAT.DONGIA,"
                      +"CHI_TIET_XUAT.VAT, CHI_TIET_XUAT.TILEMIENGIAM, B.TENHANG, B.DONVITINH, B.TENNHASX, B.GIADENGHI FROM HANG_HOA B INNER JOIN CHI_TIET_XUAT ON B.MALOAI = CHI_TIET_XUAT.MALOAI AND B.MAHANG = CHI_TIET_XUAT.MAHANG order by SOHDX", this.lstv_ctx);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
        }

        private int co_the_xuat(string ml,string mh)
        {
            int sln=0, slx=0;
            try
            {
                clsCon.cmdOpen(cmdForm);
                cmdForm.CommandText = "select sum(SOLUONGN) as sln from CHI_TIET_NHAP where MALOAI='" + ml + "' and MAHANG='" + mh + "'";
                OracleDataReader dr = cmdForm.ExecuteReader();
                while (dr.Read())
                {
                    string strsln = dr["sln"].ToString().Trim();
                    if (strsln == "")
                        sln = 0;
                    else  sln = Convert.ToInt32(strsln);
                }
                cmdForm.CommandText = "select sum(SOLUONG) as slx from CHI_TIET_XUAT where MALOAI='" + ml + "' and MAHANG='" + mh + "'";
                dr = cmdForm.ExecuteReader();
                while (dr.Read())
                {
                    string strslx = dr["slx"].ToString().Trim();
                    if (strslx == "")
                        slx = 0;
                    else slx = Convert.ToInt32(strslx);
                }
                dr.Close();
                clsCon.cn.Close();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
                return sln-slx;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //kiểm tra số lượng xuất phải lớn hơn 0
            if (Convert.ToInt32(txt_so_luong.Text) <= 0)
            {
                clsmyFunction.setMessageBox("Bạn quên nhập số lượng", 1);
                return;
            }
            //kiểm tra có đủ hàng xuất không?
            if ((co_the_xuat(com_ml.Text, com_mh.SelectedValue.ToString())-Convert.ToInt32(txt_so_luong.Text))<0)
            {
                clsmyFunction.setMessageBox("Không đủ loại hàng này để xuất", 1);
                return;
            }
             try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into CHI_TIET_XUAT values (" + com_shdx.Text + ",'" + com_ml.Text + "','" + com_mh.SelectedValue.ToString() + 
                        "'," + txt_so_luong.Text + "," + txt_don_gia.Text + "," + txt_vat.Text + ","+txt_mien_giam.Text+")";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);
                    return ;

                }
                finally
                {
                    clsCon.cn.Close();
                }
                btn_Cancel_Click(sender, e);
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (edit_shd == "" || edit_mh == "" || edit_ml == "")
            {
                clsmyFunction.setCreateError("Chọn một dòng đơn để update!");
                return;
            }
            else
            {
                //kiểm tra số lượng xuất phải lớn hơn 0
                if (Convert.ToInt32(txt_so_luong.Text) <= 0)
                {
                    clsmyFunction.setMessageBox("Bạn quên nhập số lượng", 1);
                    return;
                }
                if ((co_the_xuat(com_ml.Text, com_mh.SelectedValue.ToString()) - Convert.ToInt32(txt_so_luong.Text)+soluong_cu) < 0)
                {
                    clsmyFunction.setMessageBox("Không đủ loại hàng này để xuất", 1);
                    return;
                }
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "update CHI_TIET_XUAT set MALOAI='" + com_ml.Text + "', MAHANG='" + com_mh.SelectedValue.ToString () + "', SOHDX=" + com_shdx.Text + ",SOLUONG=" + txt_so_luong.Text + ",DONGIA=" +
                    txt_don_gia.Text + " ,VAT=" + txt_vat.Text + ",TILEMIENGIAM=" + txt_mien_giam.Text + " where MALOAI='" + edit_ml + "' and MAHANG='" + edit_mh + "' and SOHDX=" + edit_shd;
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Update thành công", 1);
                    btn_Cancel_Click(sender, e);
                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);
                    return;

                }
                finally
                {
                    clsCon.cn.Close();
                }
            }
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((edit_shd == "") || (edit_mh == "") || (edit_ml == ""))
                clsmyFunction.setCreateError("Chọn một dòng đơn để xoá!");
            else
            {
                DialogResult ret;
                ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete from CHI_TIET_XUAT where MALOAI='" + com_ml.Text + "' and MAHANG='" + com_mh.SelectedValue.ToString() + "' and SOHDX=" + com_shdx.Text;
                        clsCon.cmdClose(cmdForm);
                        clsmyFunction.setMessageBox("Xoá thành công", 1);
                        btn_Cancel_Click(sender, e);
                    }
                    catch (Exception exp)
                    {
                        clsmyFunction.setCreateError(exp.Message);
                        return;

                    }
                    finally
                    {
                        clsCon.cn.Close();
                    }
                }
                else
                {
                    btn_Cancel_Click(sender, e);
                }
            }

        }


        private void lstv_ctn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (str == "Adding")
                return;
            edit_ml=lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[0].Text.Trim();
            com_ml.SelectedValue = edit_ml;

            edit_mh=lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[1].Text;
            com_mh.SelectedValue = edit_mh;
            edit_shd=com_shdx.Text = lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[2].Text;
            txt_so_luong.Text = lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[3].Text;
            soluong_cu = Convert.ToInt32(txt_so_luong.Text);
            txt_don_gia.Text=lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[4].Text;
            txt_vat.Text=lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[5].Text;
            txt_mien_giam.Text = lstv_ctx.Items[lstv_ctx.FocusedItem.Index].SubItems[6].Text;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _forms.frmHoa_don_xuat frm_hdx = new _forms.frmHoa_don_xuat();
            frm_hdx.str = "Adding";
           frm_hdx.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            _forms.frmHang_hoa frm_hh = new _forms.frmHang_hoa();
            frm_hh.str = "Adding";
            frm_hh.Show();
        }

        private void frmChi_tiet_xuat_Load(object sender, EventArgs e)
        {
            if (str == "Adding")
            {
                this.lbl_Mode.Text = str;
                btn_Update.Visible = false;
                btn_Delete.Visible = false;
                side2.Visible = false;
                side3.Visible = false;
            }
            else
            {
                if (str == "Modifying")
                {
                    this.lbl_Mode.Text = str;
                    btn_Add.Visible = false;
                    side1.Visible = false;
                }
            }

            lstv_Function();
        }
 
      

        private void com_ml_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCon.comboFill(com_mh, "select * from HANG_HOA where MALOAI='" + com_ml.SelectedValue.ToString  () + "'", "HANG_HOA", "TENHANG", "MAHANG");
        }

        private void txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void txt_don_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }

        }

        private void txt_mien_giam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void txt_mien_giam_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
                if (e.KeyCode == Keys.Enter)
                    this.btn_Add_Click(sender, e);
        }

        private void com_mh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsCon.connCheck();
                OracleCommand cmddr = new OracleCommand("select GIADENGHI as gia from HANG_HOA where MAHANG='" +
                    com_mh.SelectedValue.ToString() + "' and MALOAI='"+com_ml.SelectedValue.ToString()+"'", clsCon.cn);
                OracleDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    txt_don_gia.Text = dr["gia"].ToString();
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

        private void lstv_ctx_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            toolTip1.SetToolTip(lstv_ctx , e.Item.SubItems[7].Text + " DTV:" + e.Item.SubItems[8].Text + " TÊN NSX: " + e.Item.SubItems[9].Text + " Giá đề nghị: " + e.Item.SubItems[10].Text);
        }


      

    }
}