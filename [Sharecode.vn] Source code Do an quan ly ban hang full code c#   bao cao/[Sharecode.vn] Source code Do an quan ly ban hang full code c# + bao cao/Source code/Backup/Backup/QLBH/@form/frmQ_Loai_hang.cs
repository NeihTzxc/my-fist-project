using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Loai_hang : Form
    {
        public frmQ_Loai_hang()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmLoai_hang frm_loai_hang = new frmLoai_hang();
            frm_loai_hang.str="Adding";
            this.Close();        
            frm_loai_hang.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmLoai_hang frm_loai_hang = new frmLoai_hang();
            frm_loai_hang.str="Modifying";
            this.Close();
            frm_loai_hang.Show();
            
        }
    }
}