using Nhom13_QuanLyTourDuLIch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class HoaDonDatTour : Form
    {
        string makhhd;
        string tenkhhd;
        string tentourhd;
        string ngaydihd;
        string ngaykthd;
        string thanhtienhd;
        string ngaplaphd;

        public HoaDonDatTour()
        {
            InitializeComponent();
        }

        public HoaDonDatTour(string matour, string tentour, string giatour, string ngaydi, string ngaykt, string ngaylap)
        {
            InitializeComponent();
            lblHDMaTour.Text = matour;
            lblHDTenTour.Text = tentour;
            lblHDThanhTien.Text = giatour;
            lblHDNgayDi.Text = ngaydi;
            lblHDNgayKT.Text = ngaykt;
            lblHDNgayLap.Text = ngaylap;
        }

        private void HoaDonDatTour_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();              
                List<KhachHang> listKH = context.KhachHangs.ToList();
                HienThiHD(listKH);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void HienThiHD(List<KhachHang> listKH)
        {
            dgvHD.Rows.Clear();
            foreach (var item in listKH)
            {
                int index = dgvHD.Rows.Add();
                dgvHD.Rows[index].Cells[0].Value = item.MaKH;
                dgvHD.Rows[index].Cells[1].Value = item.TenKH;
                dgvHD.Rows[index].Cells[2].Value = item.NgaySinhKH;
                dgvHD.Rows[index].Cells[3].Value = item.DiaChiKH;
                dgvHD.Rows[index].Cells[4].Value = item.SDTKH;
                dgvHD.Rows[index].Cells[5].Value = item.EmailKH;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            formRP frmRP = new formRP(makhhd, tenkhhd, tentourhd, thanhtienhd, ngaydihd, ngaykthd, ngaplaphd);
            frmRP.ShowDialog();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHD.Rows.Count > 0 && e.RowIndex < dgvHD.RowCount - 1)
            {
                string makh = dgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                DuLichDB context = new DuLichDB();
                KhachHang update = context.KhachHangs.FirstOrDefault(p => p.MaKH == makh);
                makhhd = dgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                tenkhhd = dgvHD.Rows[e.RowIndex].Cells[1].Value.ToString();
                tentourhd = lblHDTenTour.Text;
                thanhtienhd = lblHDThanhTien.Text;               
                ngaydihd = lblHDNgayDi.Text;
                ngaykthd = lblHDNgayKT.Text;
                ngaplaphd = DateTime.Now.ToString();
                if (update != null)
                {
                    txtHDMaKH.Text = makh;
                    txtHDTenKH.Text = update.TenKH;
                    dtHDNgaySinh.Text = (update.NgaySinhKH).ToString();
                    txtHDDiaChi.Text = update.DiaChiKH;
                    txtHDSoDT.Text = (update.SDTKH).ToString();
                    txtHDEmail.Text = update.EmailKH;
                    //dtNgayKTTrongNuoc.Value = (DateTime)update.NgayKetThucTrongNuoc;
                }
            }
        }

        private void btnReturnTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chức năng này không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                frmTourTrongNuoc returnTN = new frmTourTrongNuoc();
                returnTN.ShowDialog();
            }
        }

        private void btnReturnNN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chức năng này không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                frmTourNgoaiNguoc returnNN = new frmTourNgoaiNguoc();
                returnNN.ShowDialog();
            }
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            try
            {
                string notice = "";
                if (notice == "")
                {
                    if (string.IsNullOrEmpty(txtHDMaKH.Text))
                    {
                        notice += "Chưa nhập mã khách hàng.";
                    }
                    if (string.IsNullOrEmpty(txtHDTenKH.Text))
                    {
                        notice += "Chưa nhập tên khách hàng.";
                    }
                    if (string.IsNullOrEmpty(dtHDNgaySinh.Text))
                    {
                        notice += "Chưa chọn ngày sinh khách hàng.";
                    }
                    if (string.IsNullOrEmpty(txtHDDiaChi.Text))
                    {
                        notice += "Chưa nhập địa chỉ.";
                    }
                    if (string.IsNullOrEmpty(txtHDSoDT.Text))
                    {
                        notice += "Chưa nhập số điện thoại.";
                    }
                    if (string.IsNullOrEmpty(txtHDEmail.Text))
                    {
                        notice += "Chưa chọn Email.";
                    }
                }

                if ((string.IsNullOrEmpty(txtHDMaKH.Text)) || (string.IsNullOrEmpty(txtHDTenKH.Text)) || (string.IsNullOrEmpty(dtHDNgaySinh.Text)) || (string.IsNullOrEmpty(txtHDDiaChi.Text)) || (string.IsNullOrEmpty(txtHDSoDT.Text)) || (string.IsNullOrEmpty(txtHDEmail.Text)))
                {
                    MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DuLichDB context = new DuLichDB();
                    //KhachHang addKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtHDMaKH.Text);
                    KhachHang kh = new KhachHang()
                    {
                        MaKH = txtHDMaKH.Text,
                        TenKH = txtHDTenKH.Text,
                        NgaySinhKH = (DateTime)(dtHDNgaySinh.Value),
                        DiaChiKH = txtHDDiaChi.Text,
                        SDTKH = int.Parse(txtHDSoDT.Text),
                        EmailKH = txtHDEmail.Text,
                    };
                    context.KhachHangs.Add(kh);

                    context.SaveChanges();

                    HienThiHD(context.KhachHangs.ToList());

                    txtHDMaKH.Text = "";
                    txtHDTenKH.Text = "";
                    dtHDNgaySinh.Value = DateTime.Now;
                    txtHDDiaChi.Text = "";
                    txtHDSoDT.Text = "";
                    txtHDEmail.Text = "";

                    MessageBox.Show("Thêm thông tin khách hàng đặt tour thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHDXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                KhachHang deleteKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtHDMaKH.Text);
                if(deleteKH != null)
                {
                    context.KhachHangs.Remove(deleteKH);

                    context.SaveChanges();

                    HienThiHD(context.KhachHangs.ToList());
                }
                MessageBox.Show("Xoá khách hàng đặt tour thành công!");

                txtHDMaKH.Text = "";
                txtHDTenKH.Text = "";
                dtHDNgaySinh.Value = DateTime.Now;
                txtHDDiaChi.Text = "";
                txtHDSoDT.Text = "";
                txtHDEmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHDSua_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                KhachHang updateKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtHDMaKH.Text);
                if(updateKH != null)
                {
                    updateKH.TenKH = txtHDTenKH.Text;
                    updateKH.NgaySinhKH = (DateTime)(dtHDNgaySinh.Value);
                    updateKH.DiaChiKH = txtHDDiaChi.Text;
                    updateKH.SDTKH = int.Parse(txtHDSoDT.Text);
                    updateKH.EmailKH = txtHDEmail.Text;

                    context.SaveChanges();

                    HienThiHD(context.KhachHangs.ToList());
                }
                MessageBox.Show("Sửa thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
