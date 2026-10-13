using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class FormAvatarCsv : Form
    {
        private BindingList<Student> _studentList;
        private BindingSource _bindingSource;
        public FormAvatarCsv()
        {
            InitializeComponent();
        }

        private void FormAvatarCsv_Load(object sender, EventArgs e)
        {
            InitGenderComboBox();
            InitDataAndBinding();
            SetupDataGridViewColumns();
        }
        private void InitGenderComboBox()
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.SelectedIndex = 0;
        }
        private void InitDataAndBinding()
        {
            _studentList = new BindingList<Student>
            {
                new Student("SV001", "Nguyễn Văn An", 20, "Nam", ""),
                new Student("SV002", "Trần Thị Bích", 21, "Nữ", ""),
                new Student("SV003", "Lê Hoàng Cường", 22, "Nam", "")
            };

            _bindingSource = new BindingSource
            {
                DataSource = _studentList
            };

            dgvStudents.DataSource = _bindingSource;

            txtStudentId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            cboGender.DataBindings.Clear();

            txtStudentId.DataBindings.Add("Text", _bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", _bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", _bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("SelectedItem", _bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            _bindingSource.PositionChanged += BindingSource_PositionChanged;

            UpdateAvatarImage();
        }
        private void SetupDataGridViewColumns()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentId",
                HeaderText = "Mã SV",
                Width = 90
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Họ và Tên",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Age",
                HeaderText = "Tuổi",
                Width = 70
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gender",
                HeaderText = "Giới Tính",
                Width = 90
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AvatarPath",
                HeaderText = "Đường Dẫn Ảnh",
                Width = 150
            });
        }
        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateAvatarImage();
        }
        private void UpdateAvatarImage()
        {
            
            if (picAvatar.Image != null)
            {
                picAvatar.Image.Dispose();
                picAvatar.Image = null;
            }

            if (_bindingSource.Current is Student currentStudent &&
                !string.IsNullOrEmpty(currentStudent.AvatarPath) &&
                File.Exists(currentStudent.AvatarPath))
            {
                try
                {
                    
                    using (FileStream fs = new FileStream(currentStudent.AvatarPath, FileMode.Open, FileAccess.Read))
                    {
                        picAvatar.Image = Image.FromStream(fs);
                    }
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is Student currentStudent)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh đại diện sinh viên";
                    ofd.Filter = "File Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        currentStudent.AvatarPath = ofd.FileName;
                        _bindingSource.ResetCurrentItem(); 
                        UpdateAvatarImage();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newId = "SV" + (_studentList.Count + 1).ToString("D3");
            Student newStudent = new Student(newId, "Sinh viên mới", 18, "Nam", "");

            _studentList.Add(newStudent);
            _bindingSource.MoveLast(); 
            txtStudentId.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bindingSource.EndEdit();
            MessageBox.Show("Đã lưu thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is Student currentStudent)
            {
                DialogResult dr = MessageBox.Show(
                    string.Format("Bạn có chắc chắn muốn xóa sinh viên {0} ({1}) không?", currentStudent.FullName, currentStudent.StudentId),
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _bindingSource.RemoveCurrent();
                    UpdateAvatarImage();
                }
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (_studentList.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên rỗng, không thể xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách sinh viên ra file CSV";
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        
                        sb.AppendLine("MaSV,HoTen,Tuoi,GioiTinh,DuongDanAvatar");

                        foreach (Student st in _studentList)
                        {
                            sb.AppendLine(string.Format("\"{0}\",\"{1}\",{2},\"{3}\",\"{4}\"",
                                st.StudentId, st.FullName, st.Age, st.Gender, st.AvatarPath));
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show("Xuất dữ liệu ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
