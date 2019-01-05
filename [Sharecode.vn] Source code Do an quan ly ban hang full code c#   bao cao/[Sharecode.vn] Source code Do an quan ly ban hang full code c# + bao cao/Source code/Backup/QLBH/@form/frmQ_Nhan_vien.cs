using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Nhan_vien : Form
    {
        public frmQ_Nhan_vien()
        {
            InitializeComponent();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmNhan_vien frm_Nhan_vien = new frmNhan_vien();
            frm_Nhan_vien.str = "Adding";
            this.Close();
            frm_Nhan_vien.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmNhan_vien frm_nhan_vien = new frmNhan_vien();
            frm_nhan_vien.str = "Modifying";
            this.Close();
            frm_nhan_vien.Show();
            
        }
    }
}