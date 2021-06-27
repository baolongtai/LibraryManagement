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
    public partial class frmMain : Form
    {
        frmBook bookForm = new frmBook();
        frmReader readerForm = new frmReader();
        frmBuy buyForm = new frmBuy();
        frmBill billForm = new frmBill();

        public frmMain()
        {
            InitializeComponent();
        }

        public event EventHandler LogOut;
        public bool isShowing = true;

        private void btnBook_Click(object sender, EventArgs e)
        {
            bookForm.TopLevel = false;
            pnlShow.Controls.Add(bookForm);
            bookForm.Visible = true;
            readerForm.Visible = false;
            buyForm.Visible = false;
            billForm.Visible = false;
        }
        private void btnReader_Click(object sender, EventArgs e)
        {
            readerForm.TopLevel = false;
            pnlShow.Controls.Add(readerForm);
            readerForm.Visible = true;
            bookForm.Visible = false;
            buyForm.Visible = false;
            billForm.Visible = false;
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            buyForm.TopLevel = false;
            pnlShow.Controls.Add(buyForm);
            buyForm.Visible = true;
            bookForm.Visible = false;
            readerForm.Visible = false;
            billForm.Visible = false;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            billForm.TopLevel = false;
            pnlShow.Controls.Add(billForm);
            billForm.Visible = true;
            bookForm.Visible = false;
            readerForm.Visible = false;
            buyForm.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult bt = MessageBox.Show("Bạn muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (bt == DialogResult.OK)
                CloseForm();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
                CloseForm();
        }

        void CloseForm()
        {
            if (isShowing)
            {
                isShowing = true;
                Application.Exit();
            }
        }

        private void cbRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRegister.Checked)
            {
                gbRegistered.Visible = false;
                gbUnregistered.Visible = true;
            }
            else
            {
                gbRegistered.Visible = true;
                gbUnregistered.Visible = false;
            }
        }


    }
}
