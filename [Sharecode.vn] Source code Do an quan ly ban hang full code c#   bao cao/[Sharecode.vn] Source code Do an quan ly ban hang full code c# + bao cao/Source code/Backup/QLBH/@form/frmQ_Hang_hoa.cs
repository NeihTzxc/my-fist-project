using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Hang__hoa : Form
    {
        public frmQ_Hang__hoa()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmHang_hoa frm_hh = new frmHang_hoa();
            frm_hh.str="Adding";
            this.Close();        
            frm_hh.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmHang_hoa frm_hh = new frmHang_hoa();
            frm_hh.str="Modifying";
            this.Close();
            frm_hh.Show();
            
        }
    }
}