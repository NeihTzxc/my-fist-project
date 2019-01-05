using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Hoa_don_xuat : Form
    {
        public frmQ_Hoa_don_xuat()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmHoa_don_xuat frm_hdx = new frmHoa_don_xuat();
            frm_hdx.str = "Adding";
            this.Close();
            frm_hdx.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmHoa_don_xuat frm_hdx = new frmHoa_don_xuat();
            frm_hdx.str = "Modifying";
            this.Close();
            frm_hdx.Show();
            
        }
    }
}