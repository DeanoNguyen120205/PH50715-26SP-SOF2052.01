using DuAnMau_QuanLyPhongtro_PH50715.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnMau_QuanLyPhongtro_PH50715.BLL
{
    public static class DichVuBLL
    {
        public static DataTable GetAll() => DichVuDAL.SelectAll();
        public static void Add(string ten, decimal gia, string dv)
            => DichVuDAL.Insert(ten, gia, dv);
        public static void Update(int id, string ten, decimal gia, string dv)
            => DichVuDAL.Update(id, ten, gia, dv);
        public static void Delete(int id)
            => DichVuDAL.Delete(id);
    }

}
