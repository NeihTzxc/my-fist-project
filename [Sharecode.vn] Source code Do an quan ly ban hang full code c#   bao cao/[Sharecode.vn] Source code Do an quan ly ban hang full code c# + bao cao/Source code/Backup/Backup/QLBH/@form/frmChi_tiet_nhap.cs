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
    public partial class frmChi_tiet_nhap: Form
    {
        ToolTip toolTip1=null;
        public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
        _class.clsORACEL clsCon;
        OracleCommand cmdForm;
        _class.cls_myFunctions clsmyFunction;
        string edit_shd = "", edit_ml = "", edit_mh = "";

        public frmChi_tiet_nhap()
        {
            InitializeComponent();

            ///////////////////////////////////////////////////////
            clsCon = new QLBH._class.clsORACEL();
            clsmyFunction = new QLBH._class.cls_myFunctions();
            cmdForm = new OracleCommand();
            toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 300;
            toolTip1.ShowAlways = true;
            
        }
       
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_so_luong.Text = "";
            txt_don_gia.Text = "";
            txt_hsd.Text = "";
            date_nsx.Value = DateTime.Now.Date;
            lstv_Function();
            com_ml.Focus();
            edit_shd = edit_mh=edit_ml="";

        }
        private void lstv_Function()
        {
            
            clsCon.comboFill(com_ml, "select * from LOAI_HANG", "LOAI_HANG", "MALOAI", "MALOAI");
            clsCon.comboFill(com_mh, "select * from HANG_HOA where MALOAI='"+com_ml.Text+"'", "HANG_HOA", "TENHANG", "MAHANG");
            clsCon.comboFill(com_shdn, "select * from HOA_DON_NHAP", "HOA_DON_NHAP", "SOHDN", "SOHDN");
            clsCon.list_DataView("SELECT     CHI_TIET_NHAP.MALOAI, CHI_TIET_NHAP.MAHANG, CHI_TIET_NHAP.SOHDN, CHI_TIET_NHAP.SOLUONGN, CHI_TIET_NHAP.DONGIAN,"+ 
                      "CHI_TIET_NHAP.HANSUDUNG, CHI_TIET_NHAP.NGAYSX, B.TENHANG, B.DONVITINH, B.TENNHASX, B.GIADENGHI FROM HANG_HOA B INNER JOIN CHI_TIET_NHAP ON B.MALOAI = CHI_TIET_NHAP.MALOAI AND B.MAHANG = CHI_TIET_NHAP.MAHANG order by SOHDN", this.lstv_ctn);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into CHI_TIET_NHAP values ('" + com_ml.Text + "','" + com_mh.SelectedValue.ToString() + "'," + com_shdn.Text +
                        "," + txt_so_luong.Text + "," + txt_don_gia.Text + "," + txt_hsd.Text + ",TO_DATE('"+date_nsx.Value.Date.ToShortDateString()+ "','MM-DD-YYYY'))";
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
                clsmyFunction.setCreateError("Chọn một dòng đơn để update!");
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "update CHI_TIET_NHAP set MALOAI='" + com_ml.Text + "', MAHANG='" + com_mh.SelectedValue.ToString() + "', SOHDN=" + com_shdn.Text + ",SOLUONGN=" + txt_so_luong.Text + ",DONGIAN=" +
                    txt_don_gia.Text + " ,HANSUDUNG=" + txt_hsd.Text + ",NGAYSX=TO_DATE('" + date_nsx.Value.Date.ToShortDateString() + "','MM-DD-YYYY') where MALOAI='" + edit_ml + "' and MAHANG='" + edit_mh + "' and SOHDN=" + edit_shd;
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
                        cmdForm.CommandText = "delete from CHI_TIET_NHAP where MALOAI='" + com_ml.Text + "' and MAHANG='" + com_mh.SelectedValue.ToString()+ "' and SOHDN=" + com_shdn.Text;
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
            edit_ml=com_ml.Text = lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[0].Text.Trim();
            edit_mh = lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[1].Text ;
            com_mh.SelectedValue = lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[1].Text ;
            edit_shd=com_shdn.Text = lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[2].Text;
            txt_so_luong.Text = lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[3].Text;
            txt_don_gia.Text=lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[4].Text;
            txt_hsd.Text=lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[5].Text;
            date_nsx.Value = Convert.ToDateTime(lstv_ctn.Items[lstv_ctn.FocusedItem.Index].SubItems[6].Text);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _forms.frmHoa_don_nhap frm_hdn = new _forms.frmHoa_don_nhap();
            frm_hdn.str = "Adding";
           frm_hdn.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            _forms.frmHang_hoa frm_hh = new _forms.frmHang_hoa();
            frm_hh.str = "Adding";
            frm_hh.Show();
        }

        private void frmChi_tiet_nhap_Load(object sender, EventArgs e)
        {
            date_nsx.Format = DateTimePickerFormat.Custom;
            date_nsx.CustomFormat = "dd-MM-yyyy";
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
            clsCon.comboFill(com_mh, "select * from HANG_HOA where MALOAI='" + com_ml.Text + "'", "HANG_HOA", "TENHANG", "MAHANG");
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

        private void txt_hsd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void date_nsx_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
                if (e.KeyCode == Keys.Enter)
                    this.btn_Add_Click(sender, e);
        }


        private void lstv_ctn_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void lstv_ctn_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            toolTip1.SetToolTip(lstv_ctn , e.Item.SubItems[7].Text + " DTV:" + e.Item.SubItems[8].Text + " TÊN NSX: " + e.Item.SubItems[9].Text + " Giá đề nghị: " + e.Item.SubItems[10].Text);
        }




    }
}