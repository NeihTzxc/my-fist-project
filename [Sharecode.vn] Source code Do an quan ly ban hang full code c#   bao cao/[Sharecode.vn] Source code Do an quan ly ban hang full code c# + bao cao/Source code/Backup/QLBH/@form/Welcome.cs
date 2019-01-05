using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace QLBH._forms
{
    public partial class Welcome : Form
    {
        DataSet table=new DataSet();
        _class.clsORACEL cls_ORACEL = new QLBH._class.clsORACEL();
        public Welcome()
        {
            InitializeComponent();
        }
        int z;     //Variable for Progressbar Value
       
        private void Welcome_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            try
            {
                if (cls_ORACEL.cn.State == ConnectionState.Open)
                {
                    cls_ORACEL.cn.Close();
                }
                cls_ORACEL.cn.Open();
                OracleDataAdapter da = new OracleDataAdapter("select usr from user_", cls_ORACEL.cn);
                da.Fill(table,"user_");
                cls_ORACEL.cn.Close();
                cls_ORACEL.cn.Dispose();
            }

            catch (Exception exp)
            {
                MessageBox.Show("Please run file setting for new database or start oracle XE");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 2;
            if (z > 100)
            {
                this.Hide();
                this.timer1.Enabled = false;
                frm_login frmlogin = new frm_login(table);
                frmlogin.Show();
                     return;
            }
            this.progressBar1.Value = z;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        }

        
    }
