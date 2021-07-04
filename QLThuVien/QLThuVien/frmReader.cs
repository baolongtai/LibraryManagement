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

        ConnectionString cnn = new ConnectionString();

        public frmReader()
        {
            InitializeComponent();
        }

        public void LoadDBStudent()
        {
            dgvStudent.DataSource = cnn.LoadData("SELECT STUDENT_ID, STUDENT_NAME, PHONE, EMAIL, COURSE_ID, CLASS_ID, SUBJECT_ID, DATE_ADD FROM STUDENT");
        }
        public void LoadDBCourse()
        {
            dgvCourse.DataSource = cnn.LoadData("SELECT COURSE_ID, COURSE_NAME FROM COURSE");
        }
        public void LoadDBClass()
        {
            dgvClass.DataSource = cnn.LoadData("SELECT CLASS_ID, CLASS_NAME, CLASS_PRESIDENT FROM CLASS");
        }
        public void LoadDSubject()
        {
            dgvSubject.DataSource = cnn.LoadData("SELECT SUBJECT_ID, SUBJECT_NAME FROM SUBJECT");
        }

        public void SearchStudentByKeyWord()
        {
            dgvStudent.DataSource = cnn.LoadData("SELECT * FROM STUDENT WHERE STUDENT_NAME LIKE '%" + txbKeyWord.Text + "%'");
        }
        public void SearchCoursebyKeyWord()
        {
            dgvCourse.DataSource = cnn.LoadData("SELECT * FROM COURSE_NAME LIKE '%" + txbCourseName.Text + "%'");
        }
        public void SearchClassbyKeyWord()
        {
            dgvClass.DataSource = cnn.LoadData("SELECT * FROM CLASS_NAME LIKE '%" + txbClassName.Text + "%'");
        }
        public void SearchSubjectbyKeyWord()
        {
            dgvSubject.DataSource = cnn.LoadData("SELECT * FROM SUBJECT_NAME LIKE '%" + txbSubjectName.Text + "%'");
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
            LoadDBStudent();
            LoadDBCourse();
            LoadDBClass();
            LoadDSubject();
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
            try
            {
                cnn.LoadData("INSERT INTO STUDENT (STUDENT_ID, STUDENT_NAME, PHONE, EMAIL, COURSE_ID, CLASS_ID, SUBJECT_ID, DATE_ADD) VALUES('" + txbStudentID.Text + "', '" + txbStudentName.Text + "', '" + txtPhone.Text + "', '" + txbEmail.Text + "', '" + txbCourseID_2.Text + "', '" + txbClassID_2.Text + "', '" + txbSubjectID_2.Text + "', '" + dtpDateAdd.Text + "')");
                LoadDBStudent();
                ResetControlValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
            cnn.LoadData("DELETE FROM STUDENT WHERE STUDENT_ID = '" + txbStudentID.Text + "'");
            txbStudentID.ReadOnly = false;
            LoadDBStudent();
            ResetControlValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("UPDATE STUDENT SET  STUDENT_NAME = '" + txbStudentName.Text + "', QUANTITY = '" + txtPhone.Text + "', UNIT_PRICE = '" + txbEmail.Text + "', TYPE_BOOK_ID = '" + txbCourseID_2.Text + "', AUTHOR_ID = '" + txbClassID_2.Text + "', PUBLISHER_ID = '" + txbSubjectID_2.Text + "', PUBLISHING_YEAR = '" + dtpDateAdd.Text + "' WHERE BOOK_ID ='" + txbStudentID + "' ");
                txbStudentID.ReadOnly = false;
                LoadDBStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
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
            try
            {
            cnn.LoadData("INSERT INTO COURSE SET (COURSE_ID, COURSE_NAME) VALUES ('" + txbCourseID.Text + "', '" + txbCourseName.Text + "')");
            LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnRepairCourse_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("UPDATE COURSE SET COURSE_NAME = '" + txbCourseName.Text + "' WHERE COURSE_ID = '" + txbCourseID.Text + "'");
                txbCourseID.ReadOnly = false;
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnDlCourse_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("DELETE FROM COURSE WHERE COURSE_ID = '" + txbCourseID.Text + "'");
                txbCourseID.ReadOnly = false;
                LoadDBCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("INSERT INTO CLASS SET (CLASS_ID, CLASS_NAME, CLASS_PRESIDENT) VALUES ('" + txbClassID.Text + "', '" + txbClassName.Text + "', '" + txbClassPresident.Text + "')");
                LoadDBClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnRepairClass_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("UPDATE CLASS SET CLASS_NAME = '" + txbClassName.Text + "', CLASS_PRESIDENT '" + txbClassPresident + "' WHERE CLASS_ID = '" + txbClassID.Text + "'");
                LoadDBClass();
                txbClassID.ReadOnly = false;
                ResetControlValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            txbClassID.ReadOnly = false;
        }

        private void btnDlClass_Click(object sender, EventArgs e)
        {
            try
            {
            cnn.LoadData("DELETE FROM CLASS WHERE CLASS_ID = '" + txbClassID.Text + "'");
            LoadDBClass();
            txbClassID.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues(); 
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("INSERT INTO PUBLISHER SET (PUBLISHER_ID, PUBLISHER_NAME) VALUES ('" + txbSubjectID.Text + "', '" + txbSubjectName.Text + "', '" + nmudTime.Text + "')");
                LoadDSubject();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnRepairSubject_Click(object sender, EventArgs e)
        {
            try
            {
            cnn.LoadData("UPDATE PUBLISHER SET PUBLISHER_NAME = ('" + txbSubjectName.Text + "', '" + nmudTime.Text + "') WHERE PUBLISHER_ID = '" + txbSubjectID.Text + "'");
            LoadDSubject();
            txbSubjectID.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnDlSubject_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.LoadData("DELETE FROM PUBLISHER WHERE PUBLISHER_ID = '" + txbSubjectID.Text + "'");
                LoadDSubject();
                txbSubjectID.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            ResetControlValues();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudentByKeyWord();
        }

        private void txbKeyWord_TextChanged(object sender, EventArgs e)
        {
            SearchStudentByKeyWord();
        }

        private void txbCourseName_TextChanged(object sender, EventArgs e)
        {
            SearchCoursebyKeyWord();
        }

        private void txbClassName_TextChanged(object sender, EventArgs e)
        {
            SearchClassbyKeyWord();
        }

        private void txbSubjectName_TextChanged(object sender, EventArgs e)
        {
            SearchSubjectbyKeyWord();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            SearchCoursebyKeyWord();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            SearchClassbyKeyWord();
        }

        private void search3_Click(object sender, EventArgs e)
        {
            SearchSubjectbyKeyWord();
        }
    }
}
