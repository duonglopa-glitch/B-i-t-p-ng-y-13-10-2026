using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeBai7
{
    public partial class FormStudent : Form
    {
        private BindingList<StudentModel> _students;
        public FormStudent()
        {
            InitializeComponent();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            InitMockData();
            // Gán ContextMenuStrip vào DataGridView
            dgvStudents.ContextMenuStrip = cmsDgv;
        }
        private void InitMockData()
        {
            _students = new BindingList<StudentModel>
            {
                new StudentModel("SV001", "Nguyễn Văn An", "Công nghệ thông tin"),
                new StudentModel("SV002", "Trần Thị Bích", "Kế toán"),
                new StudentModel("SV003", "Lê Hoàng Cường", "Quản trị kinh doanh")
            };
            dgvStudents.DataSource = _students;
        }
        private void NotifyParentStatus(string message)
        {
            // Ép kiểu MdiParent về FormMain để gọi phương thức UpdateStatusMessage
            if (this.MdiParent is FormMain parentForm)
            {
                parentForm.UpdateStatusMessage(message);
            }
        }
        private void dgvStudents_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = dgvStudents.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dgvStudents.ClearSelection();
                    dgvStudents.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void tsmiViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                StudentModel selected = (StudentModel)dgvStudents.CurrentRow.DataBoundItem;
                MessageBox.Show(string.Format("Mã SV: {0}\nHọ tên: {1}\nKhoa: {2}",
                    selected.StudentId, selected.FullName, selected.Department),
                    "Chi Tiết Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NotifyParentStatus(string.Format("Đã xem chi tiết sinh viên: {0}", selected.StudentId));
            }
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            dgvStudents.Refresh();
            NotifyParentStatus("Đã làm mới danh sách sinh viên.");
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                StudentModel selected = (StudentModel)dgvStudents.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show(
                    string.Format("Bạn có chắc muốn xóa sinh viên {0}?", selected.FullName),
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _students.Remove(selected);
                    NotifyParentStatus(string.Format("Đã xóa thành công sinh viên: {0}", selected.StudentId));
                }
            }
        }
        public class StudentModel
        {
            public string StudentId { get; set; }
            public string FullName { get; set; }
            public string Department { get; set; }

            public StudentModel(string studentId, string fullName, string department)
            {
                StudentId = studentId;
                FullName = fullName;
                Department = department;
            }
        }
    }
}
