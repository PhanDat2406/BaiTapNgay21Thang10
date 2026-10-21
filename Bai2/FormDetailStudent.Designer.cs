namespace Bai2
{
    partial class FormDetailStudent
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblIdTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblAgeTitle;
        private System.Windows.Forms.Label lblGenderTitle;
        private System.Windows.Forms.Label lblAvatarTitle;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAvatarPath;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnClose;

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
            grpInfo = new System.Windows.Forms.GroupBox();
            lblIdTitle = new System.Windows.Forms.Label();
            lblStudentId = new System.Windows.Forms.Label();
            lblNameTitle = new System.Windows.Forms.Label();
            lblFullName = new System.Windows.Forms.Label();
            lblAgeTitle = new System.Windows.Forms.Label();
            lblAge = new System.Windows.Forms.Label();
            lblGenderTitle = new System.Windows.Forms.Label();
            lblGender = new System.Windows.Forms.Label();
            lblAvatarTitle = new System.Windows.Forms.Label();
            lblAvatarPath = new System.Windows.Forms.Label();
            picAvatar = new System.Windows.Forms.PictureBox();
            btnClose = new System.Windows.Forms.Button();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // grpInfo
            // 
            grpInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpInfo.Controls.Add(lblIdTitle);
            grpInfo.Controls.Add(lblStudentId);
            grpInfo.Controls.Add(lblNameTitle);
            grpInfo.Controls.Add(lblFullName);
            grpInfo.Controls.Add(lblAgeTitle);
            grpInfo.Controls.Add(lblAge);
            grpInfo.Controls.Add(lblGenderTitle);
            grpInfo.Controls.Add(lblGender);
            grpInfo.Controls.Add(lblAvatarTitle);
            grpInfo.Controls.Add(lblAvatarPath);
            grpInfo.Controls.Add(picAvatar);
            grpInfo.Location = new System.Drawing.Point(12, 12);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new System.Drawing.Size(460, 240);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin chi tiết sinh viên";
            // 
            // lblIdTitle
            // 
            lblIdTitle.AutoSize = true;
            lblIdTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblIdTitle.Location = new System.Drawing.Point(160, 30);
            lblIdTitle.Name = "lblIdTitle";
            lblIdTitle.Size = new System.Drawing.Size(46, 15);
            lblIdTitle.TabIndex = 0;
            lblIdTitle.Text = "Mã SV:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new System.Drawing.Point(230, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new System.Drawing.Size(38, 15);
            lblStudentId.TabIndex = 1;
            lblStudentId.Text = "label1";
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblNameTitle.Location = new System.Drawing.Point(160, 65);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new System.Drawing.Size(48, 15);
            lblNameTitle.TabIndex = 2;
            lblNameTitle.Text = "Họ tên:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(230, 65);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(38, 15);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "label2";
            // 
            // lblAgeTitle
            // 
            lblAgeTitle.AutoSize = true;
            lblAgeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAgeTitle.Location = new System.Drawing.Point(160, 100);
            lblAgeTitle.Name = "lblAgeTitle";
            lblAgeTitle.Size = new System.Drawing.Size(34, 15);
            lblAgeTitle.TabIndex = 4;
            lblAgeTitle.Text = "Tuổi:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(230, 100);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(38, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "label3";
            // 
            // lblGenderTitle
            // 
            lblGenderTitle.AutoSize = true;
            lblGenderTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblGenderTitle.Location = new System.Drawing.Point(160, 135);
            lblGenderTitle.Name = "lblGenderTitle";
            lblGenderTitle.Size = new System.Drawing.Size(58, 15);
            lblGenderTitle.TabIndex = 6;
            lblGenderTitle.Text = "Giới tính:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(230, 135);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(38, 15);
            lblGender.TabIndex = 7;
            lblGender.Text = "label4";
            // 
            // lblAvatarTitle
            // 
            lblAvatarTitle.AutoSize = true;
            lblAvatarTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAvatarTitle.Location = new System.Drawing.Point(160, 170);
            lblAvatarTitle.Name = "lblAvatarTitle";
            lblAvatarTitle.Size = new System.Drawing.Size(51, 15);
            lblAvatarTitle.TabIndex = 8;
            lblAvatarTitle.Text = "Tệp ảnh:";
            // 
            // lblAvatarPath
            // 
            lblAvatarPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAvatarPath.AutoEllipsis = true;
            lblAvatarPath.Location = new System.Drawing.Point(230, 170);
            lblAvatarPath.Name = "lblAvatarPath";
            lblAvatarPath.Size = new System.Drawing.Size(215, 45);
            lblAvatarPath.TabIndex = 9;
            lblAvatarPath.Text = "(Không có)";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picAvatar.Location = new System.Drawing.Point(15, 30);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new System.Drawing.Size(130, 150);
            picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 10;
            picAvatar.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnClose.Location = new System.Drawing.Point(387, 260);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(85, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormDetailStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 301);
            Controls.Add(btnClose);
            Controls.Add(grpInfo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDetailStudent";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Chi tiết sinh viên";
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }
    }
}
