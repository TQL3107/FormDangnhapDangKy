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

namespace FormDangnhapDangKy.Views
{
    public partial class AllTaiKhoans : Form
    {
        public AllTaiKhoans()
        {
            InitializeComponent();
        }

        private void AllTaiKhoans_Load(object sender, EventArgs e)
        {
            // Fake data - tạo 1 list tài khoản
            List<Taikhoan> taikhoans = new List<Taikhoan>()
            {
                new Taikhoan("1", "1", "Nam", "11111111", "a", "a", DateTime.Now, "url"),
                new Taikhoan("2", "2", "Nam", "11111111", "a", "a", DateTime.Now, "url"),
                new Taikhoan("3", "3", "Nam", "11111111", "a", "a", DateTime.Now, "url"),
                new Taikhoan("4", "4", "Nam", "11111111", "a", "a", DateTime.Now, "url"),
                new Taikhoan("5", "5", "Nam", "11111111", "a", "a", DateTime.Now, "url")
            };
            dtg_Show.DataSource = taikhoans;
            // Đặt tên cho cột
            dtg_Show.Columns[0].HeaderCell.Value = "Cột tên";
            dtg_Show.Columns[1].HeaderCell.Value = "Cột tuổi";
        }
    }
}
