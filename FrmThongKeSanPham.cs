using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FrmThongKeSanPham : Form
    {
        BLL_ThongKe bll = new BLL_ThongKe();
        public FrmThongKeSanPham()
        {
            InitializeComponent();
        }

        private void FrmThongKeSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
        }

        private void LoadLoaiSanPham()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CHULUONGNGOCANH\NGOCANH;Initial Catalog=cafepoly;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaSanPham, TenSanPham FROM SanPham WHERE TrangThai = 1", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboLoaiSanPham.DataSource = dt;
            cboLoaiSanPham.DisplayMember = "TenSanPham";
            cboLoaiSanPham.ValueMember = "MaSanPham";
            cboLoaiSanPham.SelectedIndex = -1;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maSanPham = cboLoaiSanPham.SelectedValue.ToString();
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDenNgay.Value;

            using (SqlConnection conn = new SqlConnection(@"Data Source=CHULUONGNGOCANH\NGOCANH;Initial Catalog=cafepoly;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeSanPhamTheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThongKeSP.DataSource = dt;
            }
        }
    

        private void cbxLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
