//using DuAnMau_QuanLyPhongtro_PH50715.Utils;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
//{
//    public static class HopDongDAL
//    {
//        public static DataTable SelectAll()
//        {
//            DBUltil.OpenConnection();
//            var dt = DBUltil.ExecuteQueryTable(
//                "SELECT * FROM Hop_Dong_Thue",
//                null
//            );
//            DBUltil.CloseConnection();
//            return dt;
//        }

//        public static void Insert(string maHD, int idPhong, int idKhach, decimal gia)
//        {
//            DBUltil.OpenConnection();
//            DBUltil.ExecuteNonQuery(
//                @"INSERT INTO Hop_Dong_Thue
//              (maHopDong, idPhong, idKhachThue, giaThue_ThoaThuan)
//              VALUES (@0,@1,@2,@3)",
//                new List<object> { maHD, idPhong, idKhach, gia }
//            );
//            DBUltil.CloseConnection();
//        }
//    }
//}
