namespace CodeBai7
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.danhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHoriz = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVert = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.btnTlsStudent = new System.Windows.Forms.ToolStripButton();
            this.btnTlsProduct = new System.Windows.Forms.ToolStripButton();
            this.btnTlsCascade = new System.Windows.Forms.ToolStripButton();
            this.btnTlsTileHoriz = new System.Windows.Forms.ToolStripButton();
            this.btnTlsTileVert = new System.Windows.Forms.ToolStripButton();
            this.stnMain = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSystemTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.mnsMain.SuspendLayout();
            this.tlsMain.SuspendLayout();
            this.stnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhToolStripMenuItem,
            this.cửaSổToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(800, 28);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogout,
            this.mnuExit});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(224, 26);
            this.mnuLogout.Text = "Đăng Xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(224, 26);
            this.mnuExit.Text = "Thoát ";
            // 
            // danhToolStripMenuItem
            // 
            this.danhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuProduct});
            this.danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            this.danhToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuStudent
            // 
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(224, 26);
            this.mnuStudent.Text = "QL Sinh viên";
            this.mnuStudent.Click += new System.EventHandler(this.mnuStudent_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(224, 26);
            this.mnuProduct.Text = "QL Sản phẩm ";
            this.mnuProduct.Click += new System.EventHandler(this.mnuProduct_Click);
            // 
            // cửaSổToolStripMenuItem
            // 
            this.cửaSổToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTileHoriz,
            this.mnuTileVert});
            this.cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            this.cửaSổToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(224, 26);
            this.mnuCascade.Text = "Xếp thác";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTileHoriz
            // 
            this.mnuTileHoriz.Name = "mnuTileHoriz";
            this.mnuTileHoriz.Size = new System.Drawing.Size(224, 26);
            this.mnuTileHoriz.Text = "Xếp ngang";
            this.mnuTileHoriz.Click += new System.EventHandler(this.mnuTileHoriz_Click);
            // 
            // mnuTileVert
            // 
            this.mnuTileVert.Name = "mnuTileVert";
            this.mnuTileVert.Size = new System.Drawing.Size(224, 26);
            this.mnuTileVert.Text = "Xếp dọc";
            this.mnuTileVert.Click += new System.EventHandler(this.mnuTileVert_Click);
            // 
            // tlsMain
            // 
            this.tlsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTlsStudent,
            this.btnTlsProduct,
            this.btnTlsCascade,
            this.btnTlsTileHoriz,
            this.btnTlsTileVert});
            this.tlsMain.Location = new System.Drawing.Point(0, 28);
            this.tlsMain.Name = "tlsMain";
            this.tlsMain.Size = new System.Drawing.Size(800, 27);
            this.tlsMain.TabIndex = 2;
            this.tlsMain.Text = "toolStrip1";
            // 
            // btnTlsStudent
            // 
            this.btnTlsStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTlsStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnTlsStudent.Image")));
            this.btnTlsStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTlsStudent.Name = "btnTlsStudent";
            this.btnTlsStudent.Size = new System.Drawing.Size(29, 24);
            this.btnTlsStudent.Text = "toolStripButton1";
            this.btnTlsStudent.Click += new System.EventHandler(this.btnTlsStudent_Click);
            // 
            // btnTlsProduct
            // 
            this.btnTlsProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTlsProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnTlsProduct.Image")));
            this.btnTlsProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTlsProduct.Name = "btnTlsProduct";
            this.btnTlsProduct.Size = new System.Drawing.Size(29, 24);
            this.btnTlsProduct.Text = "toolStripButton2";
            this.btnTlsProduct.Click += new System.EventHandler(this.btnTlsProduct_Click);
            // 
            // btnTlsCascade
            // 
            this.btnTlsCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTlsCascade.Image = ((System.Drawing.Image)(resources.GetObject("btnTlsCascade.Image")));
            this.btnTlsCascade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTlsCascade.Name = "btnTlsCascade";
            this.btnTlsCascade.Size = new System.Drawing.Size(29, 24);
            this.btnTlsCascade.Text = "toolStripButton1";
            // 
            // btnTlsTileHoriz
            // 
            this.btnTlsTileHoriz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTlsTileHoriz.Image = ((System.Drawing.Image)(resources.GetObject("btnTlsTileHoriz.Image")));
            this.btnTlsTileHoriz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTlsTileHoriz.Name = "btnTlsTileHoriz";
            this.btnTlsTileHoriz.Size = new System.Drawing.Size(29, 24);
            this.btnTlsTileHoriz.Text = "toolStripButton1";
            // 
            // btnTlsTileVert
            // 
            this.btnTlsTileVert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTlsTileVert.Image = ((System.Drawing.Image)(resources.GetObject("btnTlsTileVert.Image")));
            this.btnTlsTileVert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTlsTileVert.Name = "btnTlsTileVert";
            this.btnTlsTileVert.Size = new System.Drawing.Size(29, 24);
            this.btnTlsTileVert.Text = "toolStripButton1";
            // 
            // stnMain
            // 
            this.stnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblStatusMessage,
            this.lblSystemTime});
            this.stnMain.Location = new System.Drawing.Point(0, 424);
            this.stnMain.Name = "stnMain";
            this.stnMain.Size = new System.Drawing.Size(800, 26);
            this.stnMain.TabIndex = 3;
            this.stnMain.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(140, 20);
            this.lblUser.Text = "Người dùng: Admin";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(68, 20);
            this.lblStatusMessage.Text = "Sẵn sàng";
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(63, 20);
            this.lblSystemTime.Text = "00:00:00";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stnMain);
            this.Controls.Add(this.tlsMain);
            this.Controls.Add(this.mnsMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.Name = "FormMain";
            this.Text = "Khung Ứng Dụng Quản Lý MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.stnMain.ResumeLayout(false);
            this.stnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem danhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem cửaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHoriz;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVert;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton btnTlsStudent;
        private System.Windows.Forms.ToolStripButton btnTlsProduct;
        private System.Windows.Forms.ToolStripButton btnTlsCascade;
        private System.Windows.Forms.ToolStripButton btnTlsTileHoriz;
        private System.Windows.Forms.ToolStripButton btnTlsTileVert;
        private System.Windows.Forms.StatusStrip stnMain;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblSystemTime;
        private System.Windows.Forms.Timer tmrClock;
    }
}

