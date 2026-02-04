using DuAnMau_QuanLyPhongtro_PH50715.DAL;
using System.Data;

namespace DuAnMau_QuanLyPhongtro_PH50715.BLL
{
    public static class PhongTroBLL
    {
        public static DataTable GetAll()
        {
            return PhongTroDAL.SelectAll();
        }

        public static void Add(string maPhong, double dienTich, decimal giaThue,
                               string trangThai, string tienIch,
                               string tinhTrang, string moTa)
        {
            PhongTroDAL.Insert(maPhong, dienTich, giaThue, trangThai, tienIch, tinhTrang, moTa);
        }

        public static void Update(int id, string maPhong, double dienTich, decimal giaThue,
                                  string trangThai, string tienIch,
                                  string tinhTrang, string moTa)
        {
            PhongTroDAL.Update(id, maPhong, dienTich, giaThue, trangThai, tienIch, tinhTrang, moTa);
        }

        public static void Delete(int id)
        {
            PhongTroDAL.Delete(id);
        }
    }
}
