using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Khach_hang : Form
    {
        public frmQ_Khach_hang()
        {
            InitializeComponent();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmKhach_hang frm_Khach_hang = new frmKhach_hang();
            frm_Khach_hang.str = "Adding";
            this.Close();
            frm_Khach_hang.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmKhach_hang frm_Khach_hang = new frmKhach_hang();
            frm_Khach_hang.str = "Modifying";
            this.Close();
            frm_Khach_hang.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}