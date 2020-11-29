using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_QuanLy_NN_KS.Models;
using System.Threading.Tasks;

namespace Project_QuanLy_NN_KS.Controllers
{
    class AccountService:IAccountService
    {
        DB_QL_NN_KSEntities db = new DB_QL_NN_KSEntities();
        public List<TAI_KHOAN> GetTaiKhoan()
        {
            var listTK = (from d in db.TAI_KHOAN select d).ToList();
            return listTK;
        }
        public List<TAI_KHOAN> SearchTaiKhoan(string tentk)
        {
            var listTk = (from d in db.TAI_KHOAN where d.TenTK == tentk select d).ToList();
            return listTk;
        }
        public List<TAI_KHOAN> DoiTrangThai(int id ,string trangthai)
        {
            var TK = (from d in db.TAI_KHOAN where d.ID == id select d).FirstOrDefault();
            if(TK != null)
            {
                TK.TrangThai = trangthai;
                db.SaveChanges();
            }
            return GetTaiKhoan();
        }
        public List<string> ListCauHoi()
        {
            var listCauhoi = (from d in db.TAI_KHOAN select d.CauHoiBiMat).ToList();
            listCauhoi = listCauhoi.OrderBy(r => Guid.NewGuid()).ToList();
            return listCauhoi;
        }
        public bool QuenMatKhau(string tentk, string cauhoibimat, string traloi, string mkmoi)
        {
            var tk = (from d in db.TAI_KHOAN where d.TenTK == tentk && d.CauHoiBiMat == cauhoibimat && d.TraLoiCHBM == traloi select d).FirstOrDefault();
            if (tk != null)
            {
                tk.MatKhau = mkmoi;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ChangePassword(string tentk, string oldpass, string newpass)
        {
            var TK = (from d in db.TAI_KHOAN where d.TenTK == tentk && d.MatKhau == oldpass select d).FirstOrDefault();
            if (TK != null)
            {
                TK.MatKhau = newpass;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
