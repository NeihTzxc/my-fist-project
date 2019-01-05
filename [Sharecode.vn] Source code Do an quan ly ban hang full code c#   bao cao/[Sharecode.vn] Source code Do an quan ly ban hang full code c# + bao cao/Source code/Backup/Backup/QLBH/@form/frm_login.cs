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
    public partial class frm_login : Form
    {
        public frm_login(DataSet tb)
        {
            InitializeComponent();
            com_uName.DataSource = tb.Tables["user_"] ;
            this.com_uName.DisplayMember = "usr";
            this.com_uName.ValueMember = "usr";
        }
       
        _class.clsORACEL cls_ORACEL = new QLBH._class.clsORACEL();
        
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.com_uName.Focus();
            index_Load();
        }
       
        private void index_Load()
        {
            this.com_uName.TabIndex = 0;
            this.txtPass.TabIndex = 1;
            this.btn_Login.TabIndex = 2;
            this.btn_cancel.TabIndex = 3;
        }

private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmdlogin = new OracleCommand("select * from user_ where usr='" + this.com_uName.SelectedValue + "' and pass='" + this.txtPass.Text.Trim() + "'", this.cls_ORACEL.cn);
                if (cls_ORACEL.cn.State == ConnectionState.Open)
                {
                    cls_ORACEL.cn.Close();
                }
                cls_ORACEL.cn.Open();
                OracleDataReader drpassword = cmdlogin.ExecuteReader();
                if (drpassword.Read())
                {
                    cls_ORACEL.cn.Close();
                    cls_ORACEL.cn.Dispose();
                    drpassword.Close();
                    cmdlogin.Dispose();
                    _forms.MDIParent mdi_Parent = new MDIParent(com_uName.Text);           //Main window
                    this.Dispose(true);
                    mdi_Parent.Show();
                }
                else
                {
                    MessageBox.Show("User Name or Password is no Valid ", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message );
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_Login_Click(sender, e);
        }

      
    }
    }
