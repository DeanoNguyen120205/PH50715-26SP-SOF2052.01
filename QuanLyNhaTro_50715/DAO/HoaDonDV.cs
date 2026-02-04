using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAO
{
    public class HoaDonDV
    {
        public int IdHoaDonDichVu { get; set; }

        public int IdHopDong { get; set; }

        public string ThangNam { get; set; }

        public DateTime NgayLapHoaDon { get; set; }

        public DateTime HanThanhToan { get; set; }

        public decimal TongTienPhong { get; set; }

        public decimal TongTienDichVu { get; set; }

        public decimal TongTienPhongDV { get; set; }

        public string TrangThai { get; set; }
    }
}
