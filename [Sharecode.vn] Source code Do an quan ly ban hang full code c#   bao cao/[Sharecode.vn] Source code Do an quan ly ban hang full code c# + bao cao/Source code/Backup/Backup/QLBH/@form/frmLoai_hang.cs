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
    public partial class frmLoai_hang : Form
    {
        public frmLoai_hang()
        {
            InitializeComponent();
        }
       public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
       string  edit_ML="";
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.txt_ml.Text = "";
            this.txt_ml_dg.Text = "";
            edit_ML = "";
            lstv_Function();
            this.txt_ml.Focus();

        }
        private void lstv_Function()
        {
            this.clsCon.list_DataView("select * from LOAI_HANG ORDER BY MALOAI ", this.lstv_Loai_hang);
        }
        private void save_Loai_hang()
        {
            if (this.txt_ml.Text.Trim().Length !=2|| !clsmyFunction .str_str( this.txt_ml.Text))
            {
                MessageBox.Show("Mã loại rỗng hoặc chứa ký số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into LOAI_HANG(MALOAI,DIENGIAI) values ('"+this.txt_ml.Text+"','"+ this.txt_ml_dg.Text.Trim()+"')";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            save_Loai_hang();
            lstv_Function();
            this.txt_ml.Text = "";
            this.txt_ml_dg.Text = "";
            txt_ml.Focus();
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (edit_ML == "")
                clsmyFunction.setCreateError("Chọn một mã loại để update!");
            else
            if (this.txt_ml.Text.Trim().Length != 2|| !clsmyFunction.str_str(txt_ml.Text))
            {
                clsmyFunction.setCreateError("Nhập sai quy ước!");
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "update LOAI_HANG set MALOAI='"+txt_ml.Text+"',DIENGIAI='"+txt_ml_dg.Text.Trim()+"' where MALOAI='"+edit_ML+"'";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Update thành công", 1);
                    this.txt_ml.Text = "";
                    txt_ml_dg.Text = "";
                    edit_ML = "";


                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
                lstv_Function();
            }
        }

        

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (edit_ML == "")
                clsmyFunction.setCreateError("Chọn một mã loại để xoá!");
            else
                {
 
                    DialogResult ret;
                    ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {

                        if (this.txt_ml.Text.Trim().Length != 2 || !clsmyFunction.str_str(txt_ml.Text))
                            {
                                clsmyFunction.setCreateError("Nhập sai quy ước!");
                                return;
                            }
                        else
                            {
                                try
                                    {
                                        clsCon.cmdOpen(cmdForm);
                                        cmdForm.CommandText = "delete from LOAI_HANG where MALOAI='"+txt_ml.Text+"'";
                                        clsCon.cmdClose(cmdForm);
                                        clsmyFunction.setMessageBox("Xóa dữ liệu thành công", 1);
                                        this.txt_ml.Text = "";
                                        txt_ml_dg.Text = "";
                                        edit_ML = "";

                                     }
                                 catch (Exception exp)
                                    {
                                        clsmyFunction.setCreateError(exp.Message);

                                     }
                                    finally
                                    {
                                         clsCon.cn.Close();
                                    }
                                lstv_Function();
                                }

                }
            
            else
            {
                btn_Cancel_Click(sender, e);
            }
        }
        
        }


        private void lstv_Loai_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (str == "Adding")
                return;
            edit_ML = this.txt_ml.Text = (this.lstv_Loai_hang.Items[lstv_Loai_hang.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txt_ml_dg.Text = (this.lstv_Loai_hang.Items[lstv_Loai_hang.FocusedItem.Index].SubItems[1].Text.Trim());
        }


        private void txt_ml_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_ml_dg.Focus();
                   
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_ml_dg.Focus();
                }
            }


        }

        private void txt_ml_dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.btn_Add_Click(sender,e);
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
            if (this.txt_ml.Text.Trim().Length != 2 || !clsmyFunction.str_str(txt_ml.Text))
            {
                errorProvider1.SetError(txt_ml, "Sai quy ước");
                txt_ml.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void frmLoai_hang_Load_1(object sender, EventArgs e)
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

        private void txt_ml_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

     

    }
}