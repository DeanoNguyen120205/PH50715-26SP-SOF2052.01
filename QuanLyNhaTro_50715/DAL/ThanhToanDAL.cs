//using DuAnMau_QuanLyPhongtro_PH50715.Utils;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
//{
//    public static class ThanhToanDAL
//    {
//        public static void Insert(int idHD, decimal tong, string pt)
//        {
//            DBUltil.OpenConnection();
//            DBUltil.ExecuteNonQuery(
//                @"INSERT INTO Thanh_Toan
//              (idHoaDonDichVu, tongTien, phuongThuc)
//              VALUES (@0,@1,@2)",
//                new List<object> { idHD, tong, pt }
//            );
//            DBUltil.CloseConnection();
//        }
//    }
//}
