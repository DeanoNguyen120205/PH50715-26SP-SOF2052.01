using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAO
{
    public class ThanhToan
    {
        public int IdThanhToan { get; set; }

        public int IdHoaDonDichVu { get; set; }

        public decimal TongTien { get; set; }

        public DateTime NgayThanhToan { get; set; }

        public string PhuongThuc { get; set; }

        public string NguoiThanhToan { get; set; }

        public string GhiChu { get; set; }

    }
}
