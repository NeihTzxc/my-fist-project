using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Chi_tiet_xuat : Form
    {
        public frmQ_Chi_tiet_xuat()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmChi_tiet_xuat frm_ctx = new frmChi_tiet_xuat ();
            frm_ctx.str = "Adding";
            this.Close();
            frm_ctx.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmChi_tiet_xuat frm_ctx = new frmChi_tiet_xuat();
            frm_ctx.str = "Modifying";
            this.Close();
            frm_ctx.Show();
            
        }
    }
}