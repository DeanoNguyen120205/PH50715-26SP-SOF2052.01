using DuAnMau_QuanLyPhongtro_PH50715.DAL;
using System.Data;

namespace DuAnMau_QuanLyPhongtro_PH50715.BLL
{
    public static class KhachThueBLL
    {
        public static DataTable GetAll()
        {
            return KhachThueDAL.SelectAll();
        }

        public static void Add(string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            KhachThueDAL.Insert(ten, gioiTinh, cccd, sdt, tuoi);
        }

        public static void Update(int id, string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            KhachThueDAL.Update(id, ten, gioiTinh, cccd, sdt, tuoi);
        }

        public static void Delete(int id)
        {
            KhachThueDAL.Delete(id);
        }
    }
}
