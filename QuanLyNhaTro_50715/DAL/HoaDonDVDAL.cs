using DuAnMau_QuanLyPhongtro_PH50715.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.DAL
{
    public static class HoaDonDAL
    {
        public static DataTable SelectByHopDong(int idHD)
        {
            DBUltil.OpenConnection();
            var dt = DBUltil.ExecuteQueryTable(
                "SELECT * FROM HD_DV WHERE idHopDong=@0",
                new List<object> { idHD }
            );
            DBUltil.CloseConnection();
            return dt;
        }
    }
}
