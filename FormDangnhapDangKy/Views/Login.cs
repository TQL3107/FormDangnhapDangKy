using FormDangnhapDangKy.Controllers;
using FormDangnhapDangKy.Models;
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
                FilesServices fs = new FilesServices();
                TaikhoanServices tks = new TaikhoanServices();
                string path = @"C:\Users\DELL\source\repos\FormDangnhapDangKy\FormDangnhapDangKy\Taikhoans.xml";
                List<Taikhoan> allTK = fs.ReadSVfromXML<Taikhoan>(path);
                if(allTK != null)
                {
                    Taikhoan tk = tks.LayTaiKhoanTuList(allTK, tb_Tendangnhap.Text, tb_Matkhau.Text);
                    if (tk == null)
                    {
                        MessageBox.Show("Đăng nhập thất bại, sai thông tin tài khoản");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        Infor infor = new Infor(); // Truyền tài khoản từ form này sang form kia
                        infor.Taikhoan = tk; // gán tài khoản đã đăng nhập cho form Infor 
                        infor.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, bạn cần tạo tài khoản trước đã");
                }
                     
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