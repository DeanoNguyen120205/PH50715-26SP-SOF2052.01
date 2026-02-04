using DuAnMau_QuanLyPhongtro_PH50715.Utils;
using System.Collections.Generic;
using System.Data;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
{
    public static class ChuTroDAL
    {
        public static DataTable SelectAll()
        {
            DBUltil.OpenConnection();

            DataTable dt = DBUltil.ExecuteQueryTable(
                "SELECT * FROM Chu_Tro",
                null
            );

            DBUltil.CloseConnection();
            return dt;
        }

        public static void Insert(string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            DBUltil.OpenConnection();

            DBUltil.ExecuteNonQuery(
                @"INSERT INTO Chu_Tro
                  (tenChuTro, gioiTinh_ct, soCanCuoc_ct, soDienThoai_ct, tuoi_ct)
                  VALUES (@0,@1,@2,@3,@4)",
                new List<object> { ten, gioiTinh, cccd, sdt, tuoi }
            );

            DBUltil.CloseConnection();
        }

        public static void Update(int id, string ten, string gioiTinh, string cccd, string sdt, int tuoi)
        {
            DBUltil.OpenConnection();

            DBUltil.ExecuteNonQuery(
                @"UPDATE Chu_Tro SET
                    tenChuTro=@0,
                    gioiTinh_ct=@1,
                    soCanCuoc_ct=@2,
                    soDienThoai_ct=@3,
                    tuoi_ct=@4
                  WHERE idChuTro=@5",
                new List<object> { ten, gioiTinh, cccd, sdt, tuoi, id }
            );

            DBUltil.CloseConnection();
        }

        public static void Delete(int id)
        {
            DBUltil.OpenConnection();

            DBUltil.ExecuteNonQuery(
                "DELETE FROM Chu_Tro WHERE idChuTro=@0",
                new List<object> { id }
            );

            DBUltil.CloseConnection();
        }
    }
}
