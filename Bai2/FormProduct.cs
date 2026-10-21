using System.ComponentModel;
using System.Text;

namespace Bai2
{
    public partial class FormProduct : Form
    {
        private readonly BindingList<Product> listProducts = new BindingList<Product>();
        private readonly BindingSource bindingSource = new BindingSource();
        private int autoIdCounter = 1;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }

            ConfigureDataGridView();

            bindingSource.DataSource = listProducts;
            dgvProducts.DataSource = bindingSource;

            SetupDataBindings();
            LoadInitialData();

            bindingSource.CurrentChanged += (s, ev) => errorProvider1.Clear();
        }

        private void ConfigureDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Id),
                HeaderText = "Mã SP",
                Width = 90
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Name),
                HeaderText = "Tên SP",
                Width = 220
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Category),
                HeaderText = "Phân loại",
                Width = 140
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Price),
                HeaderText = "Đơn giá",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Quantity),
                HeaderText = "Số lượng",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.TotalValue),
                HeaderText = "Thành tiền",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void SetupDataBindings()
        {
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            numQuantity.DataBindings.Clear();

            txtId.DataBindings.Add(new Binding("Text", bindingSource, nameof(Product.Id), true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", bindingSource, nameof(Product.Name), true, DataSourceUpdateMode.Never));
            cboCategory.DataBindings.Add(new Binding("Text", bindingSource, nameof(Product.Category), true, DataSourceUpdateMode.Never));

            var priceBinding = new Binding("Text", bindingSource, nameof(Product.Price), true, DataSourceUpdateMode.Never);
            priceBinding.Format += (s, e) =>
            {
                if (e.Value is decimal val)
                {
                    e.Value = val.ToString("N0");
                }
            };
            txtPrice.DataBindings.Add(priceBinding);

            numQuantity.DataBindings.Add(new Binding("Value", bindingSource, nameof(Product.Quantity), true, DataSourceUpdateMode.Never));
        }

        private void LoadInitialData()
        {
            listProducts.Add(new Product("SP01", "Điện thoại Samsung S24", "Điện thoại", 22000000m, 15));
            listProducts.Add(new Product("SP02", "Laptop Dell XPS 15", "Laptop", 35000000m, 8));
            listProducts.Add(new Product("SP03", "Bàn phím cơ Logitech", "Phụ kiện", 1850000m, 30));

            autoIdCounter = 4;
            NotifyParent("Đã nạp danh sách sản phẩm ban đầu.");
        }

        private bool ValidateInput(out decimal price)
        {
            bool isValid = true;
            price = 0;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Mã sản phẩm không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Tên sản phẩm không được để trống!");
                isValid = false;
            }

            if (cboCategory.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboCategory, "Vui lòng chọn phân loại!");
                isValid = false;
            }

            string cleanPrice = txtPrice.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(cleanPrice, out price) || price < 0)
            {
                errorProvider1.SetError(txtPrice, "Đơn giá phải là số hợp lệ >= 0!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal price)) return;

            string id = txtId.Text.Trim();
            if (listProducts.Any(p => p.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtId, "Mã sản phẩm đã tồn tại trong danh sách!");
                MessageBox.Show($"Mã sản phẩm '{id}' đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newProduct = new Product(id, txtName.Text.Trim(), cboCategory.Text, price, (int)numQuantity.Value);
            listProducts.Add(newProduct);
            bindingSource.Position = listProducts.IndexOf(newProduct);

            NotifyParent($"Đã thêm sản phẩm: [{newProduct.Id}] {newProduct.Name}");
            MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Product current)
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm [{current.Id} - {current.Name}]?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string info = $"[{current.Id}] {current.Name}";
                    listProducts.Remove(current);

                    NotifyParent($"Đã xóa sản phẩm: {info}");
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Product current)
            {
                if (!ValidateInput(out decimal price)) return;

                string newId = txtId.Text.Trim();
                if (!current.Id.Equals(newId, StringComparison.OrdinalIgnoreCase) &&
                    listProducts.Any(p => p != current && p.Id.Equals(newId, StringComparison.OrdinalIgnoreCase)))
                {
                    errorProvider1.SetError(txtId, "Mã sản phẩm đã tồn tại!");
                    MessageBox.Show($"Mã sản phẩm '{newId}' đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                current.Id = newId;
                current.Name = txtName.Text.Trim();
                current.Category = cboCategory.Text;
                current.Price = price;
                current.Quantity = (int)numQuantity.Value;

                bindingSource.ResetCurrentItem();
                NotifyParent($"Đã cập nhật sản phẩm: [{current.Id}] {current.Name}");
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            txtId.Text = $"SP{autoIdCounter:D2}";
            autoIdCounter++;
            txtName.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtPrice.Clear();
            numQuantity.Value = 1;
            errorProvider1.Clear();
            txtName.Focus();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (listProducts.Count == 0)
            {
                MessageBox.Show("Danh sách sản phẩm trống, không thể xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var sfd = new SaveFileDialog();
            sfd.Title = "Xuất danh sách sản phẩm ra file CSV";
            sfd.Filter = "Tệp CSV (*.csv)|*.csv|Tất cả tệp (*.*)|*.*";
            sfd.FileName = $"DanhSachSanPham_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã SP,Tên SP,Phân loại,Đơn giá,Số lượng,Thành tiền");

                    foreach (var p in listProducts)
                    {
                        sb.AppendLine($"{EscapeCsv(p.Id)},{EscapeCsv(p.Name)},{EscapeCsv(p.Category)},{p.Price},{p.Quantity},{p.TotalValue}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                    NotifyParent($"Xuất file CSV sản phẩm thành công: {Path.GetFileName(sfd.FileName)}");
                    MessageBox.Show("Xuất danh sách sản phẩm ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi ghi file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string EscapeCsv(string field)
        {
            if (string.IsNullOrEmpty(field)) return string.Empty;
            if (field.Contains(',') || field.Contains('"') || field.Contains('\n') || field.Contains('\r'))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            return field;
        }

        private void dgvProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvProducts.ClearSelection();
                dgvProducts.Rows[e.RowIndex].Selected = true;
                bindingSource.Position = e.RowIndex;
            }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void tsmiRefreshData_Click(object sender, EventArgs e)
        {
            bindingSource.ResetBindings(false);
            NotifyParent("Đã làm mới danh sách sản phẩm.");
        }

        private void tsmiViewDetail_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Product p)
            {
                MessageBox.Show(
                    $"Mã SP: {p.Id}\nTên SP: {p.Name}\nPhân loại: {p.Category}\nĐơn giá: {p.Price:N0} VNĐ\nSố lượng: {p.Quantity}\nThành tiền: {p.TotalValue:N0} VNĐ",
                    "Chi tiết sản phẩm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void NotifyParent(string message)
        {
            if (this.MdiParent is IMdiParentForm parentForm)
            {
                parentForm.UpdateStatusMessage(message);
            }
        }
    }
}
