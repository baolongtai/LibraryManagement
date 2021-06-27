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
        SqlConnection sqlConn = new SqlConnection(ConnectionString.str);
        SqlCommand sqlCommand;
        SqlCommand sqlCommandType;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataTable dataTableBooks = new DataTable();
        DataTable dataTableType = new DataTable();
        DataTable dataTableAuthor = new DataTable();
        DataTable dataTablePublisher = new DataTable();
        
        public frmBook()
        {
            InitializeComponent();
        }
        public void LoadDBBooks()
        {
            sqlCommand = sqlConn.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM BOOKS";
            sqlAdapter.SelectCommand = sqlCommand;
            dataTableBooks.Clear();
            sqlAdapter.Fill(dataTableBooks);
            dgvBook.DataSource = dataTableBooks;
        }
        public void LoadDBTypeBook()
        {
            sqlCommandType = sqlConn.CreateCommand();
            sqlCommandType.CommandText = "SELECT TYPE_BOOK_ID, TYPE_BOOK_NAME FROM TYPE_BOOK";
            dataTableType.Clear();
            sqlAdapter.SelectCommand = sqlCommandType;
            sqlAdapter.Fill(dataTableType);
            dgvTypeBook.DataSource = dataTableType;
        }
        public void LoadDBAUTHOR()
        {
            sqlCommand = sqlConn.CreateCommand();
            sqlCommand.CommandText = "SELECT AUTHOR_ID, AUTHOR_NAME FROM AUTHOR";
            dataTableAuthor.Clear();
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTableAuthor);
            dgvAuthor.DataSource = dataTableAuthor;
        }
        public void LoadDPUBLISHER()
        {
            sqlCommand = sqlConn.CreateCommand();
            sqlCommand.CommandText = "SELECT PUBLISHER_ID, PUBLISHER_NAME FROM PUBLISHER";
            sqlAdapter.SelectCommand = sqlCommand;
            dataTablePublisher.Clear();
            sqlAdapter.Fill(dataTablePublisher);
            dgvPulisher.DataSource = dataTablePublisher;
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            LoadDBBooks();
            LoadDBTypeBook();
            LoadDBAUTHOR();
            LoadDPUBLISHER();
            sqlConn.Close();
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
            i = dgvTypeBook.CurrentRow.Index;
            txbCategoryID.Text = dgvTypeBook.Rows[i].Cells[0].Value.ToString();
            txbTypeBookID_2.Text = dgvTypeBook.Rows[i].Cells[0].Value.ToString();
            txbCategoryName.Text = dgvTypeBook.Rows[i].Cells[1].Value.ToString();
        }
        private void dgvPulisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvPulisher.CurrentRow.Index;
            txbPublisherID.Text = dgvPulisher.Rows[i].Cells[0].Value.ToString();
            txbPublisherID_2.Text = dgvPulisher.Rows[i].Cells[0].Value.ToString();
            txbPublisherName.Text = dgvPulisher.Rows[i].Cells[1].Value.ToString();
        }

        private void dvgAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            try
            {
                sqlCommand = sqlConn.CreateCommand();
                sqlCommand.CommandText =
                    @"INSERT INTO BOOKS
                        (BOOK_ID, BOOK_NAME, QUANTITY, UNIT_PRICE, TYPE_BOOK_ID, AUTHOR_ID, PUBLISHER_ID, PUBLISHING_YEAR, DATE_RECEIPT) 
                    VALUES
                        ('" + txbBookID.Text + "', '" + txbBookName.Text + "', '" + nmudQuantity.Text + "', '" + txbUnitPrice.Text + "', '" + txbTypeBookID_2.Text + "', '" + txbAuthorID_2.Text + "', '" + txbPublisherID_2.Text + "', '" + dtpPublishingYear.Text + "', '" + dtpDataReceipt.Text + "')";
                sqlCommand.ExecuteNonQuery();
                LoadDBBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            sqlConn.Close();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            try
            {
                sqlCommand = sqlConn.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM BOOKS WHERE BOOK_ID = '" + txbBookID.Text +"'";
                sqlCommand.ExecuteNonQuery();
                LoadDBBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            sqlConn.Close();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            try
            {
                sqlCommand = sqlConn.CreateCommand();
                sqlCommand.CommandText = "UPDATE BOOKS SET  BOOK_NAME = '" + txbBookName.Text + "', QUANTITY = '" + nmudQuantity.Text + "', UNIT_PRICE = '" + txbUnitPrice.Text + "', TYPE_BOOK_ID = '" + txbTypeBookID_2.Text + "', AUTHOR_ID = '" + txbAuthorID_2.Text + "', PUBLISHER_ID = '" + txbPublisherID_2.Text + "', PUBLISHING_YEAR = '" + dtpPublishingYear.Text + "', DATE_RECEIPT = '" + dtpDataReceipt.Text + "' WHERE BOOK_ID ='"+ txbBookID +"' ";
                sqlCommand.ExecuteNonQuery();
                LoadDBTypeBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            sqlConn.Close();
            txbBookID.ReadOnly = false;
        }

        //đang tìm hiểu

        private void btnAddType_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            sqlCommandType = sqlConn.CreateCommand();
            sqlCommandType.CommandText =
                @"INSERT INTO TYPE_BOOK
                        (TYPE_BOOK_ID, TYPE_BOOK_NAME) 
                    VALUES
                        ('" + txbCategoryID + "', '" + txbCategoryName + "')";
            sqlCommandType.ExecuteNonQuery();
            LoadDBTypeBook();
            /*try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }*/
            ResetControlValues();
            sqlConn.Close();
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


        // chưa có nút lưu
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


        
    }
}
