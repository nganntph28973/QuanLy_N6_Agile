using QuanLy_N6_Agile.Models;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace QuanLy_N6_Agile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QL_N6_AgileContext db = new QL_N6_AgileContext();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUers.Text;
            string password = txtPass.Text;
            using (QL_N6_AgileContext context = new QL_N6_AgileContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    int role = int.Parse(user.Role);
                    OpenAppropriateForm(role);
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
                    ResetLoginForm();
                }
            }

        }

        private void OpenAppropriateForm(int role)
        {
            switch (role)
            {
                case 0:
                    MessageBox.Show("Đăng Nhập Với Vai Trò Cán Bộ Đào Tạo");
                    // Mở form cho Cán bộ đào tạo
                    ResetLoginForm();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    break;
                case 1:
                    // Mở form cho Giảng viên
                    MessageBox.Show("Đăng Nhập Với Vai Trò Giảng Viên");
                    ResetLoginForm();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        private void ResetLoginForm()
        {
            txtUers.Text = "";
            txtPass.Text = "";
            txtUers.Focus();
        }

        private void chkS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkS.Checked)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}

