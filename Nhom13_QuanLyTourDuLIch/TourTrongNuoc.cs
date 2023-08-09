using Nhom13_QuanLyTourDuLIch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class frmTourTrongNuoc : Form
    {
        string matourtn;
        string nametourtn;
        string giatourtn;
        string ngayditn;
        string ngaykttn;
        string ngaylaptn;

        //string connectionString = "Data Source=DESKTOP-GHISU8I\\SQLEXPRESS;Initial Catalog=QLTourDuLichDoAn;Integrated Security=True";
        //private DataTable originalDataTable;
        public frmTourTrongNuoc()
        {
            InitializeComponent();      
        }     

        private void frmTourTrongNuoc_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                List<TourTrongNuoc> tourTN = context.TourTrongNuocs.ToList();
                comboTourTrongNuoc(tourTN);
                HienThiTourTN(tourTN);
                //loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboTourTrongNuoc(List<TourTrongNuoc> tourTN)
        {
            this.cmbTourTrongNuoc.DataSource = tourTN;
            this.cmbTourTrongNuoc.DisplayMember = "TenTourTrongNuoc";
            this.cmbTourTrongNuoc.ValueMember = "MaTourTrongNuoc";
        }

        private void HienThiTourTN(List<TourTrongNuoc> tourTN)
        {
            dgvViewTourTrongNuoc.Rows.Clear();
            foreach (var item in tourTN)
            {
                int index = dgvViewTourTrongNuoc.Rows.Add();
                dgvViewTourTrongNuoc.Rows[index].Cells[0].Value = item.MaTourTrongNuoc;
                dgvViewTourTrongNuoc.Rows[index].Cells[1].Value = item.TenTourTrongNuoc;
                dgvViewTourTrongNuoc.Rows[index].Cells[2].Value = item.SoNguoiDiTrongNuoc;
                dgvViewTourTrongNuoc.Rows[index].Cells[3].Value = item.NgayDiTrongNuoc;
                dgvViewTourTrongNuoc.Rows[index].Cells[4].Value = item.NgayKetThucTrongNuoc;
                dgvViewTourTrongNuoc.Rows[index].Cells[5].Value = item.GiaTourTrongNuoc;
            }           
        }

        private void dgvViewTourTrongNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvViewTourTrongNuoc.Rows.Count > 0 && e.RowIndex < dgvViewTourTrongNuoc.RowCount - 1)
            {
                string tentourtn = dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                DuLichDB context = new DuLichDB();
                TourTrongNuoc update = context.TourTrongNuocs.FirstOrDefault(p => p.TenTourTrongNuoc == tentourtn);
                matourtn = dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                nametourtn = dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                giatourtn = dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[5].Value.ToString();
                ngayditn = dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                ngaykttn = dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[4].Value.ToString();
                ngaylaptn = DateTime.Now.ToString();
                /*this.Hide();
                HoaDonDatTour updateHD = new HoaDonDatTour(dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvViewTourTrongNuoc.Rows[e.RowIndex].Cells[5].Value.ToString());
                updateHD.ShowDialog();*/
                if (update != null)
                {
                    cmbTourTrongNuoc.Text = tentourtn;
                    nudSoNguoiDiTrongNuoc.Text = (update.SoNguoiDiTrongNuoc).ToString();
                    dtNgayDiTrongNuoc.Text = (update.NgayDiTrongNuoc).ToString();
                    dtNgayKTTrongNuoc.Text = (update.NgayKetThucTrongNuoc).ToString();
                    lblViewTenTour.Text = tentourtn;
                    lblViewGiaTour.Text = (update.GiaTourTrongNuoc).ToString();
                    lblMaTourTN.Text = update.MaTourTrongNuoc;
                    lblSoNgayTN.Text = (update.NgayDiTrongNuoc).ToString();
                    lblKhoiHanhTN.Text = tentourtn;
                    lblSlotTN.Text = (update.SoNguoiDiTrongNuoc).ToString();
                    //dtNgayKTTrongNuoc.Value = (DateTime)update.NgayKetThucTrongNuoc;
                }
            }
        }

        private void btnLocketquaTrongNuoc_Click(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            var listTN = context.TourTrongNuocs.ToList().Where(o => o.TenTourTrongNuoc == cmbTourTrongNuoc.Text).ToList();
            lblSoLuongTourTrongNuoc.Text = "Đã Tìm Thấy " + listTN.Count.ToString() + " Tour";
            HienThiTourTN(listTN);

            /*var listLocKQ = context.TourTrongNuocs.ToList();
            dgvViewTourTrongNuoc.Rows.Clear();
            HienThiTourTN(listLocKQ.Where(s => s.TenTourTrongNuoc == cmbTourTrongNuoc.Text && s.NgayDiTrongNuoc >= dtNgayDiTrongNuoc.Value && s.NgayDiTrongNuoc <= dtNgayKTTrongNuoc.Value).ToList());
            lblSoLuongTourTrongNuoc.Text = "Đã Tìm Thấy " + listLocKQ.Count.ToString() + " Tour";*/
        }    

        /*private void loadData()
        {
            string query = "SELECT * FROM TourTrongNuoc";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    SqlDataAdapter adap = new SqlDataAdapter(query, connect);
                    originalDataTable = new DataTable();
                    adap.Fill(originalDataTable);

                    dgvViewTourTrongNuoc.DataSource = originalDataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }*/     

        private void btnResetTrongNuoc_Click(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            List<TourTrongNuoc> tourTN = context.TourTrongNuocs.ToList();
            dgvViewTourTrongNuoc.Rows.Clear();
            HienThiTourTN(tourTN);
            cmbTourTrongNuoc.Text = "";
            nudSoNguoiDiTrongNuoc.Value = 0;
            dtNgayDiTrongNuoc.Value = DateTime.Now;
            dtNgayKTTrongNuoc.Value = DateTime.Now;
            lblSoLuongTourTrongNuoc.Text = "Đã tìm thấy 0 tour";
            lblViewTenTour.Text = "";
            lblViewGiaTour.Text = "";
            lblMaTourTN.Text = "";
            lblSoNgayTN.Text = "";
            lblKhoiHanhTN.Text = "";
            lblSlotTN.Text = "";
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chức năng này không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                frmMain returnMain = new frmMain();
                returnMain.ShowDialog();
            }
        }

        private void btnDatTourTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonDatTour frmHD = new HoaDonDatTour(matourtn, nametourtn, giatourtn, ngayditn, ngaykttn, ngaylaptn);
            frmHD.ShowDialog();
        }
    }
}
