using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QuanLy_NN_KS.Controllers;
namespace Project_QuanLy_NN_KS.Views
{
    public partial class C03_QLTK_DoiMK : Form
    {
        AccountService accountService = new AccountService();
        public static string TenTK = "";
        public C03_QLTK_DoiMK()
        {
            InitializeComponent();
            txt_tentk.Text = TenTK;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_tentk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản cần đổi mật khẩu");
                return;
            }
            if (txt_mkcu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ");
                return;
            }
            if (txt_mkmoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                return;
            }
            if (txt_xacnhanmk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới");
                return;
            }
            if (accountService.ChangePassword(txt_tentk.Text, txt_mkcu.Text, txt_mkmoi.Text) && txt_mkmoi.Text == txt_xacnhanmk.Text)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
