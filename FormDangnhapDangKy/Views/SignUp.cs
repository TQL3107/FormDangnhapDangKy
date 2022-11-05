using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDangnhapDangKy.Controllers;
using FormDangnhapDangKy.Models;
namespace FormDangnhapDangKy
{
    public partial class SignUp : Form
    {
        string imageUrl = ""; // thêm thuộc tính để chứa đường dẫn ảnh
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_Chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            ofd.ShowDialog();
            DialogResult result = MessageBox.Show("Bạn có muốn đổi ảnh đại điện hong?",
                "Đổi ảnh đại diện", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ptb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;// Cho vừa khung
                ptb_Avatar.Image = Image.FromFile(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Lựa chọn đúng đắn =))))) Bạn không phải weboo");
            }
            // thêm cái này
            imageUrl = ofd.FileName; // Lưu đường dẫn ảnh để lát tạo đối tượng

        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            TaikhoanServices tks = new TaikhoanServices();
            FilesServices fs = new FilesServices();
            Taikhoan tk = tks.TaoTaiKhoan(tbt_ten.Text, tbt_diachi.Text, cbb_gioitinh.Text,
                tbt_cancuoc.Text,tbt_Tendangnhap.Text, tbt_matkhau.Text, dtp_DOB.Value, imageUrl);
            string path = @"C:\Users\DELL\source\repos\FormDangnhapDangKy\FormDangnhapDangKy\Taikhoans.xml";
            fs.WriteSVtoXML<Taikhoan>(path, tk);
            MessageBox.Show("Đăng kí thành công");
            this.Close();
        }
    }
}
