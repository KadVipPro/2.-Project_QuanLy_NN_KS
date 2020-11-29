using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QuanLy_NN_KS.Models;
using Project_QuanLy_NN_KS.Controllers;

namespace Project_QuanLy_NN_KS.Views
{
    public partial class C05_ThemDichVuHoaDon : Form
    {
        public C05_ThemDichVuHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void C05_ThemDichVuHoaDon_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Mời bạn chọn id ");
            comboBox2.SelectedIndex = 0;
            foreach ( var item in DichVuService.ListID())
            {
                comboBox2.Items.Add(item);
            }

            comboBox1.Items.Add("Mời bạn chọn id ");
            comboBox1.SelectedIndex = 0;
            foreach (var hd in DichVuService.ListHD())
            {
                comboBox1.Items.Add(hd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DichVuService.ThemDVHD(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
