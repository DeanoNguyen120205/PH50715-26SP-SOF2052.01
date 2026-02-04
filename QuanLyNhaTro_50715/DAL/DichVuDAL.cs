using DuAnMau_QuanLyPhongtro_PH50715.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
{
    public static class DichVuDAL
    {
        public static DataTable SelectAll()
        {
            DBUltil.OpenConnection();
            var dt = DBUltil.ExecuteQueryTable(
                "SELECT * FROM Dich_Vu",
                null
            );
            DBUltil.CloseConnection();
            return dt;
        }

        public static void Insert(string ten, decimal gia, string donVi)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                @"INSERT INTO Dich_Vu
              (tenDichVu, donGia, donVi)
              VALUES (@0,@1,@2)",
                new List<object> { ten, gia, donVi }
            );
            DBUltil.CloseConnection();
        }

        public static void Update(int id, string ten, decimal gia, string donVi)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                @"UPDATE Dich_Vu SET
                tenDichVu=@0,
                donGia=@1,
                donVi=@2
              WHERE idDichVu=@3",
                new List<object> { ten, gia, donVi, id }
            );
            DBUltil.CloseConnection();
        }

        public static void Delete(int id)
        {
            DBUltil.OpenConnection();
            DBUltil.ExecuteNonQuery(
                "DELETE FROM Dich_Vu WHERE idDichVu=@0",
                new List<object> { id }
            );
            DBUltil.CloseConnection();
        }
    }

}
