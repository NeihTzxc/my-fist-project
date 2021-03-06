using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLBH._class
{
    class cls_myFunctions
    {
        string sMessageBox = "[Quản lý bán hàng Ver 1.0]";
        public void setMessageBox(string sMessage, int iWhich)
        {
            /****************************************************************************************/
            /*  Tạo thông báo sMessage với loại là iWhich                                           */
            /****************************************************************************************/
            
            switch (iWhich)
            {
                case 1:
                    //Hiển thị thông tin
                    MessageBox.Show(sMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    //Hiển thị thông tin
                    MessageBox.Show(sMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show(sMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void setCreateError(string sErrorMessage)
        {
            try
            {
                MessageBox.Show(sErrorMessage, sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool str_str(string a)
        {
            string num = "0123456789";
            foreach (char z in a)
                if (num.Contains(z.ToString())) return false;
            return true;
        }
        public bool str_num(string a)
        {
            string num = "0123456789";
            foreach (char z in a)
                if (!num.Contains(z.ToString())) return false;
            return true;
        }
    }
}
