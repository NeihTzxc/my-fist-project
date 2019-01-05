using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Chi_tiet_nhap : Form
    {
        public frmQ_Chi_tiet_nhap()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmChi_tiet_nhap frm_ctn = new frmChi_tiet_nhap();
            frm_ctn.str = "Adding";
            this.Close();
            frm_ctn.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmChi_tiet_nhap frm_ctn = new frmChi_tiet_nhap();
            frm_ctn.str = "Modifying";
            this.Close();
            frm_ctn.Show();
            
        }
    }
}