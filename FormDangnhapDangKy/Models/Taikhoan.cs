using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangnhapDangKy.Models
{
    [Serializable]
    public class Taikhoan
    {
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Gioitinh { get; set; }
        public string CMT { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        public string ImagePath { get; set; }

        public Taikhoan()
        {
        }

        public Taikhoan(string ten, string diachi, string gioitinh, string cMT, string username, string password, DateTime dOB, string imagePath)
        {
            Ten = ten;
            Diachi = diachi;
            Gioitinh = gioitinh;
            CMT = cMT;
            Username = username;
            Password = password;
            DOB = dOB;
            ImagePath = imagePath;
        }
    }
}
