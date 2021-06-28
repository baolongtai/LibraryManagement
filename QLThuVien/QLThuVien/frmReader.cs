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

namespace QLThuVien
{
    public partial class frmReader : Form
    {
        SqlConnection sqlConn;
        SqlCommand sqlCommStudent;
        SqlCommand sqlCommcourse;
        SqlCommand sqlCommClass;
        SqlCommand sqlCommSubject;
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataTable dtTbStudent = new DataTable();
        DataTable dtTbCourse = new DataTable();
        DataTable dtTbClass = new DataTable();
        DataTable dtTbSubject = new DataTable();
        public frmReader()
        {
            InitializeComponent();
        }


        public SqlConnection OpenConnect()
        {
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


        public void LoadDBStudent()
        {
            sqlCommStudent = sqlConn.CreateCommand();
            sqlCommStudent.CommandText = "SELECT STUDENT_ID, STUDENT_NAME, PHONE, EMAIL, COURSE_ID, CLASS_ID, SUBJECT_ID, DATE_ADD FROM STUDENT";
            sqlAdapter.SelectCommand = sqlCommStudent;
            dtTbStudent.Clear();
            sqlAdapter.Fill(dtTbStudent);
            dgvStudent.DataSource = dtTbStudent;
        }
        public void LoadDBCourse()
        {
            sqlCommcourse = sqlConn.CreateCommand();
            sqlCommcourse.CommandText = "SELECT COURSE_ID, COURSE_NAME FROM COURSE";
            dtTbCourse.Clear();
            sqlAdapter.SelectCommand = sqlCommcourse;
            sqlAdapter.Fill(dtTbCourse);
            dgvCourse.DataSource = dtTbCourse;
        }
        public void LoadDBClass()
        {
            sqlCommClass = sqlConn.CreateCommand();
            sqlCommClass.CommandText = "SELECT CLASS_ID, CLASS_NAME, CLASS_PRESIDENT FROM CLASS";
            dtTbClass.Clear();
            sqlAdapter.SelectCommand = sqlCommClass;
            sqlAdapter.Fill(dtTbClass);
            dgvClass.DataSource = dtTbClass;
        }
        public void LoadDSubject()
        {
            sqlCommSubject = sqlConn.CreateCommand();
            sqlCommSubject.CommandText = "SELECT SUBJECT_ID, SUBJECT_NAME FROM SUBJECT";
            sqlAdapter.SelectCommand = sqlCommSubject;
            dtTbSubject.Clear();
            sqlAdapter.Fill(dtTbSubject);
            dgvSubject.DataSource = dtTbSubject;
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                tctReader.Visible = false;
            }
            else
            {
                tctReader.Visible = true;
            }
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            OpenConnect();
            LoadDBStudent();
            LoadDBCourse();
            LoadDBClass();
            LoadDSubject();
            CloseConnect();
        }

