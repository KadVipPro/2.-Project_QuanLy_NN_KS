using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QuanLy_NN_KS.Controllers
{
    public class IDichVuService
    {
        public static bool ThemDichVu(string ten, decimal gia, string dvt,string tt)
        {
            return DichVuService.ThemDichVu(ten, gia, dvt, tt);
        }

        public static bool SuaDichVu(int Id, string ten, decimal gia, string dvt, string tt)
        {
            return DichVuService.SuaDichVu(Id, ten, gia, dvt, tt);
        }

        public static bool ThemDVHD(int ID_DV, int ID_HD)
        {
            return DichVuService.ThemDVHD(ID_DV, ID_HD);
        }
    }
}
