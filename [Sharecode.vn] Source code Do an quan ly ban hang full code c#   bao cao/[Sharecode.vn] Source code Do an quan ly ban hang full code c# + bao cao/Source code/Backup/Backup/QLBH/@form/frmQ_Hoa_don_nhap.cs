using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmQ_Hoa_don_nhap : Form
    {
        public frmQ_Hoa_don_nhap()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmHoa_don_nhap frm_hdn = new frmHoa_don_nhap();
            frm_hdn.str = "Adding";
            this.Close();
            frm_hdn.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmHoa_don_nhap frm_hdn = new frmHoa_don_nhap();
            frm_hdn.str = "Modifying";
            this.Close();
            frm_hdn.Show();
            
        }
    }
}