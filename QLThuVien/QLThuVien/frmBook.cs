using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLThuVien
{
    public partial class frmBook : Form
    {

        ConnectionString cnn = new ConnectionString();

        public frmBook()
        {
            InitializeComponent();
        }

        public void LoadDBBooks()
        {
            dgvBook.DataSource = cnn.LoadData("SELECT * FROM BOOKS");
        }
        
        public void LoadDBType()
        {
            dgvTypeBook.DataSource = cnn.LoadData("SELECT TYPE_BOOK_ID, TYPE_BOOK_NAME FROM TYPE_BOOK");
        }
        public void LoadDBAuthor()
        {
            dgvAuthor.DataSource = cnn.LoadData("SELECT AUTHOR_ID, AUTHOR_NAME FROM AUTHOR");
        }
        public void LoadDPublisher()
        {
            dgvPulisher.DataSource = cnn.LoadData("SELECT PUBLISHER_ID, PUBLISHER_NAME FROM PUBLISHER");
        }

        public void SearchBookByKeyWord()
        {
            dgvBook.DataSource = cnn.LoadData("SELECT * FROM BOOKS WHERE BOOK_NAME LIKE '%" + txbKeyWord.Text + "%'");
        }
        public void SearchTypeBookByKeyWord()
        {
            dgvTypeBook.DataSource = cnn.LoadData("SELECT * FROM TYPE_BOOK WHERE TYPE_BOOK_NAME LIKE '%" + txbCategoryName.Text + "%'");
        }
        public void SearchAuthorByKeyWord()
        {
            dgvAuthor.DataSource = cnn.LoadData("SELECT * FROM AUTHOR WHERE AUTHOR_NAME LIKE '%" + txbAuthorName.Text + "%'");
        }
        public void SearchPublisherByKeyWord()
        {
            dgvPulisher.DataSource = cnn.LoadData("SELECT * FROM PUBLISHER WHERE PUBLISHER_NAME LIKE '%" + txbPublisherName.Text + "%'");
        }
        
        private void frmBook_Load(object sender, EventArgs e)
        {
            LoadDBType();
            LoadDBAuthor();
            LoadDPublisher();
            LoadDBBooks();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            //tctReader.Visible = true;
            if (cbShow.Checked)
            {
                tctBook.Visible = false;
            }
            else
            {
                tctBook.Visible = true;
            }
        }
        
        int i;
        private void dgvTypeBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbCategoryID.ReadOnly = true;
                i = dgvTypeBook.CurrentRow.Index;
                txbCategoryID.Text = dgvTypeBook.Rows[i].Cells[0].Value.ToString();
                txbTypeBookID_2.Text = dgvTypeBook.Rows[i].Cells[0].Value.ToString();
                txbCategoryName.Text = dgvTypeBook.Rows[i].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Datagridview Type Book");
            }
        }
        private void dgvPulisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbPublisherID.ReadOnly = true;
                i = dgvPulisher.CurrentRow.Index;
                txbPublisherID.Text = dgvPulisher.Rows[i].Cells[0].Value.ToString();
                txbPublisherID_2.Text = dgvPulisher.Rows[i].Cells[0].Value.ToString();
                txbPublisherName.Text = dgvPulisher.Rows[i].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Datagridview Publisher");
            }
        }

        private void dvgAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbAuthorID.ReadOnly = true;
                i = dgvAuthor.CurrentRow.Index;
                txbAuthorID.Text = dgvAuthor.Rows[i].Cells[0].Value.ToString();
                txbAuthorID_2.Text = dgvAuthor.Rows[i].Cells[0].Value.ToString();
                txbAuthorName.Text = dgvAuthor.Rows[i].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Datagridview Author");
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbBookID.ReadOnly = true;
                i = dgvBook.CurrentRow.Index;
                txbBookID.Text = dgvBook.Rows[i].Cells[0].Value.ToString();
                txbBookName.Text = dgvBook.Rows[i].Cells[1].Value.ToString();
                nmudQuantity.Text = dgvBook.Rows[i].Cells[2].Value.ToString();
                txbUnitPrice.Text = dgvBook.Rows[i].Cells[3].Value.ToString();
                txbTypeBookID_2.Text = dgvBook.Rows[i].Cells[4].Value.ToString();
                txbAuthorID_2.Text = dgvBook.Rows[i].Cells[5].Value.ToString();
                txbPublisherID_2.Text = dgvBook.Rows[i].Cells[6].Value.ToString();
                dtpPublishingYear.Text = dgvBook.Rows[i].Cells[7].Value.ToString();
                dtpDataReceipt.Text = dgvBook.Rows[i].Cells[8].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Datagridview Book");
            }

        }
        // BOOK FORM --- DANH MỤC SÁCH ---
        // Lỗi FK
        // FIX hoàn tất 2:30 AM - 27/06
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try{
                cnn.LoadData("INSERT INTO BOOKS(BOOK_ID, BOOK_NAME, QUANTITY, UNIT_PRICE, TYPE_BOOK_ID, AUTHOR_ID, PUBLISHER_ID, PUBLISHING_YEAR, DATE_RECEIPT) VALUES('" + txbBookID.Text + "', '" + txbBookName.Text + "', '" + nmudQuantity.Text + "', '" + txbUnitPrice.Text + "', '" + txbTypeBookID_2.Text + "', '" + txbAuthorID_2.Text + "', '" + txbPublisherID_2.Text + "', '" + dtpPublishingYear.Text + "', '" + dtpDataReceipt.Text + "')");
                LoadDBBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show ("","Ero");
            }
            ResetControlValues();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try {
                cnn.LoadData("DELETE FROM BOOKS WHERE BOOK_ID = '" + txbBookID.Text + "'");
                LoadDBBooks();
                txbBookID.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("","Ero");
            }
            ResetControlValues();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            try{
                cnn.LoadData("UPDATE BOOKS SET  BOOK_NAME = '" + txbBookName.Text + "', QUANTITY = '" + nmudQuantity.Text + "', UNIT_PRICE = '" + txbUnitPrice.Text + "', TYPE_BOOK_ID = '" + txbTypeBookID_2.Text + "', AUTHOR_ID = '" + txbAuthorID_2.Text + "', PUBLISHER_ID = '" + txbPublisherID_2.Text + "', PUBLISHING_YEAR = '" + dtpPublishingYear.Text + "', DATE_RECEIPT = '" + dtpDataReceipt.Text + "' WHERE BOOK_ID ='"+ txbBookID +"' ");
                LoadDBBooks();
                txbBookID.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show ("","Ero");
            }
            ResetControlValues();
        }

        //đang kiểm tra

        void ResetControlValues()
        {
            txbBookID.Clear();
            txbBookName.Clear();
            nmudQuantity.ResetText();
            txbUnitPrice.Clear();
            txbTypeBookID_2.Clear();
            txbAuthorID_2.Clear();
            txbPublisherID_2.Clear();
            dtpPublishingYear = null;
            dtpDataReceipt = null;

            txbCategoryID.Clear();
            txbCategoryName.Clear();
            txbAuthorID.Clear();
            txbAuthorName.Clear();
            txbPublisherID.Clear();
            txbPublisherName.Clear();

            txbBookID.Focus();
        }

        //tapControl --- TYPE BOOK ---
        //tìm hiểu lỗi --- thiếu .Text
        //hoàn tất fix 3:34 PM - 27/06
        private void btnAddType_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("INSERT INTO TYPE_BOOK SET (TYPE_BOOK_ID, TYPE_BOOK_NAME) VALUES ('" + txbCategoryID.Text + "', '" + txbCategoryName.Text + "')");
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show ("","Ero");
            }
            ResetControlValues();
        }
        private void btnRepairType_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("UPDATE TYPE_BOOK SET TYPE_BOOK_NAME = '" + txbCategoryName.Text + "' WHERE TYPE_BOOK_ID = '" + txbCategoryID.Text + "'");
                txbCategoryID.ReadOnly = false;
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("DELETE FROM TYPE_BOOK WHERE TYPE_BOOK_ID = '" + txbCategoryID.Text + "'");
                txbCategoryID.ReadOnly = false;
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            SearchTypeBookByKeyWord();
        }

        // --- AUTHOR --
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("INSERT INTO AUTHOR SET (AUTHOR_ID, AUTHOR_NAME) VALUES ('" + txbAuthorID.Text + "', '" + txbAuthorName.Text + "')");
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnRepairAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("UPDATE AUTHOR SET AUTHOR_NAME = '" + txbAuthorName.Text + "' WHERE AUTHOR_ID = '" + txbAuthorID.Text + "'");
                txbAuthorID.ReadOnly = false;
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("DELETE FROM AUTHOR WHERE AUTHOR_ID = '" + txbAuthorID.Text + "'");
                txbAuthorID.ReadOnly = false;
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            SearchAuthorByKeyWord();
        }

        // --- PUBLISHER ---
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData(@"INSERT INTO PUBLISHER SET (PUBLISHER_ID, PUBLISHER_NAME) VALUES ('" + txbPublisherID.Text + "', '" + txbPublisherName.Text + "')");
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnRepairPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("UPDATE PUBLISHER SET PUBLISHER_NAME = '" + txbPublisherName.Text + "' WHERE PUBLISHER_ID = '" + txbPublisherName.Text + "'");
                txbPublisherID.ReadOnly = false;
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.OpenConnect();
                cnn.LoadData("DELETE FROM PUBLISHER WHERE PUBLISHER_ID = '" + txbPublisherID.Text + "'");
                txbPublisherID.ReadOnly = false;
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ero");
            }
            ResetControlValues();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBookByKeyWord();
        }

        private void txbKeyWord_TextChanged(object sender, EventArgs e)
        {
            SearchBookByKeyWord();
        }

        private void frmBook_Click(object sender, EventArgs e)
        {
            txbBookID.ReadOnly = false;
            txbAuthorID.ReadOnly = false;
            txbPublisherID.ReadOnly = false;
            txbCategoryID.ReadOnly = false;
        }

        private void tctBook_Click(object sender, EventArgs e)
        {
            txbAuthorID.ReadOnly = false;
            txbPublisherID.ReadOnly = false;
            txbCategoryID.ReadOnly = false;
        }

    
    }
}
