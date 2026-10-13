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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            tmrClock.Start();
            UpdateStatusMessage("Hệ thống khởi động thành công.");
        }
        public void OpenChildForm<T>() where T : Form, new()
        {
            // Tìm xem Form loại T đã tồn tại trong danh sách MdiChildren chưa
            Form childForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (childForm != null)
            {
                // Nếu đã mở -> Đưa lên trên cùng
                childForm.Activate();
                UpdateStatusMessage(string.Format("Kích hoạt cửa sổ: {0}", childForm.Text));
            }
            else
            {
                // Nếu chưa mở -> Khởi tạo mới
                childForm = new T();
                childForm.MdiParent = this;
                childForm.Show();
                UpdateStatusMessage(string.Format("Đã mở cửa sổ mới: {0}", childForm.Text));
            }
        }
        public void UpdateStatusMessage(string message)
        {
            lblStatusMessage.Text = string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss"), message);
        }

        private void mnuStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormStudent>();
        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormProduct>();
        }

        private void btnTlsStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormStudent>();
        }

        private void btnTlsProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormProduct>();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            UpdateStatusMessage("Sắp xếp cửa sổ dạng Thác nước (Cascade)");
        }

        private void mnuTileHoriz_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            UpdateStatusMessage("Sắp xếp cửa sổ dạng Lợp ngang (Tile Horizontal)");
        }

        private void mnuTileVert_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            UpdateStatusMessage("Sắp xếp cửa sổ dạng Lợp dọc (Tile Vertical)");
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void tmrClock_Tick_1(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
