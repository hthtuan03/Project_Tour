using Nhom13_QuanLyTourDuLIch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class frmTourNgoaiNguoc : Form
    {
        string matournn;
        string nametournn;
        string giatournn;
        string ngaydinn;
        string ngayktnn;
        string ngaylapnn;

        public frmTourNgoaiNguoc()
        {
            InitializeComponent();
        }

        private void frmTourNgoaiNguoc_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                List<TourNgoaiNuoc> tourNN = context.TourNgoaiNuocs.ToList();
                comboTourNgoaiNuoc(tourNN);
                HienThiTourNN(tourNN);            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboTourNgoaiNuoc(List<TourNgoaiNuoc> tourNN)
        {
            this.cmbTourNgoaiNuoc.DataSource = tourNN;
            this.cmbTourNgoaiNuoc.DisplayMember = "TenTourNgoaiNuoc";
            this.cmbTourNgoaiNuoc.ValueMember = "MaTourNgoaiNuoc";
        }

        private void HienThiTourNN(List<TourNgoaiNuoc> tourNN)
        {
            dgvViewTourNgoaiNuoc.Rows.Clear();
            foreach(var item in tourNN)
            {
                int index = dgvViewTourNgoaiNuoc.Rows.Add();
                dgvViewTourNgoaiNuoc.Rows[index].Cells[0].Value = item.MaTourNgoaiNuoc;
                dgvViewTourNgoaiNuoc.Rows[index].Cells[1].Value = item.TenTourNgoaiNuoc;
                dgvViewTourNgoaiNuoc.Rows[index].Cells[2].Value = item.SoNguoiDiNgoaiNuoc;
                dgvViewTourNgoaiNuoc.Rows[index].Cells[3].Value = item.NgayDiNgoaiNuoc;
                dgvViewTourNgoaiNuoc.Rows[index].Cells[4].Value = item.NgayKetThucNgoaiNuoc;
                dgvViewTourNgoaiNuoc.Rows[index].Cells[5].Value = item.GiaTourNgoaiNuoc;
            }
        }

       
        private void dgvViewTourNgoaiNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewTourNgoaiNuoc.Rows.Count > 0 && e.RowIndex < dgvViewTourNgoaiNuoc.RowCount - 1)
            {
                string tentournn = dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                DuLichDB context = new DuLichDB();
                TourNgoaiNuoc update = context.TourNgoaiNuocs.FirstOrDefault(p => p.TenTourNgoaiNuoc == tentournn);
                matournn = dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                nametournn = dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                giatournn = dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[5].Value.ToString();
                ngaydinn = dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                ngayktnn = dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[4].Value.ToString();
                ngaylapnn = DateTime.Now.ToString();
                /*this.Hide();
                HoaDonDatTour updateHD = new HoaDonDatTour(dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvViewTourNgoaiNuoc.Rows[e.RowIndex].Cells[5].Value.ToString());
                updateHD.ShowDialog();*/
                if (update != null)
                {
                    cmbTourNgoaiNuoc.Text = tentournn;
                    nudSoNguoiDiNgoaiNuoc.Text = (update.SoNguoiDiNgoaiNuoc).ToString();
                    dtNgayDiNgoaiNuoc.Text = (update.NgayDiNgoaiNuoc).ToString();
                    dtNgayKTNgoaiNuoc.Text = (update.NgayKetThucNgoaiNuoc).ToString();
                    lblViewTenTour.Text = tentournn;
                    lblGiaTourNN.Text = (update.GiaTourNgoaiNuoc).ToString();
                    lblMaTourNN.Text = update.MaTourNgoaiNuoc;
                    lblSoNgayNN.Text = (update.NgayDiNgoaiNuoc).ToString();
                    lblKhoiHanhNN.Text = tentournn;
                    lblSlotNN.Text = (update.SoNguoiDiNgoaiNuoc).ToString();
                    //dtNgayKTNgoaiNuoc.Value = (DateTime)update.NgayKetThucNgoaiNuoc;
                }
            }
        }

        private void btnLocketquaNgoaiNuoc_Click(object sender, EventArgs e)
        {          
            DuLichDB context = new DuLichDB();
            var listNN = context.TourNgoaiNuocs.ToList().Where(o => o.TenTourNgoaiNuoc == cmbTourNgoaiNuoc.Text).ToList();
            lblSoLuongTourNgoaiNuoc.Text = "Đã Tìm Thấy " + listNN.Count.ToString() + " Tour";
            HienThiTourNN(listNN);
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

        private void btnResetNgoaiNuoc_Click(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            List<TourNgoaiNuoc> tourTN = context.TourNgoaiNuocs.ToList();
            dgvViewTourNgoaiNuoc.Rows.Clear();
            HienThiTourNN(tourTN);
            cmbTourNgoaiNuoc.Text = "";
            nudSoNguoiDiNgoaiNuoc.Value = 0;
            dtNgayDiNgoaiNuoc.Value = DateTime.Now;
            dtNgayKTNgoaiNuoc.Value = DateTime.Now;
            lblSoLuongTourNgoaiNuoc.Text = "Đã tìm thấy 0 tour";
            lblViewTenTour.Text = "";
            lblGiaTourNN.Text = "";
            lblMaTourNN.Text = "";
            lblSoNgayNN.Text = "";
            lblKhoiHanhNN.Text = "";
            lblSlotNN.Text = "";
        }   

        private void btnDatTourNN_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonDatTour frmHD = new HoaDonDatTour(matournn, nametournn, giatournn, ngaydinn, ngayktnn, ngaylapnn);
            frmHD.ShowDialog();        
        }
    }
}
