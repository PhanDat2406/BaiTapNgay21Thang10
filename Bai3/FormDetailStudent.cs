namespace Bai3
{
    public partial class FormDetailStudent : Form
    {
        public FormDetailStudent()
        {
            InitializeComponent();
        }

        public FormDetailStudent(Student student) : this()
        {
            SetStudent(student);
        }

        public void SetStudent(Student student)
        {
            if (student == null) return;

            lblStudentId.Text = student.StudentId;
            lblFullName.Text = student.FullName;
            lblAge.Text = student.Age.ToString();
            lblGender.Text = student.Gender;
            lblAvatarPath.Text = string.IsNullOrWhiteSpace(student.AvatarPath) ? "(Chưa có ảnh)" : student.AvatarPath;

            picAvatar.Image?.Dispose();
            picAvatar.Image = ImageHelper.LoadImageSafely(student.AvatarPath);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
