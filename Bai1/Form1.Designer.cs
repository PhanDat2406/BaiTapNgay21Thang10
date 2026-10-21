namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseAvatar;
        private System.Windows.Forms.Label lblAvatarPathTitle;
        private System.Windows.Forms.Label lblAvatarPath;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            grpInput = new System.Windows.Forms.GroupBox();
            lblStudentId = new System.Windows.Forms.Label();
            txtStudentId = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            cboGender = new System.Windows.Forms.ComboBox();
            picAvatar = new System.Windows.Forms.PictureBox();
            btnChooseAvatar = new System.Windows.Forms.Button();
            lblAvatarPathTitle = new System.Windows.Forms.Label();
            lblAvatarPath = new System.Windows.Forms.Label();
            grpActions = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExportCsv = new System.Windows.Forms.Button();
            grpList = new System.Windows.Forms.GroupBox();
            dgvStudents = new System.Windows.Forms.DataGridView();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpActions.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpInput.Controls.Add(lblStudentId);
            grpInput.Controls.Add(txtStudentId);
            grpInput.Controls.Add(lblFullName);
            grpInput.Controls.Add(txtFullName);
            grpInput.Controls.Add(lblAge);
            grpInput.Controls.Add(txtAge);
            grpInput.Controls.Add(lblGender);
            grpInput.Controls.Add(cboGender);
            grpInput.Controls.Add(picAvatar);
            grpInput.Controls.Add(btnChooseAvatar);
            grpInput.Controls.Add(lblAvatarPathTitle);
            grpInput.Controls.Add(lblAvatarPath);
            grpInput.Location = new System.Drawing.Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new System.Drawing.Size(860, 160);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Cụm nhập liệu";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new System.Drawing.Point(15, 28);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new System.Drawing.Size(43, 15);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã SV:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new System.Drawing.Point(85, 25);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new System.Drawing.Size(180, 23);
            txtStudentId.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(15, 68);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(46, 15);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(85, 65);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(180, 23);
            txtFullName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(295, 28);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(33, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(365, 25);
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(150, 23);
            txtAge.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(295, 68);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(55, 15);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new System.Drawing.Point(365, 65);
            cboGender.Name = "cboGender";
            cboGender.Size = new System.Drawing.Size(150, 23);
            cboGender.TabIndex = 7;
            // 
            // lblAvatarPathTitle
            // 
            lblAvatarPathTitle.AutoSize = true;
            lblAvatarPathTitle.Location = new System.Drawing.Point(15, 115);
            lblAvatarPathTitle.Name = "lblAvatarPathTitle";
            lblAvatarPathTitle.Size = new System.Drawing.Size(54, 15);
            lblAvatarPathTitle.TabIndex = 8;
            lblAvatarPathTitle.Text = "Tệp ảnh:";
            // 
            // lblAvatarPath
            // 
            lblAvatarPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAvatarPath.AutoEllipsis = true;
            lblAvatarPath.Location = new System.Drawing.Point(85, 115);
            lblAvatarPath.Name = "lblAvatarPath";
            lblAvatarPath.Size = new System.Drawing.Size(430, 23);
            lblAvatarPath.TabIndex = 9;
            lblAvatarPath.Text = "(Chưa chọn ảnh)";
            // 
            // picAvatar
            // 
            picAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picAvatar.Location = new System.Drawing.Point(585, 20);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new System.Drawing.Size(110, 125);
            picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 10;
            picAvatar.TabStop = false;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnChooseAvatar.Location = new System.Drawing.Point(715, 20);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new System.Drawing.Size(125, 32);
            btnChooseAvatar.TabIndex = 11;
            btnChooseAvatar.Text = "Chọn ảnh...";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // grpActions
            // 
            grpActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpActions.Controls.Add(btnAdd);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnExportCsv);
            grpActions.Location = new System.Drawing.Point(12, 178);
            grpActions.Name = "grpActions";
            grpActions.Size = new System.Drawing.Size(860, 60);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Cụm chức năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(15, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(85, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(115, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(85, 28);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(215, 20);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(85, 28);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(315, 20);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(85, 28);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new System.Drawing.Point(415, 20);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new System.Drawing.Size(120, 28);
            btnExportCsv.TabIndex = 4;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // grpList
            // 
            grpList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpList.Controls.Add(dgvStudents);
            grpList.Location = new System.Drawing.Point(12, 244);
            grpList.Name = "grpList";
            grpList.Size = new System.Drawing.Size(860, 305);
            grpList.TabIndex = 2;
            grpList.TabStop = false;
            grpList.Text = "Danh sách hiển thị (DataGridView)";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStudents.Location = new System.Drawing.Point(3, 19);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new System.Drawing.Size(854, 283);
            dgvStudents.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 561);
            Controls.Add(grpList);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 4.6 - Quản lý Sinh viên (BindingSource & Xử lý File)";
            Load += Form1_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpActions.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
    }
}
