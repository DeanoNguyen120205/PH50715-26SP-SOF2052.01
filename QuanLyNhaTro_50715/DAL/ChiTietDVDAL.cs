using DuAnMau_QuanLyPhongtro_PH50715.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
{
    public static class ChiTietDVDAL
    {
        public static DataTable SelectByHoaDon(int id)
        {
            DBUltil.OpenConnection();
            var dt = DBUltil.ExecuteQueryTable(
                "SELECT * FROM Chi_Tiet_DV WHERE idHoaDonDichVu=@0",
                new List<object> { id }
            );
            DBUltil.CloseConnection();
            return dt;
        }
    }
}
