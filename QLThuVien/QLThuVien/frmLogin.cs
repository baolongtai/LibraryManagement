using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string id = "admin";
        string password = "123";

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (LogIn(txbID.Text, txbPassword.Text))
            {
                frmMain mainForm = new frmMain();
                mainForm.Show();
                mainForm.LogOut += mainForm_LogOut;
                ClearBox();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Tài khoản đăng nhập hoặc mật khẩu không khớp xin vui lòng đăng nhâp lại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void mainForm_LogOut(object sender, EventArgs e)
        {
            (sender as frmMain).isShowing = false;
            (sender as frmMain).Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult bt = MessageBox.Show("Bạn muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (bt == DialogResult.OK)
            Application.Exit();
        }
        void ClearBox() 
        {
            //txbID.Clear();
            //txbPassword.Clear();
            foreach (var item1 in this.Controls)
            {
                TextBox item = item1 as TextBox;
                if (item != null)
                {
                    item.Clear();
                }
            }
            txbID.Focus();
        }

        bool LogIn(string id, string password) {
            if (id == this.id && password == this.password)
            {
                return true;
            }
            return false; 
        }

    }
}
