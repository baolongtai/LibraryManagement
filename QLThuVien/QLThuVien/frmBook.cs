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
        SqlConnection sqlConn;
        SqlCommand sqlComm;
        SqlCommand sqlCommType;
        SqlCommand sqlCommAuthor;
        SqlCommand sqlCommPulisher;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataTable dtTbBooks = new DataTable();
        DataTable dtTbType = new DataTable();
        DataTable dtTbAuthor = new DataTable();
        DataTable dtTbPublisher = new DataTable();
        
        public frmBook()
        {
            InitializeComponent();
        }

        public SqlConnection OpenConnect() {
            sqlConn = new SqlConnection(ConnectionString.str);
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            return sqlConn;
        }
        public SqlConnection CloseConnect()
        {
            sqlConn = new SqlConnection(ConnectionString.str);
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();
            return sqlConn;
        }
        public void LoadDBBooks()
        {
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = "SELECT * FROM BOOKS";
            sqlAdapter.SelectCommand = sqlComm;
            dtTbBooks.Clear();
            sqlAdapter.Fill(dtTbBooks);
            dgvBook.DataSource = dtTbBooks;
        }
        public void LoadDBType()
        {
            sqlCommType = sqlConn.CreateCommand();
            sqlCommType.CommandText = "SELECT TYPE_BOOK_ID, TYPE_BOOK_NAME FROM TYPE_BOOK";
            dtTbType.Clear();
            sqlAdapter.SelectCommand = sqlCommType;
            sqlAdapter.Fill(dtTbType);
            dgvTypeBook.DataSource = dtTbType;
        }
        public void LoadDBAuthor()
        {
            sqlCommAuthor = sqlConn.CreateCommand();
            sqlCommAuthor.CommandText = "SELECT AUTHOR_ID, AUTHOR_NAME FROM AUTHOR";
            dtTbAuthor.Clear();
            sqlAdapter.SelectCommand = sqlCommAuthor;
            sqlAdapter.Fill(dtTbAuthor);
            dgvAuthor.DataSource = dtTbAuthor;
        }
        public void LoadDPublisher()
        {
            sqlCommPulisher = sqlConn.CreateCommand();
            sqlCommPulisher.CommandText = "SELECT PUBLISHER_ID, PUBLISHER_NAME FROM PUBLISHER";
            sqlAdapter.SelectCommand = sqlCommPulisher;
            dtTbPublisher.Clear();
            sqlAdapter.Fill(dtTbPublisher);
            dgvPulisher.DataSource = dtTbPublisher;
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            OpenConnect();
            LoadDBBooks();
            LoadDBType();
            LoadDBAuthor();
            LoadDPublisher();
            CloseConnect();
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
            txbCategoryID.ReadOnly = true;
            i = dgvTypeBook.CurrentRow.Index;
            txbCategoryID.Text = dgvTypeBook.Rows[i].Cells[0].Value.ToString();
            txbTypeBookID_2.Text = dgvTypeBook.Rows[i].Cells[0].Value.ToString();
            txbCategoryName.Text = dgvTypeBook.Rows[i].Cells[1].Value.ToString();
        }
        private void dgvPulisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbPublisherID.ReadOnly = true;
            i = dgvPulisher.CurrentRow.Index;
            txbPublisherID.Text = dgvPulisher.Rows[i].Cells[0].Value.ToString();
            txbPublisherID_2.Text = dgvPulisher.Rows[i].Cells[0].Value.ToString();
            txbPublisherName.Text = dgvPulisher.Rows[i].Cells[1].Value.ToString();
        }

        private void dvgAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbAuthorID.ReadOnly = true;
            i = dgvAuthor.CurrentRow.Index;
            txbAuthorID.Text = dgvAuthor.Rows[i].Cells[0].Value.ToString();
            txbAuthorID_2.Text = dgvAuthor.Rows[i].Cells[0].Value.ToString();
            txbAuthorName.Text = dgvAuthor.Rows[i].Cells[1].Value.ToString();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        // BOOK FORM --- DANH MỤC SÁCH ---
        // Lỗi FK
        // FIX hoàn tất 2:30 AM - 27/06
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText =
                    @"INSERT INTO BOOKS
                        (BOOK_ID, BOOK_NAME, QUANTITY, UNIT_PRICE, TYPE_BOOK_ID, AUTHOR_ID, PUBLISHER_ID, PUBLISHING_YEAR, DATE_RECEIPT) 
                    VALUES
                        ('" + txbBookID.Text + "', '" + txbBookName.Text + "', '" + nmudQuantity.Text + "', '" + txbUnitPrice.Text + "', '" + txbTypeBookID_2.Text + "', '" + txbAuthorID_2.Text + "', '" + txbPublisherID_2.Text + "', '" + dtpPublishingYear.Text + "', '" + dtpDataReceipt.Text + "')";
                sqlComm.ExecuteNonQuery();
                LoadDBBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "DELETE FROM BOOKS WHERE BOOK_ID = '" + txbBookID.Text +"'";
                sqlComm.ExecuteNonQuery();
                LoadDBBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "UPDATE BOOKS SET  BOOK_NAME = '" + txbBookName.Text + "', QUANTITY = '" + nmudQuantity.Text + "', UNIT_PRICE = '" + txbUnitPrice.Text + "', TYPE_BOOK_ID = '" + txbTypeBookID_2.Text + "', AUTHOR_ID = '" + txbAuthorID_2.Text + "', PUBLISHER_ID = '" + txbPublisherID_2.Text + "', PUBLISHING_YEAR = '" + dtpPublishingYear.Text + "', DATE_RECEIPT = '" + dtpDataReceipt.Text + "' WHERE BOOK_ID ='"+ txbBookID +"' ";
                sqlComm.ExecuteNonQuery();
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
            txbBookID.ReadOnly = false;
        }

        //đang kiểm tra
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

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
            OpenConnect();
            try
            {
                sqlCommType = sqlConn.CreateCommand();
                sqlCommType.CommandText =
                    @"INSERT INTO 
                        TYPE_BOOK SET (TYPE_BOOK_ID, TYPE_BOOK_NAME) 
                            VALUES ('" + txbCategoryID.Text + "', '" + txbCategoryName.Text + "')";
                sqlCommType.ExecuteNonQuery();
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
                //MessageBox.Show (sqlCommType.CommandText.ToString ());
            }
            ResetControlValues();
            CloseConnect();
        }
        private void btnRepairType_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommType = sqlConn.CreateCommand();
                sqlCommType.CommandText =
                    @"UPDATE TYPE_BOOK 
                        SET TYPE_BOOK_NAME = '" + txbCategoryName.Text + "' WHERE TYPE_BOOK_ID = '" + txbCategoryID.Text + "'";
                sqlCommType.ExecuteNonQuery();
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            txbCategoryID.ReadOnly = false;
            CloseConnect();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try 
            {
                sqlCommType = sqlConn.CreateCommand();
                sqlCommType.CommandText = "DELETE FROM TYPE_BOOK WHERE TYPE_BOOK_ID = '" + txbCategoryID.Text + "'";
                sqlCommType.ExecuteNonQuery();
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {/*
            OpenConnect();
            try
            {
                sqlCommType = sqlConn.CreateCommand();
                sqlCommType.CommandText = @"SELECT TYPE_BOOK_ID,TYPE_BOOK_NAME FROM TYPE_BOOK WHERE TYPE_BOOK_ID = '" + txbCategoryID.Text.Trim() + "' + order by TYPE_BOOK_ID asc";
                DataTable dtSt = new DataTable();
                sqlAdapter.Fill(dtSt);
                dgvTypeBook.DataSource = dtSt;
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            CloseConnect();*/
        }

        // --- AUTHOR --
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommAuthor = sqlConn.CreateCommand();
                sqlCommAuthor.CommandText = @"INSERT INTO AUTHOR SET (AUTHOR_ID, AUTHOR_NAME) VALUES ('" + txbAuthorID.Text + "', '" + txbAuthorName.Text + "')";
                sqlCommAuthor.ExecuteNonQuery();
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnRepairAuthor_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommAuthor = sqlConn.CreateCommand();
                sqlCommAuthor.CommandText = @"UPDATE AUTHOR SET AUTHOR_NAME = '" + txbAuthorName.Text + "' WHERE AUTHOR_ID = '" + txbAuthorID.Text + "'";
                sqlCommAuthor.ExecuteNonQuery();
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            txbAuthorID.ReadOnly = false;
            CloseConnect();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommAuthor = sqlConn.CreateCommand();
                sqlCommAuthor.CommandText = "DELETE FROM AUTHOR WHERE AUTHOR_ID = '" + txbAuthorID.Text + "'";
                sqlCommAuthor.ExecuteNonQuery();
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {

        }

        // --- PUBLISHER ---
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommPulisher = sqlConn.CreateCommand();
                sqlCommPulisher.CommandText = @"INSERT INTO PUBLISHER SET (PUBLISHER_ID, PUBLISHER_NAME) VALUES ('" + txbPublisherID.Text + "', '" + txbPublisherName.Text + "')";
                sqlCommPulisher.ExecuteNonQuery();
                LoadDBAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnRepairPublisher_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommPulisher = sqlConn.CreateCommand();
                sqlCommPulisher.CommandText = @"UPDATE PUBLISHER SET PUBLISHER_NAME = '" + txbPublisherName.Text + "' WHERE PUBLISHER_ID = '" + txbPublisherName.Text + "'";
                sqlCommPulisher.ExecuteNonQuery();
                LoadDBType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            txbPublisherID.ReadOnly = false;
            CloseConnect();
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommPulisher = sqlConn.CreateCommand();
                sqlCommPulisher.CommandText = "DELETE FROM PUBLISHER WHERE PUBLISHER_ID = '" + txbPublisherID.Text + "'";
                sqlCommPulisher.ExecuteNonQuery();
                LoadDBAuthor();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }


    }
}
