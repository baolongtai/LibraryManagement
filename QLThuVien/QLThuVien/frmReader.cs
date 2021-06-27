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
        public frmReader()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            
        }

        int i;
        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvSubject.CurrentRow.Index;
            txbSubjectID.Text = dgvSubject.Rows[i].Cells[0].Value.ToString();
            txbSubjectID_2.Text = dgvSubject.Rows[i].Cells[0].Value.ToString();
            txbSubjectName.Text = dgvSubject.Rows[i].Cells[1].Value.ToString();
            nmudTime.Text = dgvSubject.Rows[i].Cells[2].Value.ToString();
        }
        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvClass.CurrentRow.Index;
            txbClassID.Text = dgvClass.Rows[i].Cells[0].Value.ToString();
            txbClassID_2.Text = dgvClass.Rows[i].Cells[0].Value.ToString();
            txbClassName.Text = dgvClass.Rows[i].Cells[1].Value.ToString();
            txbClassPresident.Text = dgvClass.Rows[i].Cells[2].Value.ToString();
        }
        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvCourse.CurrentRow.Index;
            txbCourseID.Text = dgvCourse.Rows[i].Cells[0].Value.ToString();
            txbCourseID_2.Text = dgvCourse.Rows[i].Cells[0].Value.ToString();
            txbCourseName.Text = dgvCourse.Rows[i].Cells[1].Value.ToString();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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


    }
}
