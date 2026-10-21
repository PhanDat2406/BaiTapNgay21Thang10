namespace Bai3
{
    public partial class FormMain : Form, IMdiParentForm
    {
        private bool isConfirmedExit = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblClock.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            OpenChildForm<FormStudent>();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        public void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T existingChild)
                {
                    if (existingChild.WindowState == FormWindowState.Minimized)
                    {
                        existingChild.WindowState = FormWindowState.Normal;
                    }
                    existingChild.Activate();
                    existingChild.BringToFront();
                    UpdateStatusMessage($"Đã kích hoạt cửa sổ: {existingChild.Text}");
                    return;
                }
            }

            T newChild = new T
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            newChild.Show();
            UpdateStatusMessage($"Đã mở cửa sổ: {newChild.Text}");
        }

        private void menuQLSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormStudent>();
        }

        private void menuQLSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormProduct>();
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            UpdateStatusMessage("Đã sắp xếp cửa sổ theo kiểu Cascade.");
        }

        private void menuTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            UpdateStatusMessage("Đã sắp xếp cửa sổ theo kiểu Tile Horizontal.");
        }

        private void menuTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            UpdateStatusMessage("Đã sắp xếp cửa sổ theo kiểu Tile Vertical.");
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất tài khoản hiện tại?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                foreach (Form child in this.MdiChildren)
                {
                    child.Close();
                }

                lblUser.Text = "Người dùng: (Chưa đăng nhập)";
                UpdateStatusMessage("Đã đăng xuất. Vui lòng chọn chức năng để tiếp tục.");
                MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUser.Text = "Người dùng: Quản trị viên";
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConfirmedExit) return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                isConfirmedExit = true;
            }
        }

        public void UpdateStatusMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateStatusMessage(message)));
                return;
            }

            lblStatus.Text = message;
        }

        public void UpdateProgress(int percent)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateProgress(percent)));
                return;
            }

            int safeVal = Math.Clamp(percent, 0, 100);
            tsProgressBar.Visible = true;
            lblProgressPercent.Visible = true;
            tsProgressBar.Value = safeVal;
            lblProgressPercent.Text = $"{safeVal}%";
        }

        public void ResetProgress()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ResetProgress));
                return;
            }

            tsProgressBar.Value = 0;
            tsProgressBar.Visible = false;
            lblProgressPercent.Visible = false;
        }
    }
}
