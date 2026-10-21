namespace Bai2
{
    partial class FormProduct
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip cmsProductGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshData;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewDetail;
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
            lblId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            lblPrice = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            lblQuantity = new System.Windows.Forms.Label();
            numQuantity = new System.Windows.Forms.NumericUpDown();
            grpActions = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExportCsv = new System.Windows.Forms.Button();
            grpList = new System.Windows.Forms.GroupBox();
            dgvProducts = new System.Windows.Forms.DataGridView();
            cmsProductGrid = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            tsmiRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            tsmiViewDetail = new System.Windows.Forms.ToolStripMenuItem();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            grpActions.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            cmsProductGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpInput.Controls.Add(lblId);
            grpInput.Controls.Add(txtId);
            grpInput.Controls.Add(lblName);
            grpInput.Controls.Add(txtName);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(numQuantity);
            grpInput.Location = new System.Drawing.Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new System.Drawing.Size(860, 115);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sản phẩm";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(15, 28);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(43, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Mã SP:";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(75, 25);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(160, 23);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(15, 68);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(46, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Tên SP:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(75, 65);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(160, 23);
            txtName.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(270, 28);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(63, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Phân loại:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Phụ kiện", "Gia dụng", "Thiết bị văn phòng" });
            cboCategory.Location = new System.Drawing.Point(345, 25);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(160, 23);
            cboCategory.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(270, 68);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(51, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Đơn giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(345, 65);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(160, 23);
            txtPrice.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(545, 28);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(57, 15);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new System.Drawing.Point(615, 25);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new System.Drawing.Size(120, 23);
            numQuantity.TabIndex = 9;
            // 
            // grpActions
            // 
            grpActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpActions.Controls.Add(btnAdd);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnExportCsv);
            grpActions.Location = new System.Drawing.Point(12, 133);
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
            grpList.Controls.Add(dgvProducts);
            grpList.Location = new System.Drawing.Point(12, 199);
            grpList.Name = "grpList";
            grpList.Size = new System.Drawing.Size(860, 350);
            grpList.TabIndex = 2;
            grpList.TabStop = false;
            grpList.Text = "Danh sách sản phẩm (Chuột phải để mở menu)";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ContextMenuStrip = cmsProductGrid;
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProducts.Location = new System.Drawing.Point(3, 19);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new System.Drawing.Size(854, 328);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellMouseDown += dgvProducts_CellMouseDown;
            // 
            // cmsProductGrid
            // 
            cmsProductGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiDeleteRow, tsmiRefreshData, tsmiViewDetail });
            cmsProductGrid.Name = "cmsProductGrid";
            cmsProductGrid.Size = new System.Drawing.Size(157, 70);
            // 
            // tsmiDeleteRow
            // 
            tsmiDeleteRow.Name = "tsmiDeleteRow";
            tsmiDeleteRow.Size = new System.Drawing.Size(156, 22);
            tsmiDeleteRow.Text = "Xóa dòng";
            tsmiDeleteRow.Click += tsmiDeleteRow_Click;
            // 
            // tsmiRefreshData
            // 
            tsmiRefreshData.Name = "tsmiRefreshData";
            tsmiRefreshData.Size = new System.Drawing.Size(156, 22);
            tsmiRefreshData.Text = "Làm mới dữ liệu";
            tsmiRefreshData.Click += tsmiRefreshData_Click;
            // 
            // tsmiViewDetail
            // 
            tsmiViewDetail.Name = "tsmiViewDetail";
            tsmiViewDetail.Size = new System.Drawing.Size(156, 22);
            tsmiViewDetail.Text = "Xem chi tiết";
            tsmiViewDetail.Click += tsmiViewDetail_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 561);
            Controls.Add(grpList);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "FormProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý Sản phẩm";
            Load += FormProduct_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            grpActions.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            cmsProductGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
    }
}
