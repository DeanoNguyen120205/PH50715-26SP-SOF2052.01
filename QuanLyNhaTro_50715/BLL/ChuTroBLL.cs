using DuAnMau_QuanLyPhongtro_PH50715.DAL;
using System.Data;

namespace DuAnMau_QuanLyPhongtro_PH50715.BLL
{
    public static class ChuTroBLL
    {
        public static DataTable GetAll()
        {
            return ChuTroDAL.SelectAll();
        }

        public static void Insert(string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            ChuTroDAL.Insert(ten, gioiTinh, cccd, sdt, tuoi);
        }

        public static void Update(int id, string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            ChuTroDAL.Update(id, ten, gioiTinh, cccd, sdt, tuoi);
        }

        public static void Delete(int id)
        {
            ChuTroDAL.Delete(id);
        }
    }
}
