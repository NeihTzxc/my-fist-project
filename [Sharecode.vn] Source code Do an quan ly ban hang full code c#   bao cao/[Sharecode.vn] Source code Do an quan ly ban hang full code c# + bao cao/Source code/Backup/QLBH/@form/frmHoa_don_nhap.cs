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
    public partial class frmHoa_don_nhap: Form
    {
        ToolTip toolTip1 = null;
        public frmHoa_don_nhap()
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
        string shd="";
        string edit_shd="";

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            com_ma_ncc.SelectedItem = com_ma_ncc.Items[0];
            com_ma_nv.SelectedItem = com_ma_nv.Items[0];
            date_nhap.Value = DateTime.Now.Date;
            txt_thanh_tien.Text = "";
            lstv_Function();
            com_ma_ncc.Focus();
            edit_shd = "";

        }
        private void lstv_Function()
        {
            clsCon.comboFill(com_ma_ncc, "select * from NHA_CUNG_CAP ", "NHA_CUNG_CAP", "TENNCC", "MANCC");
            clsCon.comboFill(com_ma_nv, "select * from NHAN_VIEN", "NHAN_VIEN", "HOTENNV", "MANV");
            clsCon.list_DataView("SELECT     HOA_DON_NHAP.SOHDN, HOA_DON_NHAP.MANCC, HOA_DON_NHAP.MANV, HOA_DON_NHAP.NGAYNHAP, HOA_DON_NHAP.THANHTIENNHAP, NHAN_VIEN.HOTENNV, NHAN_VIEN.CHUCVU, NHA_CUNG_CAP.TENNCC,"
            +"NHA_CUNG_CAP.SODT_NCC FROM HOA_DON_NHAP INNER JOIN NHAN_VIEN ON HOA_DON_NHAP.MANV = NHAN_VIEN.MANV INNER JOIN NHA_CUNG_CAP ON HOA_DON_NHAP.MANCC = NHA_CUNG_CAP.MANCC order by SOHDN", this.lstv_hdn);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
        }

        private void sohoadon()
        {
            try
            {

                int myID;
                clsCon.connCheck();
                OracleCommand cmddr = new OracleCommand("select max(SOHDN) as id from HOA_DON_NHAP", clsCon.cn);
                OracleDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["id"].ToString();
                    if (strid == "")
                    {
                        shd = "1";
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["id"]) + 1;
                        shd = myID.ToString();
                    }

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            sohoadon();
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into HOA_DON_NHAP values (" + shd + ",'" + com_ma_ncc.SelectedValue.ToString() + "','" + com_ma_nv.SelectedValue.ToString() +
                        "',TO_DATE('"+date_nhap.Value.Date.ToShortDateString()+ "','MM-DD-YYYY'),"+txt_thanh_tien.Text+")";
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
            if (edit_shd == "")
                clsmyFunction.setCreateError("Chọn một hoá đơn để update!");
            else
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "update HOA_DON_NHAP set SOHDN=" + edit_shd + ", MANCC='" + com_ma_ncc.SelectedValue.ToString()+ "', MANV='" + com_ma_nv.SelectedValue.ToString() + "', NGAYNHAP=TO_DATE('" + date_nhap.Value.Date.ToShortDateString() + "','MM-DD-YYYY'),THANHTIENNHAP=" + txt_thanh_tien.Text + " where SOHDN="+edit_shd;
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



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (edit_shd == "")
                clsmyFunction.setCreateError("Chọn một hoá đơn để xoá!");
            else
            {
                DialogResult ret;
                ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete from HOA_DON_NHAP where SOHDN=" + edit_shd;
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


        private void lstv_Loai_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (str == "Adding")
                return;
            edit_shd = lstv_hdn.Items[lstv_hdn.FocusedItem.Index].SubItems[0].Text.Trim();
            com_ma_ncc.SelectedValue  = lstv_hdn.Items[lstv_hdn.FocusedItem.Index].SubItems[1].Text;
            com_ma_nv.SelectedValue = lstv_hdn.Items[lstv_hdn.FocusedItem.Index].SubItems[2].Text;
            date_nhap.Value = Convert.ToDateTime(lstv_hdn.Items[lstv_hdn.FocusedItem.Index].SubItems[3].Text);
            txt_thanh_tien.Text = lstv_hdn.Items[lstv_hdn.FocusedItem.Index].SubItems[4].Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _forms.frmNha_cung_cap frm_ncc = new _forms.frmNha_cung_cap();
            frm_ncc.str = "Adding";
           frm_ncc.Show();
        }



       

        private void frmHoa_don_nhap_Load(object sender, EventArgs e)
        {
            date_nhap.Format = DateTimePickerFormat.Custom;
            date_nhap.CustomFormat = "dd-MM-yyyy";
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

        private void txt_thanh_tien_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
                if (e.KeyCode == Keys.Enter)
                    this.btn_Add_Click(sender, e);

        }

        private void txt_thanh_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }

        private void lstv_hdn_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            toolTip1.SetToolTip(lstv_hdn, e.Item.SubItems[6].Text +"  "+e.Item.SubItems[5].Text + "   Nhà cung cấp: " + e.Item.SubItems[7].Text + "   SĐT: " + e.Item.SubItems[8].Text);
        }

       
    }
}