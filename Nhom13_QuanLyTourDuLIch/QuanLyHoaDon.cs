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
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            List<HoaDon> listHD = context.HoaDons.ToList();
            HienThiHD(listHD);
        }

        private void HienThiHD(List<HoaDon> listHD)
        {
            dgvQLHD.Rows.Clear();
            foreach (var item in listHD)
            {
                int index = dgvQLHD.Rows.Add();
                dgvQLHD.Rows[index].Cells[0].Value = item.MaHD;
                dgvQLHD.Rows[index].Cells[1].Value = item.NgayLapHD;
                dgvQLHD.Rows[index].Cells[2].Value = item.TongTien;
                dgvQLHD.Rows[index].Cells[3].Value = item.MaNV;
                dgvQLHD.Rows[index].Cells[4].Value = item.MaKH;
                dgvQLHD.Rows[index].Cells[5].Value = item.MaTourTrongNuoc;
                dgvQLHD.Rows[index].Cells[6].Value = item.MaTourNgoaiNuoc;
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                HoaDon addHD = context.HoaDons.FirstOrDefault(p => p.MaHD == txtQLSoHD.Text);
                TourTrongNuoc addTN = context.TourTrongNuocs.FirstOrDefault(o => o.MaTourTrongNuoc == txtQLMaTourTNHD.Text);
                TourNgoaiNuoc addNN = context.TourNgoaiNuocs.FirstOrDefault(s => s.MaTourNgoaiNuoc == txtQLMaTourNNHD.Text);
                if (addHD == null)
                {
                    if(addTN == null)
                    {
                        HoaDon hd = new HoaDon()
                        {
                            MaHD = txtQLSoHD.Text,
                            NgayLapHD = dtQLNgayLapHD.Value,
                            TongTien = int.Parse(txtQLTongTienHD.Text),
                            MaNV = txtQLMaNVHD.Text,
                            MaKH = txtQLMaKHHD.Text,
                            //MaTourTrongNuoc = txtQLMaTourTNHD.Text,
                            MaTourNgoaiNuoc = txtQLMaTourNNHD.Text
                        };
                        context.HoaDons.Add(hd);

                        context.SaveChanges();

                        HienThiHD(context.HoaDons.ToList());

                        txtQLSoHD.Text = "";
                        dtQLNgayLapHD.Value = DateTime.Now;
                        txtQLTongTienHD.Text = "";
                        txtQLMaNVHD.Text = "";
                        txtQLMaKHHD.Text = "";
                        txtQLMaTourTNHD.Text = "";
                        txtQLMaTourNNHD.Text = "";
                    }
                    else if(addNN == null)
                    {
                        HoaDon hd = new HoaDon()
                        {
                            MaHD = txtQLSoHD.Text,
                            NgayLapHD = dtQLNgayLapHD.Value,
                            TongTien = int.Parse(txtQLTongTienHD.Text),
                            MaNV = txtQLMaNVHD.Text,
                            MaKH = txtQLMaKHHD.Text,
                            MaTourTrongNuoc = txtQLMaTourTNHD.Text,
                            //MaTourNgoaiNuoc = txtQLMaTourNNHD.Text
                        };
                        context.HoaDons.Add(hd);

                        context.SaveChanges();

                        HienThiHD(context.HoaDons.ToList());

                        txtQLSoHD.Text = "";
                        dtQLNgayLapHD.Value = DateTime.Now;
                        txtQLTongTienHD.Text = "";
                        txtQLMaNVHD.Text = "";
                        txtQLMaKHHD.Text = "";
                        txtQLMaTourTNHD.Text = "";
                        txtQLMaTourNNHD.Text = "";
                    }                 
                    MessageBox.Show("Thêm hóa đơn thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                HoaDon deleteHD = context.HoaDons.FirstOrDefault(p => p.MaHD == txtQLSoHD.Text);
                if (deleteHD != null)
                {
                    context.HoaDons.Remove(deleteHD);

                    context.SaveChanges();

                    HienThiHD(context.HoaDons.ToList());

                    MessageBox.Show("Xóa hóa đơn thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                HoaDon updateHD = context.HoaDons.FirstOrDefault(p => p.MaHD == txtQLSoHD.Text);
                TourTrongNuoc addTN = context.TourTrongNuocs.FirstOrDefault(o => o.MaTourTrongNuoc == txtQLMaTourTNHD.Text);
                TourNgoaiNuoc addNN = context.TourNgoaiNuocs.FirstOrDefault(s => s.MaTourNgoaiNuoc == txtQLMaTourNNHD.Text);
                if (updateHD != null)
                {
                    if(addTN != null)
                    {
                        updateHD.NgayLapHD = (DateTime)(dtQLNgayLapHD.Value);
                        updateHD.TongTien = int.Parse(txtQLTongTienHD.Text);
                        updateHD.MaNV = txtQLMaNVHD.Text;
                        updateHD.MaKH = txtQLMaKHHD.Text;
                        updateHD.MaTourTrongNuoc = txtQLMaTourTNHD.Text;
                        //updateHD.MaTourNgoaiNuoc = txtQLMaTourNNHD.Text;

                        context.SaveChanges();

                        HienThiHD(context.HoaDons.ToList());
                    }
                    else if (addNN != null)
                    {
                        updateHD.NgayLapHD = (DateTime)(dtQLNgayLapHD.Value);
                        updateHD.TongTien = int.Parse(txtQLTongTienHD.Text);
                        updateHD.MaNV = txtQLMaNVHD.Text;
                        updateHD.MaKH = txtQLMaKHHD.Text;
                        //updateHD.MaTourTrongNuoc = txtQLMaTourTNHD.Text;
                        updateHD.MaTourNgoaiNuoc = txtQLMaTourNNHD.Text;

                        context.SaveChanges();

                        HienThiHD(context.HoaDons.ToList());
                    }
                    
                }
                MessageBox.Show("Sửa thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvQLHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLHD.Rows.Count > 0 && e.RowIndex < dgvQLHD.RowCount - 1)
            {
                string mahd = dgvQLHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                DuLichDB context = new DuLichDB();
                HoaDon update = context.HoaDons.FirstOrDefault(p => p.MaHD == mahd);
                if (update != null)
                {
                    txtQLSoHD.Text = mahd;
                    dtQLNgayLapHD.Value = (DateTime)(update.NgayLapHD);
                    txtQLTongTienHD.Text = (update.TongTien).ToString();
                    txtQLMaNVHD.Text = update.MaNV;
                    txtQLMaKHHD.Text = update.MaKH;
                    txtQLMaTourTNHD.Text = update.MaTourTrongNuoc;
                    txtQLMaTourNNHD.Text = update.MaTourNgoaiNuoc;
                }
            }           
        }

        private void dtTimNgay_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvQLHD.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }
            foreach (DataGridViewRow row in dgvQLHD.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[1].Value.ToString()?.IndexOf(dtTimNgay.Text, StringComparison.OrdinalIgnoreCase) == -1)
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }
}
