using FormDangnhapDangKy.Controllers;
using FormDangnhapDangKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDangnhapDangKy.Views;


namespace FormDangnhapDangKy
{
    public partial class Infor : Form
    {
        public Taikhoan Taikhoan { get; set; }// thêm cái này để truyền dữ liệu giữa các form

        public Infor()
        {
            InitializeComponent();
        }
    
        private void cb_Capnhat_CheckedChanged(object sender, EventArgs e)
        {
            bool capnhat = cb_Capnhat.Checked;
            tbt_ten.Enabled = capnhat;
            tbt_diachi.Enabled = capnhat;
            tbt_cancuoc.Enabled = capnhat;
            cbb_gioitinh.Enabled = capnhat;
            btn_Chonanh.Visible = capnhat; // Visibale = Có hiện ra hay không
            btn_capnhat.Visible = capnhat;
        }

        private void Infor_Load(object sender, EventArgs e) // Khi load form nó mặc định set như thế này
        {
            bool capnhat = cb_Capnhat.Checked;
            tbt_ten.Enabled = capnhat;
            tbt_diachi.Enabled = capnhat;
            tbt_cancuoc.Enabled = capnhat;
            cbb_gioitinh.Enabled = capnhat;
            btn_Chonanh.Visible = capnhat;
            btn_capnhat.Visible = capnhat;
            // 
            tbt_cancuoc.Text = Taikhoan.CMT;
            tbt_diachi.Text = Taikhoan.Diachi;
            tbt_ten.Text = Taikhoan.Ten;
            cbb_gioitinh.Text = Taikhoan.Gioitinh;
            dtp_Namsinh.Value = Taikhoan.DOB;
            ptb_Avatar.Image = Image.FromFile(Taikhoan.ImagePath);
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            if (Taikhoan.Username.ToLower().Contains("admin"))
            {
                AllTaiKhoans atk = new AllTaiKhoans();
                atk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải là admin để thực hiện tính năng này");
            }
        }
    }
}
