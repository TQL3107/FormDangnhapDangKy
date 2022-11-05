using FormDangnhapDangKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormDangnhapDangKy.Controllers
{
    internal class TaikhoanServices
    {
        public Taikhoan TaoTaiKhoan(string ten, string diachi, string gioitinh, string cMT,
            string username, string password, DateTime dOB, string imagePath)
        {
            return new Taikhoan(ten, diachi, gioitinh, cMT, username, password, dOB, imagePath);
        }

        public Taikhoan LayTaiKhoanTuList(List<Taikhoan> taikhoans, string tentk, string matkhau)
        {
            Taikhoan x = taikhoans.FirstOrDefault(p => p.Username == tentk && p.Password == matkhau);
            return x;
        }

    }
}
