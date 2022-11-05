using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangnhapDangKy
{
    public partial class SignUp : Form
    {
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
            
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng kí thành công");
            this.Close();
        }
    }
}
