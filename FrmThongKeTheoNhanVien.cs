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

namespace GUI_PolyCafe
{
    public partial class FrmThongKeTheoNhanVien : Form
    {
        BLL_ThongKe bll = new BLL_ThongKe();

        public FrmThongKeTheoNhanVien()
        {
            InitializeComponent();
        }

        private void FrmThongKeTheoNhanVien_Load(object sender, EventArgs e)
        {
           LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CHULUONGNGOCANH\NGOCANH;Initial Catalog=cafepoly;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaNhanVien, HoTen FROM NhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";
            cboNhanVien.SelectedIndex = -1;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maNV = cboNhanVien.SelectedValue?.ToString();
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            dgvThongKeNV.DataSource = bll.GetThongKeNhanVien(tuNgay, denNgay, maNV);
        }
    }
}