        int i;
        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbStudentID.ReadOnly = true;
            i = dgvSubject.CurrentRow.Index;
            txbSubjectID.Text = dgvSubject.Rows[i].Cells[0].Value.ToString();
            txbSubjectID_2.Text = dgvSubject.Rows[i].Cells[0].Value.ToString();
            txbSubjectName.Text = dgvSubject.Rows[i].Cells[1].Value.ToString();
            nmudTime.Text = dgvSubject.Rows[i].Cells[2].Value.ToString();
        }
        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbClassID.ReadOnly = true;
            i = dgvClass.CurrentRow.Index;
            txbClassID.Text = dgvClass.Rows[i].Cells[0].Value.ToString();
            txbClassID_2.Text = dgvClass.Rows[i].Cells[0].Value.ToString();
            txbClassName.Text = dgvClass.Rows[i].Cells[1].Value.ToString();
            txbClassPresident.Text = dgvClass.Rows[i].Cells[2].Value.ToString();
        }
        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCourseID.ReadOnly = true;
            i = dgvCourse.CurrentRow.Index;
            txbCourseID.Text = dgvCourse.Rows[i].Cells[0].Value.ToString();
            txbCourseID_2.Text = dgvCourse.Rows[i].Cells[0].Value.ToString();
            txbCourseName.Text = dgvCourse.Rows[i].Cells[1].Value.ToString();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbStudentID.ReadOnly = true;
            i = dgvStudent.CurrentRow.Index;
            txbStudentID.Text = dgvStudent.Rows[i].Cells[0].Value.ToString();
            txbStudentName.Text = dgvStudent.Rows[i].Cells[1].Value.ToString();
            txtPhone.Text = dgvStudent.Rows[i].Cells[2].Value.ToString();
            txbEmail.Text = dgvStudent.Rows[i].Cells[3].Value.ToString();
            txbCourseID_2.Text = dgvStudent.Rows[i].Cells[4].Value.ToString();
            txbClassID_2.Text = dgvStudent.Rows[i].Cells[5].Value.ToString();
            txbSubjectID_2.Text = dgvStudent.Rows[i].Cells[6].Value.ToString();
            dtpDateAdd.Text = dgvStudent.Rows[i].Cells[7].Value.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommStudent = sqlConn.CreateCommand();
                sqlCommStudent.CommandText =
                    @"INSERT INTO STUDENT
                        (STUDENT_ID, STUDENT_NAME, PHONE, EMAIL, COURSE_ID, CLASS_ID, SUBJECT_ID, DATE_ADD) 
                    VALUES
                        ('" + txbStudentID.Text + "', '" + txbStudentName.Text + "', '" + txtPhone.Text + "', '" + txbEmail.Text + "', '" + txbCourseID_2.Text + "', '" + txbClassID_2.Text + "', '" + txbSubjectID_2.Text + "', '" + dtpDateAdd.Text + "')";
                sqlCommStudent.ExecuteNonQuery();
                LoadDBStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
            CloseConnect();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommStudent = sqlConn.CreateCommand();
                sqlCommStudent.CommandText = "DELETE FROM STUDENT WHERE STUDENT_ID = '" + txbStudentID.Text + "'";
                sqlCommStudent.ExecuteNonQuery();
                LoadDBStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbStudentID.ReadOnly = false;
            ResetControlValues();
            CloseConnect();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommStudent = sqlConn.CreateCommand();
                sqlCommStudent.CommandText = "UPDATE STUDENT SET  STUDENT_NAME = '" + txbStudentName.Text + "', QUANTITY = '" + txtPhone.Text + "', UNIT_PRICE = '" + txbEmail.Text + "', TYPE_BOOK_ID = '" + txbCourseID_2.Text + "', AUTHOR_ID = '" + txbClassID_2.Text + "', PUBLISHER_ID = '" + txbSubjectID_2.Text + "', PUBLISHING_YEAR = '" + dtpDateAdd.Text + "' WHERE BOOK_ID ='" + txbStudentID + "' ";
                sqlCommStudent.ExecuteNonQuery();
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbStudentID.ReadOnly = false;
            ResetControlValues();
            CloseConnect();
        }

        void ResetControlValues()
        {
            txbStudentID.Clear();
            txbStudentName.Clear();
            txtPhone.ResetText();
            txbEmail.Clear();
            txbCourseID_2.Clear();
            txbClassID_2.Clear();
            txbSubjectID_2.Clear();
            dtpDateAdd = null;

            txbCourseID.Clear();
            txbCourseName.Clear();
            txbClassID.Clear();
            txbClassName.Clear();
            txbClassPresident.Clear();
            txbSubjectID.Clear();
            txbSubjectName.Clear();
            nmudTime.ResetText();

            txbStudentID.Focus();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommcourse = sqlConn.CreateCommand();
                sqlCommcourse.CommandText =
                    @"INSERT INTO COURSE SET (COURSE_ID, COURSE_NAME) VALUES ('" + txbCourseID.Text + "', '" + txbCourseName.Text + "')";
                sqlCommcourse.ExecuteNonQuery();
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            CloseConnect();
        }

        private void btnRepairCourse_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommcourse = sqlConn.CreateCommand();
                sqlCommcourse.CommandText = @"UPDATE COURSE SET COURSE_NAME = '" + txbCourseName.Text + "' WHERE COURSE_ID = '" + txbCourseID.Text + "'";
                sqlCommcourse.ExecuteNonQuery();
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbCourseID.ReadOnly = false;
            CloseConnect();
        }

        private void btnDlCourse_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommcourse = sqlConn.CreateCommand();
                sqlCommcourse.CommandText = "DELETE FROM COURSE WHERE COURSE_ID = '" + txbCourseID.Text + "'";
                sqlCommcourse.ExecuteNonQuery();
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbCourseID.ReadOnly = false;
            CloseConnect();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommClass = sqlConn.CreateCommand();
                sqlCommClass.CommandText = @"INSERT INTO CLASS SET (CLASS_ID, CLASS_NAME, CLASS_PRESIDENT) VALUES ('" + txbClassID.Text + "', '" + txbClassName.Text + "', '" + txbClassPresident.Text + "')";
                sqlCommClass.ExecuteNonQuery();
                LoadDBClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            CloseConnect();
        }

        private void btnRepairClass_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommClass = sqlConn.CreateCommand();
                sqlCommClass.CommandText = @"UPDATE CLASS SET CLASS_NAME = '" + txbClassName.Text + "', CLASS_PRESIDENT '" + txbClassPresident + "' WHERE CLASS_ID = '" + txbClassID.Text + "'";
                sqlCommClass.ExecuteNonQuery();
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbClassID.ReadOnly = false;
            CloseConnect();
        }

        private void btnDlClass_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommClass = sqlConn.CreateCommand();
                sqlCommClass.CommandText = "DELETE FROM CLASS WHERE CLASS_ID = '" + txbClassID.Text + "'";
                sqlCommClass.ExecuteNonQuery();
                LoadDBClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbClassID.ReadOnly = false;
            CloseConnect();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommSubject = sqlConn.CreateCommand();
                sqlCommSubject.CommandText = @"INSERT INTO PUBLISHER SET (PUBLISHER_ID, PUBLISHER_NAME) VALUES ('" + txbSubjectID.Text + "', '" + txbSubjectName.Text + "', '" + nmudTime.Text + "')";
                sqlCommSubject.ExecuteNonQuery();
                LoadDBClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            CloseConnect();
        }

        private void btnRepairSubject_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommSubject = sqlConn.CreateCommand();
                sqlCommSubject.CommandText = @"UPDATE PUBLISHER SET PUBLISHER_NAME = ('" + txbSubjectName.Text + "', '" + nmudTime.Text + "') WHERE PUBLISHER_ID = '" + txbSubjectID.Text + "'";
                sqlCommSubject.ExecuteNonQuery();
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbSubjectID.ReadOnly = false;
            CloseConnect();
        }

        private void btnDlSubject_Click(object sender, EventArgs e)
        {
            OpenConnect();
            try
            {
                sqlCommSubject = sqlConn.CreateCommand();
                sqlCommSubject.CommandText = "DELETE FROM PUBLISHER WHERE PUBLISHER_ID = '" + txbSubjectID.Text + "'";
                sqlCommSubject.ExecuteNonQuery();
                LoadDBClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbSubjectID.ReadOnly = false;
            CloseConnect();
        }
    }
}
