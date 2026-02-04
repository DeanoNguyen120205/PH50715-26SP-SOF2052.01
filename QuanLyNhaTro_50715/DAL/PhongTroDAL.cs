using DuAnMau_QuanLyPhongtro_PH50715.Utils;
using System.Collections.Generic;
using System.Data;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
{
    public static class PhongTroDAL
    {
        public static DataTable SelectAll()
        {
            DBUltil.OpenConnection();
            DataTable dt = DBUltil.ExecuteQueryTable(
                "SELECT * FROM Phong_Tro",
                null
            );
            DBUltil.CloseConnection();
            return dt;
        }

        public static void Insert(string maPhong, double dienTich, decimal giaThue,
                                  string trangThai, string tienIch,
                                  string tinhTrang, string moTa)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                @"INSERT INTO Phong_Tro
                (maPhong, dienTich, giaThue, trangThai, tienIch, tinhTrangPhong, moTaThem)
                VALUES (@0,@1,@2,@3,@4,@5,@6)",
                new List<object>
                {
                    maPhong, dienTich, giaThue, trangThai, tienIch, tinhTrang, moTa
                }
            );
            DBUltil.CloseConnection();
        }

        public static void Update(int id, string maPhong, double dienTich, decimal giaThue,
                                  string trangThai, string tienIch,
                                  string tinhTrang, string moTa)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                @"UPDATE Phong_Tro SET
                    maPhong=@0,
                    dienTich=@1,
                    giaThue=@2,
                    trangThai=@3,
                    tienIch=@4,
                    tinhTrangPhong=@5,
                    moTaThem=@6
                  WHERE idPhong=@7",
                new List<object>
                {
                    maPhong, dienTich, giaThue, trangThai, tienIch, tinhTrang, moTa, id
                }
            );
            DBUltil.CloseConnection();
        }

        public static void Delete(int id)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                "DELETE FROM Phong_Tro WHERE idPhong=@0",
                new List<object> { id }
            );
            DBUltil.CloseConnection();
        }
    }
}
