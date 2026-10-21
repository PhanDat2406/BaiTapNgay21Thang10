namespace Bai2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuQLSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuQLSanPham;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileH;
        private System.Windows.Forms.ToolStripMenuItem menuTileV;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbStudent;
        private System.Windows.Forms.ToolStripButton tsbProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSep1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuQLSinhVien;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuQLSanPham;
        private System.Windows.Forms.ToolStripSeparator cmsSep1;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuCascade;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuTileH;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuTileV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            menuQLSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            menuQLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            menuTileH = new System.Windows.Forms.ToolStripMenuItem();
            menuTileV = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMain = new System.Windows.Forms.ToolStrip();
            tsbStudent = new System.Windows.Forms.ToolStripButton();
            tsbProduct = new System.Windows.Forms.ToolStripButton();
            toolStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            tsbExit = new System.Windows.Forms.ToolStripButton();
            statusStripMain = new System.Windows.Forms.StatusStrip();
            lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            lblClock = new System.Windows.Forms.ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            cmsMain = new System.Windows.Forms.ContextMenuStrip(components);
            cmsMenuQLSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            cmsMenuQLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            cmsSep1 = new System.Windows.Forms.ToolStripSeparator();
            cmsMenuCascade = new System.Windows.Forms.ToolStripMenuItem();
            cmsMenuTileH = new System.Windows.Forms.ToolStripMenuItem();
            cmsMenuTileV = new System.Windows.Forms.ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            toolStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            cmsMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuHeThong, menuDanhMuc, menuCuaSo });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.MdiWindowListItem = menuCuaSo;
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new System.Drawing.Size(1008, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStripMain";
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuDangXuat, menuSep1, menuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new System.Drawing.Size(69, 20);
            menuHeThong.Text = "&Hệ thống";
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L;
            menuDangXuat.Size = new System.Drawing.Size(170, 22);
            menuDangXuat.Text = "Đăng &xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // menuSep1
            // 
            menuSep1.Name = "menuSep1";
            menuSep1.Size = new System.Drawing.Size(167, 6);
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            menuThoat.Size = new System.Drawing.Size(170, 22);
            menuThoat.Text = "&Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // menuDanhMuc
            // 
            menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuQLSinhVien, menuQLSanPham });
            menuDanhMuc.Name = "menuDanhMuc";
            menuDanhMuc.Size = new System.Drawing.Size(74, 20);
            menuDanhMuc.Text = "&Danh mục";
            // 
            // menuQLSinhVien
            // 
            menuQLSinhVien.Name = "menuQLSinhVien";
            menuQLSinhVien.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            menuQLSinhVien.Size = new System.Drawing.Size(213, 22);
            menuQLSinhVien.Text = "Quản lý &Sinh viên";
            menuQLSinhVien.Click += menuQLSinhVien_Click;
            // 
            // menuQLSanPham
            // 
            menuQLSanPham.Name = "menuQLSanPham";
            menuQLSanPham.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            menuQLSanPham.Size = new System.Drawing.Size(213, 22);
            menuQLSanPham.Text = "Quản lý &Sản phẩm";
            menuQLSanPham.Click += menuQLSanPham_Click;
            // 
            // menuCuaSo
            // 
            menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuCascade, menuTileH, menuTileV });
            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new System.Drawing.Size(95, 20);
            menuCuaSo.Text = "&Cửa sổ (Window)";
            // 
            // menuCascade
            // 
            menuCascade.Name = "menuCascade";
            menuCascade.Size = new System.Drawing.Size(150, 22);
            menuCascade.Text = "&Cascade";
            menuCascade.Click += menuCascade_Click;
            // 
            // menuTileH
            // 
            menuTileH.Name = "menuTileH";
            menuTileH.Size = new System.Drawing.Size(150, 22);
            menuTileH.Text = "Tile &Horizontal";
            menuTileH.Click += menuTileH_Click;
            // 
            // menuTileV
            // 
            menuTileV.Name = "menuTileV";
            menuTileV.Size = new System.Drawing.Size(150, 22);
            menuTileV.Text = "Tile &Vertical";
            menuTileV.Click += menuTileV_Click;
            // 
            // toolStripMain
            // 
            toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbStudent, tsbProduct, toolStripSep1, tsbExit });
            toolStripMain.Location = new System.Drawing.Point(0, 24);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new System.Drawing.Size(1008, 25);
            toolStripMain.TabIndex = 2;
            toolStripMain.Text = "toolStripMain";
            // 
            // tsbStudent
            // 
            tsbStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbStudent.Name = "tsbStudent";
            tsbStudent.Size = new System.Drawing.Size(104, 22);
            tsbStudent.Text = "Quản lý Sinh viên";
            tsbStudent.Click += menuQLSinhVien_Click;
            // 
            // tsbProduct
            // 
            tsbProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbProduct.Name = "tsbProduct";
            tsbProduct.Size = new System.Drawing.Size(108, 22);
            tsbProduct.Text = "Quản lý Sản phẩm";
            tsbProduct.Click += menuQLSanPham_Click;
            // 
            // toolStripSep1
            // 
            toolStripSep1.Name = "toolStripSep1";
            toolStripSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new System.Drawing.Size(41, 22);
            tsbExit.Text = "Thoát";
            tsbExit.Click += menuThoat_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblUser, lblStatus, lblClock });
            statusStripMain.Location = new System.Drawing.Point(0, 707);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new System.Drawing.Size(1008, 22);
            statusStripMain.TabIndex = 3;
            statusStripMain.Text = "statusStripMain";
            // 
            // lblUser
            // 
            lblUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(137, 17);
            lblUser.Text = "Người dùng: Quản trị viên";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(677, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClock
            // 
            lblClock.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            lblClock.Name = "lblClock";
            lblClock.Size = new System.Drawing.Size(98, 17);
            lblClock.Text = "Thời gian: Đang nạp...";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // cmsMain
            // 
            cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cmsMenuQLSinhVien, cmsMenuQLSanPham, cmsSep1, cmsMenuCascade, cmsMenuTileH, cmsMenuTileV });
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new System.Drawing.Size(171, 120);
            // 
            // cmsMenuQLSinhVien
            // 
            cmsMenuQLSinhVien.Name = "cmsMenuQLSinhVien";
            cmsMenuQLSinhVien.Size = new System.Drawing.Size(170, 22);
            cmsMenuQLSinhVien.Text = "Quản lý Sinh viên";
            cmsMenuQLSinhVien.Click += menuQLSinhVien_Click;
            // 
            // cmsMenuQLSanPham
            // 
            cmsMenuQLSanPham.Name = "cmsMenuQLSanPham";
            cmsMenuQLSanPham.Size = new System.Drawing.Size(170, 22);
            cmsMenuQLSanPham.Text = "Quản lý Sản phẩm";
            cmsMenuQLSanPham.Click += menuQLSanPham_Click;
            // 
            // cmsSep1
            // 
            cmsSep1.Name = "cmsSep1";
            cmsSep1.Size = new System.Drawing.Size(167, 6);
            // 
            // cmsMenuCascade
            // 
            cmsMenuCascade.Name = "cmsMenuCascade";
            cmsMenuCascade.Size = new System.Drawing.Size(170, 22);
            cmsMenuCascade.Text = "Cascade";
            cmsMenuCascade.Click += menuCascade_Click;
            // 
            // cmsMenuTileH
            // 
            cmsMenuTileH.Name = "cmsMenuTileH";
            cmsMenuTileH.Size = new System.Drawing.Size(170, 22);
            cmsMenuTileH.Text = "Tile Horizontal";
            cmsMenuTileH.Click += menuTileH_Click;
            // 
            // cmsMenuTileV
            // 
            cmsMenuTileV.Name = "cmsMenuTileV";
            cmsMenuTileV.Size = new System.Drawing.Size(170, 22);
            cmsMenuTileV.Text = "Tile Vertical";
            cmsMenuTileV.Click += menuTileV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 729);
            ContextMenuStrip = cmsMain;
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 4.7 - Thiết kế Khung Ứng dụng MDI & Quản lý Đa cửa sổ";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            cmsMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
