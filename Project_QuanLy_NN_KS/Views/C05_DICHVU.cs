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
    public partial class C05_DICHVU : Form
    {
        public C05_DICHVU()
        {
            InitializeComponent();
        }

        private void C05_DICHVU_Load(object sender, EventArgs e)
        {
            DB_QL_NN_KSEntities db = new DB_QL_NN_KSEntities();
            dataGridView1.DataSource = db.DICH_VU.ToList();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["ID_Hoa_Don"].Visible = false;
            dataGridView1.Columns["ID_Phong"].Visible = false;
            dataGridView1.Columns["CHI_TIET_HOA_DON"].Visible = false;
            dataGridView1.Columns["PhongS"].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_dongia.Text = " ";
            txt_tdv.Text = " ";
            txt_trangthai.Text = " ";
            txt_dvt.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DichVuService.ThemDichVu((txt_tdv.Text), decimal.Parse(txt_dongia.Text), (txt_dvt.Text), (txt_trangthai.Text));
                MessageBox.Show("Thêm thành công");

                C05_DICHVU_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txt_id.Text = row.Cells[0].Value.ToString();
                txt_tdv.Text = row.Cells[3].Value.ToString();
                txt_dongia.Text = row.Cells[4].Value.ToString();
                txt_dvt.Text = row.Cells[5].Value.ToString();
                txt_trangthai.Text = row.Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DichVuService.SuaDichVu(int.Parse(txt_id.Text),(txt_tdv.Text), decimal.Parse(txt_dongia.Text), (txt_dvt.Text), (txt_trangthai.Text));
            //    MessageBox.Show("Sửa thành công");

            //    C05_DICHVU_Load(sender, e);

            //}
            //catch
            //{
            //    MessageBox.Show("Sửa thất bại");
            //}
            try
            {
                DB_QL_NN_KSEntities db = new DB_QL_NN_KSEntities();
                int idd = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString());
                DICH_VU edit = db.DICH_VU.Find(idd);

                edit.TenDichVu = txt_tdv.Text;
                edit.DonGia = decimal.Parse(txt_dongia.Text);
                edit.DonViTinh = txt_dvt.Text;
                edit.TrangThai = txt_trangthai.Text;

                db.SaveChanges();
                MessageBox.Show("sửa thành công");

                C05_DICHVU_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("sửa thất bại");
            }
        }
    }
}
