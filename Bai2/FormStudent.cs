using System.ComponentModel;
using System.Text;

namespace Bai2
{
    public partial class FormStudent : Form
    {
        private readonly BindingList<Student> listStudents = new BindingList<Student>();
        private readonly BindingSource bindingSource = new BindingSource();
        private string currentAvatarPath = string.Empty;
        private int autoIdCounter = 1;

        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;

            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string imgDir = Path.Combine(appDir, "Images");
            ImageHelper.EnsureSampleAvatars(imgDir);

            ConfigureDataGridView();

            bindingSource.DataSource = listStudents;
            dgvStudents.DataSource = bindingSource;

            SetupDataBindings();

            LoadInitialData(imgDir);

            bindingSource.CurrentChanged += BindingSource_CurrentChanged;

            if (bindingSource.Current is Student firstStudent)
            {
                UpdateAvatarDisplay(firstStudent.AvatarPath);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Clear();
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.ReadOnly = true;
            dgvStudents.MultiSelect = false;

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Student.StudentId),
                HeaderText = "Mã SV",
                Width = 90
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Student.FullName),
                HeaderText = "Họ tên",
                Width = 200
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Student.Age),
                HeaderText = "Tuổi",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Student.Gender),
                HeaderText = "Giới tính",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Student.AvatarPath),
                HeaderText = "Đường dẫn ảnh",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void SetupDataBindings()
        {
            txtStudentId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            cboGender.DataBindings.Clear();
            lblAvatarPath.DataBindings.Clear();

            txtStudentId.DataBindings.Add(new Binding("Text", bindingSource, nameof(Student.StudentId), true, DataSourceUpdateMode.Never));
            txtFullName.DataBindings.Add(new Binding("Text", bindingSource, nameof(Student.FullName), true, DataSourceUpdateMode.Never));
            txtAge.DataBindings.Add(new Binding("Text", bindingSource, nameof(Student.Age), true, DataSourceUpdateMode.Never));
            cboGender.DataBindings.Add(new Binding("Text", bindingSource, nameof(Student.Gender), true, DataSourceUpdateMode.Never));
            lblAvatarPath.DataBindings.Add(new Binding("Text", bindingSource, nameof(Student.AvatarPath), true, DataSourceUpdateMode.Never));
        }

        private void LoadInitialData(string imgDir)
        {
            string avt1 = Path.Combine(imgDir, "avatar1.png");
            string avt2 = Path.Combine(imgDir, "avatar2.png");
            string avt3 = Path.Combine(imgDir, "avatar3.png");

            listStudents.Add(new Student("SV01", "Nguyễn Văn An", 20, "Nam", avt1));
            listStudents.Add(new Student("SV02", "Trần Thị Mai", 21, "Nữ", avt2));
            listStudents.Add(new Student("SV03", "Lê Hoàng Nam", 22, "Nam", avt3));

            autoIdCounter = 4;
            NotifyParent("Đã nạp danh sách sinh viên ban đầu.");
        }

        private void BindingSource_CurrentChanged(object? sender, EventArgs e)
        {
            if (bindingSource.Current is Student student)
            {
                UpdateAvatarDisplay(student.AvatarPath);
                errorProvider1.Clear();
            }
            else
            {
                UpdateAvatarDisplay(null);
            }
        }

        private void UpdateAvatarDisplay(string? path)
        {
            currentAvatarPath = path ?? string.Empty;
            lblAvatarPath.Text = string.IsNullOrWhiteSpace(currentAvatarPath) ? "(Chưa chọn ảnh)" : currentAvatarPath;

            picAvatar.Image?.Dispose();
            picAvatar.Image = ImageHelper.LoadImageSafely(currentAvatarPath);
        }

        private bool ValidateInput(out int age)
        {
            bool isValid = true;
            age = 0;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider1.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "Họ tên không được để trống!");
                isValid = false;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out age) || age <= 0 || age > 120)
            {
                errorProvider1.SetError(txtAge, "Tuổi phải là số nguyên dương hợp lệ (1 - 120)!");
                isValid = false;
            }

            if (cboGender.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboGender, "Vui lòng chọn giới tính!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out int age)) return;

            string id = txtStudentId.Text.Trim();
            if (listStudents.Any(s => s.StudentId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtStudentId, "Mã sinh viên đã tồn tại trong danh sách!");
                MessageBox.Show($"Mã sinh viên '{id}' đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newStudent = new Student(id, txtFullName.Text.Trim(), age, cboGender.Text, currentAvatarPath);
            listStudents.Add(newStudent);
            bindingSource.Position = listStudents.IndexOf(newStudent);

            NotifyParent($"Đã thêm sinh viên: [{newStudent.StudentId}] {newStudent.FullName}");
            MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentItem)
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên [{currentItem.StudentId} - {currentItem.FullName}]?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string info = $"[{currentItem.StudentId}] {currentItem.FullName}";
                    listStudents.Remove(currentItem);

                    NotifyParent($"Đã xóa sinh viên: {info}");
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentItem)
            {
                if (!ValidateInput(out int age)) return;

                string newId = txtStudentId.Text.Trim();
                if (!currentItem.StudentId.Equals(newId, StringComparison.OrdinalIgnoreCase) &&
                    listStudents.Any(s => s != currentItem && s.StudentId.Equals(newId, StringComparison.OrdinalIgnoreCase)))
                {
                    errorProvider1.SetError(txtStudentId, "Mã sinh viên này đã tồn tại!");
                    MessageBox.Show($"Mã sinh viên '{newId}' đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentItem.StudentId = newId;
                currentItem.FullName = txtFullName.Text.Trim();
                currentItem.Age = age;
                currentItem.Gender = cboGender.Text;
                currentItem.AvatarPath = currentAvatarPath;

                bindingSource.ResetCurrentItem();
                NotifyParent($"Đã cập nhật sinh viên: [{currentItem.StudentId}] {currentItem.FullName}");
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvStudents.ClearSelection();
            txtStudentId.Text = $"SV{autoIdCounter:D2}";
            autoIdCounter++;
            txtFullName.Clear();
            txtAge.Text = "20";
            cboGender.SelectedIndex = 0;
            currentAvatarPath = string.Empty;
            lblAvatarPath.Text = "(Chưa chọn ảnh)";
            picAvatar.Image?.Dispose();
            picAvatar.Image = null;
            errorProvider1.Clear();
            txtFullName.Focus();
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh đại diện";
            ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentAvatarPath = ofd.FileName;
                lblAvatarPath.Text = currentAvatarPath;

                picAvatar.Image?.Dispose();
                picAvatar.Image = ImageHelper.LoadImageSafely(currentAvatarPath);

                if (bindingSource.Current is Student currentItem)
                {
                    currentItem.AvatarPath = currentAvatarPath;
                    bindingSource.ResetCurrentItem();
                }
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (listStudents.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống, không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var sfd = new SaveFileDialog();
            sfd.Title = "Xuất danh sách sinh viên ra file CSV";
            sfd.Filter = "Tệp CSV (*.csv)|*.csv|Tất cả tệp (*.*)|*.*";
            sfd.FileName = $"DanhSachSinhVien_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã SV,Họ tên,Tuổi,Giới tính,Đường dẫn ảnh");

                    foreach (var s in listStudents)
                    {
                        sb.AppendLine($"{EscapeCsv(s.StudentId)},{EscapeCsv(s.FullName)},{s.Age},{EscapeCsv(s.Gender)},{EscapeCsv(s.AvatarPath)}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                    NotifyParent($"Xuất file CSV thành công: {Path.GetFileName(sfd.FileName)}");
                    MessageBox.Show("Xuất dữ liệu ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvStudents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvStudents.ClearSelection();
                dgvStudents.Rows[e.RowIndex].Selected = true;
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
            if (bindingSource.Current is Student currentItem)
            {
                UpdateAvatarDisplay(currentItem.AvatarPath);
            }
            NotifyParent("Đã làm mới dữ liệu danh sách sinh viên.");
        }

        private void tsmiViewDetail_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentItem)
            {
                using var frmDetail = new FormDetailStudent(currentItem);
                frmDetail.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
