using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_QuanLy_NN_KS.Models;
using System.Threading.Tasks;

namespace Project_QuanLy_NN_KS.Controllers
{
    public interface IAccountService
    {
        List<TAI_KHOAN> GetTaiKhoan();
        List<TAI_KHOAN> SearchTaiKhoan(string tentk);
        List<TAI_KHOAN> DoiTrangThai(int id, string trangthai);
        #region ForgotPass
        bool QuenMatKhau(string tentk, string cauhoibimat, string traloi, string mkmoi);
       
        List<string> ListCauHoi();
        #endregion
        #region ChangePass
        bool ChangePassword(string tentk, string oldpass, string newpass);
        #endregion

    }
}
