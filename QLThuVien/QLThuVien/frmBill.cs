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
    public partial class frmBill : Form
    {
        ConnectionString cnn = new ConnectionString();
        public frmBill()
        {
            InitializeComponent();
        }
        public void LoadDBBills()
        {
            dgvBill.DataSource = cnn.LoadData("SELECT * FROM BILLS");
        }
        public void LoadDBStudent()
        {
            dgvBill.DataSource = cnn.LoadData("SELECT * FROM STUDENT");
        }
        public void SearchBillByKeyWord()
        {
            dgvBill.DataSource = cnn.LoadData("SELECT * FROM STUDENT WHERE STUDENT_NAME LIKE '%" + txbKeyWord.Text + "%'");
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            LoadDBBills();


        }



        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            //tctReader.Visible = true;
            if (cbShow.Checked)
            {
                dgvBill.Visible = false;
            }
            else
            {
                dgvBill.Visible = true;
            }
        }

        int i;





        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbBillID.ReadOnly = true;
                i = dgvBill.CurrentRow.Index;
                txbBillID.Text = dgvBill.Rows[i].Cells[0].Value.ToString();
                txbStudentID.Text = dgvBill.Rows[i].Cells[1].Value.ToString();
                txbKeyWord.Text = dgvBill.Rows[i].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Datagridview Bill");
            }

        }
        // BOOK FORM --- DANH MỤC SÁCH ---
        // Lỗi FK
        // FIX hoàn tất 2:30 AM - 27/06


        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn.LoadData("DELETE FROM BILLS WHERE BILL_ID = '" + txbBillID.Text + "'");
            LoadDBBills();
            txbBillID.ReadOnly = false;
            ResetControlValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            cnn.LoadData("UPDATE BOOKS SET  BILL_ID = '" + txbBillID.Text + "', STUDENT_ID = '" + txbStudentID.Text + "', STUDENT_NAME = '" + txbKeyWord.Text + "' WHERE BIll_ID ='" + txbBillID + "' ");
            LoadDBBills();
            txbBillID.ReadOnly = false;
            ResetControlValues();
        }

        //đang kiểm tra

        void ResetControlValues()
        {
            txbBillID.Clear();
            txbStudentID.Clear();
            txbKeyWord.Clear();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBillByKeyWord();
        }

        private void txbKeyWord_TextChanged(object sender, EventArgs e)
        {
            SearchBillByKeyWord();
        }

        private void frmBill_Click(object sender, EventArgs e)
        {
            txbBillID.ReadOnly = false;
            txbStudentID.ReadOnly = false;

        }
    }
}
