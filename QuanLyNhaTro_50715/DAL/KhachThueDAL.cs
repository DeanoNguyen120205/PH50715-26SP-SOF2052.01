using DuAnMau_QuanLyPhongtro_PH50715.Utils;
using System.Collections.Generic;
using System.Data;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
{
    public static class KhachThueDAL
    {
        public static DataTable SelectAll()
        {
            DBUltil.OpenConnection();
            DataTable dt = DBUltil.ExecuteQueryTable(
                "SELECT * FROM Khach_Thue",
                null
            );
            DBUltil.CloseConnection();
            return dt;
        }

        public static void Insert(string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                @"INSERT INTO Khach_Thue
                  (tenKhachThue, gioiTinh_kh, soCanCuoc_kh, soDienThoai_kh, tuoi_kh)
                  VALUES (@0,@1,@2,@3,@4)",
                new List<object> { ten, gioiTinh, cccd, sdt, tuoi }
            );
            DBUltil.CloseConnection();
        }

        public static void Update(int id, string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                @"UPDATE Khach_Thue SET
                    tenKhachThue=@0,
                    gioiTinh_kh=@1,
                    soCanCuoc_kh=@2,
                    soDienThoai_kh=@3,
                    tuoi_kh=@4
                  WHERE idKhachThue=@5",
                new List<object> { ten, gioiTinh, cccd, sdt, tuoi, id }
            );
            DBUltil.CloseConnection();
        }

        public static void Delete(int id)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                "DELETE FROM Khach_Thue WHERE idKhachThue=@0",
                new List<object> { id }
            );
            DBUltil.CloseConnection();
        }
    }
}
