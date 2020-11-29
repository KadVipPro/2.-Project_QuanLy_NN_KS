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
    public partial class C03_QLTK_QuenMK : Form
    {
        AccountService accountService = new AccountService();
           public static string TenTK = "";


        public C03_QLTK_QuenMK()
        {
            InitializeComponent();
            txt_tentk.Text = TenTK;
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(2, true));
            builder.Append(RandomNumber(3, 100));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_tentk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vào tên tài khoản");
                return;
            }
            if (cb_cauhoibimat.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi bí mật của bạn");
                return;
            }
            if (txt_traloi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng trả lời câu hỏi bí mật");
                return;
            }
            if (accountService.QuenMatKhau(txt_tentk.Text, cb_cauhoibimat.SelectedItem.ToString(), txt_traloi.Text, GetPassword()))
            {
                MessageBox.Show("Thành công! Bạn đã nhận được một mật khẩu mới");
            }
            else
            {
                MessageBox.Show("Lấy lại mật khẩu thất bại! ");
            }

        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C03_QLTK_QuenMK_Load(object sender, EventArgs e)
        {
            cb_cauhoibimat.Items.Add("-Chọn câu hỏi bí mật-");
            cb_cauhoibimat.SelectedIndex = 0;
            foreach (var item in accountService.ListCauHoi())
            {
                cb_cauhoibimat.Items.Add(item);
            }
        }

        private void cb_cauhoibimat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cauhoibimat.SelectedIndex == 0)
                txt_traloi.Enabled = false;
            else
                txt_traloi.Enabled = true;
        }
    }
}
