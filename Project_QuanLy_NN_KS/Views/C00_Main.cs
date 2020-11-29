using Project_QuanLy_NN_KS.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLy_NN_KS
{
    public partial class C00_Main : Form
    {
        public C00_Main()
        {
            InitializeComponent();
        }

        private void C00_Main_Load(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "C03_QLTK")
                {
                    MessageBox.Show("Bạn đã mở form QLTK rồi");
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                C03_QLTK qLTK = new C03_QLTK();
                qLTK.MdiParent = this;
                qLTK.Show();
            }
        }

        private void C00_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C05_DICHVU frmDV = new C05_DICHVU();
            frmDV.MdiParent = this;
            frmDV.Show();
        }

        private void ghiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C05_ThemDichVuHoaDon frmdvhd = new C05_ThemDichVuHoaDon();
            frmdvhd.MdiParent = this;
            frmdvhd.Show();
        }
    }
}
