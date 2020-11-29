using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_QuanLy_NN_KS.Models;


namespace Project_QuanLy_NN_KS.Controllers
{
    class DichVuService : IDichVuService
    {
        static DB_QL_NN_KSEntities db = new DB_QL_NN_KSEntities();

        public static bool ThemDichVu(string ten , decimal dongia , string dvt, string tt)
        {
            DICH_VU dv = new DICH_VU()
            {
                TenDichVu = ten,
                DonGia = dongia,
                DonViTinh = dvt,
                TrangThai = tt
            };
            db.DICH_VU.Add(dv);
            db.SaveChanges();

            return true;
          
        }

        public static bool SuaDichVu(int id,string ten, decimal dongia, string dvt, string tt)
        {
            DICH_VU dv = new DICH_VU()
            {
                ID = id,
                TenDichVu = ten,
                DonGia = dongia,
                DonViTinh = dvt,
                TrangThai = tt
            };
            var sua = db.DICH_VU.Where(p => p.ID == id).SingleOrDefault();
            sua.TenDichVu = ten;
            sua.DonGia = dongia;
            sua.DonViTinh = dvt;
            sua.TrangThai = tt;

            db.DICH_VU.Find(sua);
            db.SaveChanges();
            return true;

        }

        public static List<int> ListID()
        {
            var listid = (from d in db.DICH_VU
                          select d.ID).ToList();
            
            return listid;
        }

        public static List<int> ListHD()
        {
            var listhd = (from a in db.CHI_TIET_HOA_DON
                          select a.ID_HOA_DON).ToList();
            return listhd;
        }

        public static bool ThemDVHD(int ID_DV, int ID_HD)
        {
            DICH_VU dv = new DICH_VU()
            {
                ID = ID_DV,
                ID_HOA_DON = ID_HD
            };
            db.DICH_VU.Add(dv);
            db.SaveChanges();
            return true;

        }
    }
}
