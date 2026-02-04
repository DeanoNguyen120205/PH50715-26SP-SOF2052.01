using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAO
{
    public class HopDongThue
    {
        public int IdHopDong { get; set; }

        public string MaHopDong { get; set; }

        public DateTime NgayTao { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public decimal GiaThueThoaThuan { get; set; }

        public int ThoiGianThue { get; set; }

        public decimal TienCoc { get; set; }

        public string TrangThaiHopDong { get; set; }

        public int IdPhong { get; set; }

        public int IdKhachThue { get; set; }

        public int IdChuTro { get; set; }

    }
}
