namespace FormDangnhapDangKy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            if(tb_Tendangnhap.Text.Trim() == "" || tb_Matkhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập và mật khẩu");
            }else if (!cb_Nguoimay.Checked)
            {
                MessageBox.Show("Bạn là người máy ư?");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                Infor infor = new Infor();
                infor.ShowDialog();
            }
        }

        private void lb_Dangky_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void lb_QuenMK_Click(object sender, EventArgs e)
        {
            Forgot fg = new Forgot();
            fg.ShowDialog();
        }

        private void lb_Dangky_MouseHover(object sender, EventArgs e)
        {
            lb_Dangky.BackColor = Color.Yellow;
        }

        private void lb_Dangky_MouseLeave(object sender, EventArgs e)
        {
            lb_Dangky.BackColor = this.BackColor;
        }
    }
}