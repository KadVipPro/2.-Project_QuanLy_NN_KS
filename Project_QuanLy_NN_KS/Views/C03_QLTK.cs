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
    public partial class C03_QLTK : Form
    {
        #region Properties
        AccountService account = new AccountService();
        static string trangthai = "";
        static int id = 0;
        #endregion
        #region Constructors
        public C03_QLTK()
        {
            InitializeComponent();
        }
        #endregion
        private void LoadGridView()
        {
           
                dgv_taikhoan.Columns["TenTK"].HeaderText = "Tên tài khoản";
                dgv_taikhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
                dgv_taikhoan.Columns["CauHoiBiMat"].HeaderText = "Câu hỏi bí mật";
                dgv_taikhoan.Columns["TraloiCHBM"].HeaderText = "Trả lời CHBM";
                dgv_taikhoan.Columns["TrangThai"].HeaderText = "Trạng thái";
                for (int i = 0; i < 3; i++)
                {
                    dgv_taikhoan.Columns[i].Visible = false;
                }
                for (int i = 8; i < dgv_taikhoan.Columns.Count; i++)
                {
                    dgv_taikhoan.Columns[i].Visible = false;
                }
                foreach (DataGridViewColumn col in dgv_taikhoan.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            
        }
        #region Events
        private void C03_QLTK_Load(object sender, EventArgs e)
        {
            account = new AccountService();
            dgv_taikhoan.DataSource = account.GetTaiKhoan();
            LoadGridView();
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "Tên tài khoản")
            {
                txt_timkiem.Text = "";
                txt_timkiem.ForeColor = Color.Black;
            }
        }
        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                txt_timkiem.Text = "Tên tài khoản";
                txt_timkiem.ForeColor = Color.Silver;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            account = new AccountService();
            this.Refresh();
            C03_QLTK_Load(sender, e);
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = account.SearchTaiKhoan(txt_timkiem.Text);
        }
        private void dgv_taikhoan_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                var row = dataGrid.Rows[e.RowIndex];
                dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
                row.Selected = true;
                dataGrid.Focus();
                C03_QLTK_QuenMK.TenTK = row.Cells["TenTK"].Value.ToString();
                C03_QLTK_DoiMK.TenTK = row.Cells["TenTK"].Value.ToString();
                id = int.Parse(row.Cells["ID"].Value.ToString());
                trangthai = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void dgv_taikhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = dgv_taikhoan.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Đổi mật khẩu", DoiMatKhau_Click));
                    m.MenuItems.Add(new MenuItem("Quên mật khẩu", QuenMK_Click));
                    m.MenuItems.Add(new MenuItem("Đổi trạng thái", DoiTrangThai_Click));
                }
                m.Show(dgv_taikhoan, new Point(e.X, e.Y));
            }

        }
        private void DoiMatKhau_Click(object sender, EventArgs e)
        {
            C03_QLTK_DoiMK doiMK = new C03_QLTK_DoiMK();
            doiMK.FormClosed += DoiMK_FormClosed;
            doiMK.ShowDialog();

        }
        private void QuenMK_Click(object sender, EventArgs e)
        {
            C03_QLTK_QuenMK quenMK = new C03_QLTK_QuenMK();
            quenMK.FormClosed += QuenMK_FormClosed;
            quenMK.ShowDialog();
        }
        private void DoiMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            account = new AccountService();
            dgv_taikhoan.DataSource = null;
            dgv_taikhoan.Refresh();
            C03_QLTK_Load(sender, e);
        }
        private void QuenMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoiMK_FormClosed(sender, e);
        }
        private void DoiTrangThai_Click(object sender, EventArgs e)
        {
            var ttmoi = "";
            if (trangthai == "Hoạt động")
                ttmoi = "Ngừng hoạt động";
            else
                ttmoi = "Hoạt động";
            var result = MessageBox.Show("Đổi trạng thái tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgv_taikhoan.DataSource = account.DoiTrangThai(id, ttmoi);
                MessageBox.Show("Đổi thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
       
        #endregion


    }
}
