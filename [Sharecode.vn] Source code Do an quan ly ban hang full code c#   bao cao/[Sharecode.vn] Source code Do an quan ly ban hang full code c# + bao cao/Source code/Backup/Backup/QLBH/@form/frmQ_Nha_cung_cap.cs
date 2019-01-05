using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Nha_cung_cap : Form
    {
        public frmQ_Nha_cung_cap()
        {
            InitializeComponent();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmNha_cung_cap frm_Nha_cung_cap = new frmNha_cung_cap();
            frm_Nha_cung_cap.str = "Adding";
            this.Close();
            frm_Nha_cung_cap.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmNha_cung_cap frm_nha_cung_cap = new frmNha_cung_cap();
            frm_nha_cung_cap.str = "Modifying";
            this.Close();
            frm_nha_cung_cap.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}