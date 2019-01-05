using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;

namespace QLBH._class
{
	class clsORACEL
	{

        /*================================================================
          * ***************************************************************/
        OracleCommand cmdStock = new OracleCommand();
        OracleDataAdapter daStock;
        /*================================================================
         * **************************************************************/
        public OracleConnection cn = new OracleConnection(@"Data Source=xe;Persist Security Info=True;User ID=QLBH;Password=qlbh;Unicode=True");
        
        public void connCheck()
        {
            try
            {
                if (cn.State == ConnectionState.Open) 
                {
                    cn.Close();
                }
                cn.Open();


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
        public void dataGridFill(string strQry, DataGridView dGV, string strTable)
        {
            try
            {
                connCheck();
                DataSet ds = new DataSet();
                ds.Clear();
                daStock = new OracleDataAdapter(strQry, cn);
                daStock.Fill(ds, strTable);
                dGV.DataSource = ds.Tables[strTable];
                cn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }

        }
        public void cmdOpen(OracleCommand cmdFunction)
        {
            connCheck();
            cmdFunction.Connection = cn;
        }
        public void cmdClose(OracleCommand cmdFunction)
        {

            cmdFunction.ExecuteNonQuery();
            cmdFunction.Parameters.Clear();
            cmdFunction.Connection.Close();
            //cn.Close();
        }
        public void comboFill(ComboBox cmb, string strSQL, string dTable, string dDisplay, string dValue)
        {
            try
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter(strSQL, cn);
                da.Fill(ds, dTable);
                cmb.DataSource = ds.Tables[dTable];
                cmb.DisplayMember = dDisplay;
                cmb.ValueMember = dValue;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        public void list_DataView(string strSQL, ListView myList)
        {
            myList.Items.Clear();
            try
            {
                OracleCommand cmd = new OracleCommand(strSQL, cn);
                cn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lItem = new ListViewItem(dr[0].ToString());
                    for (int i = 1; i <= dr.FieldCount - 1; i++)
                    {
                        lItem.SubItems.Add(dr[i].ToString());
                    }
                    myList.Items.Add(lItem);
                    int rCount = myList.Items.Count;
                    if (rCount % 2 == 1)
                    {
                        //lItem.BackColor = System.Drawing.Color.WhiteSmoke;
                        lItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(189)))));
                    }
                    else
                    {
                        lItem.BackColor = System.Drawing.Color.White;
                    }
                }
                cn.Close();
                cmd.Dispose();
                dr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        public void get_table(string strQry,DataTable dt)
        {
            try
            {
                connCheck();
                DataSet ds = new DataSet();
                ds.Clear();
                //cmdStock = new OracleCommand();
                daStock = new OracleDataAdapter(strQry, cn);
                daStock.Fill(dt);
                cn.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }

        }
        //public void textClear(Form frm)
        //{
        //    foreach (Control ctl in frm.Controls)
        //    {
        //        if (ctl is TextBox)
        //            ctl.Text = "";
        //    }
        //}



	}
}
