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
    public partial class frmNhan_vien : Form
    {
        public frmNhan_vien()
        {
            InitializeComponent();
        }
       public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
       string  edit_MA_NV="";
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
       _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.txt_ma_nv.Text = "";
            this.txt_ht.Text = "";
            date_ns.Value = DateTime.Now.AddYears(-20);
            com_phai.SelectedItem = com_phai.Items[0];
            txt_dc.Text = "";
            com_cv.SelectedItem = com_cv.Items[0];
            txt_dt.Text = "";
            edit_MA_NV = "";
            lstv_nv_Function();
            this.txt_ma_nv.Focus();

        }
        private void lstv_nv_Function()
        {
            this.clsCon.list_DataView("select * from NHAN_VIEN ORDER BY MANV", this.lstv_nhan_vien);

        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            lstv_nv_Function();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            if (this.txt_ma_nv.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã nhân viên rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "INSERT INTO NHAN_VIEN (MANV,HOTENNV,DIACHINV, CHUCVU, PHAI, SODT_NV, NAM_SINH)" +
                    "VALUES ('" + txt_ma_nv.Text + "', '" + txt_ht.Text.Trim() + "', '" + txt_dc.Text.Trim() + "','" +
                    com_cv.Text.Trim() + "', '" + com_phai.Text.Trim() +
                    "', '" + txt_dt.Text.Trim() + "', TO_DATE('" + date_ns.Value.Date.ToShortDateString() + "', 'MM-DD-YYYY'))";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

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
            lstv_nv_Function();
            this.txt_ma_nv.Text = "";
            this.txt_ht.Text = "";
            date_ns.Value = DateTime.Now.AddYears(-20);
            com_phai.SelectedItem = com_phai.Items[0];
            txt_dc.Text = "";
            com_cv.SelectedItem = com_cv.Items[0];
            txt_dt.Text = "";
            txt_ma_nv.Focus();
        }


        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (edit_MA_NV == "")
                clsmyFunction.setCreateError("Chọn một mã nhân viên để update!");
            else
            if (this.txt_ma_nv.Text.Trim().Length != 5)
            {
                clsmyFunction.setCreateError("Nhập sai quy ước!");
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "UPDATE NHAN_VIEN SET MANV='" + txt_ma_nv.Text + "', HOTENNV='" + txt_ht.Text.Trim() +
                    "', DIACHINV='" + txt_dc.Text.Trim() + "', CHUCVU='" + com_cv.Text.Trim() + "', PHAI='" + com_phai.Text.Trim()+
                    "', SODT_NV='" + txt_dt.Text.Trim() + "', NAM_SINH = TO_DATE('" + date_ns.Value.Date.ToShortDateString() + "', 'MM-DD-YYYY') WHERE MANV='" + edit_MA_NV + "'";

                    
                    clsCon.cmdClose(cmdForm);
                    
                    clsmyFunction.setMessageBox("Update thành công", 1);
                    this.txt_ma_nv.Text = "";
                    this.txt_ht.Text = "";
                    date_ns.Value = DateTime.Now.AddYears(-20);
                    com_phai.SelectedItem = com_phai.Items[0];
                    txt_dc.Text = "";
                    com_cv.SelectedItem = com_cv.Items[0];
                    txt_dt.Text = "";
                    edit_MA_NV= "";


                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
                lstv_nv_Function();
            }
        }

        

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (edit_MA_NV == "")
                clsmyFunction.setCreateError("Chọn một mã loại để xoá!");
            else
                {
 
                    DialogResult ret;
                    ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {

                        if (this.txt_ma_nv.Text.Trim().Length != 5 )
                            {
                                clsmyFunction.setCreateError("Nhập sai quy ước!");
                                return;
                            }
                        else
                            {
                                try
                                    {
                                        clsCon.cmdOpen(cmdForm);
                                        cmdForm.CommandText = "delete from NHAN_VIEN where MANV='"+txt_ma_nv.Text+"'";
                                        clsCon.cmdClose(cmdForm);
                                        clsmyFunction.setMessageBox("Xóa dữ liệu thành công", 1);
                                        this.txt_ma_nv.Text = "";
                                        this.txt_ht.Text = "";
                                        date_ns.Value = DateTime.Now.AddYears(-20);
                                        com_phai.SelectedItem = com_phai.Items[0];
                                        txt_dc.Text = "";
                                        com_cv.SelectedItem = com_cv.Items[0];
                                        txt_dt.Text = "";
                                        edit_MA_NV = "";

                                     }
                                 catch (Exception exp)
                                    {
                                        clsmyFunction.setCreateError(exp.Message);

                                     }
                                    finally
                                    {
                                         clsCon.cn.Close();
                                    }
                                lstv_nv_Function();
                                }

                }
            
            else
            {
                btn_Cancel_Click_1(sender, e);
            }
        }
        
        }


      

        private void txt_ml_dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.btn_Add_Click_1(sender,e);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void txt_ml_Leave(object sender, EventArgs e)
        {
            if (this.txt_ma_nv.Text.Trim().Length != 5 )
            {
                errorProvider1.SetError(txt_ma_nv, "Sai quy ước");
                txt_ma_nv.Focus();
            }
            else
                errorProvider1.Clear();
        }

        /*
         Mã xử lý chỉ cho nhập số tại textbox số đt
         */
        private void txt_dt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }
        /*
        Mã xử lý chỉ cho nhập số tại textbox số mã nhân viên
        */
        private void txt_ma_nv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }

        private void frmNhan_vien_Load(object sender, EventArgs e)
        {
            date_ns.Format = DateTimePickerFormat.Custom;
            date_ns.CustomFormat = "dd-MM-yyyy";

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
            com_cv.SelectedValue = com_cv.Items[0];
            com_phai.SelectedValue = com_phai.Items[0];
            lstv_nv_Function();
        }

        private void lstv_nhan_vien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (str == "Adding")
                return;
            edit_MA_NV = this.txt_ma_nv.Text = (this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txt_ht.Text = (this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[1].Text.Trim());
            txt_dc.Text = (this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[2].Text.Trim());
            com_cv.Text = (this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[3].Text.Trim());
            com_phai.Text = (this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[4].Text.Trim());
            txt_dt.Text = (this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[5].Text.Trim());
            date_ns.Value = Convert.ToDateTime((this.lstv_nhan_vien.Items[lstv_nhan_vien.FocusedItem.Index].SubItems[6].Text));
        }

        private void com_phai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       

       

        

        
       
    }
}