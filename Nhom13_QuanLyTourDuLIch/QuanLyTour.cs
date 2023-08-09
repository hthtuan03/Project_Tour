using Nhom13_QuanLyTourDuLIch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class QuanLyTour : Form
    {
        SqlCommand cmd;
        public QuanLyTour()
        {
            InitializeComponent();
        }

        private void QuanLyTour_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                List<TourTrongNuoc> tourTN = context.TourTrongNuocs.ToList();
                List<TourNgoaiNuoc> tourNN = context.TourNgoaiNuocs.ToList();
                HienThiTourTN(tourTN);
                HienThiTourNN(tourNN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hiển thị tour trong nước
        private void HienThiTourTN(List<TourTrongNuoc> tourTN)
        {
            dgvQLTourTrongNuoc.Rows.Clear();
            foreach (var item in tourTN)
            {
                int index = dgvQLTourTrongNuoc.Rows.Add();
                dgvQLTourTrongNuoc.Rows[index].Cells[0].Value = item.MaTourTrongNuoc;
                dgvQLTourTrongNuoc.Rows[index].Cells[1].Value = item.TenTourTrongNuoc;
                dgvQLTourTrongNuoc.Rows[index].Cells[2].Value = item.NgayDiTrongNuoc;
                dgvQLTourTrongNuoc.Rows[index].Cells[3].Value = item.NgayKetThucTrongNuoc;
                dgvQLTourTrongNuoc.Rows[index].Cells[4].Value = item.GiaTourTrongNuoc;
                dgvQLTourTrongNuoc.Rows[index].Cells[5].Value = item.SoNguoiDiTrongNuoc;
            }
        }

        //Hiển thị tour ngoài nước
        private void HienThiTourNN(List<TourNgoaiNuoc> tourNN)
        {
            dgvQLTourNgoaiNguoc.Rows.Clear();
            foreach (var item in tourNN)
            {
                int index = dgvQLTourNgoaiNguoc.Rows.Add();
                dgvQLTourNgoaiNguoc.Rows[index].Cells[0].Value = item.MaTourNgoaiNuoc;
                dgvQLTourNgoaiNguoc.Rows[index].Cells[1].Value = item.TenTourNgoaiNuoc;
                dgvQLTourNgoaiNguoc.Rows[index].Cells[2].Value = item.NgayDiNgoaiNuoc;
                dgvQLTourNgoaiNguoc.Rows[index].Cells[3].Value = item.NgayKetThucNgoaiNuoc;
                dgvQLTourNgoaiNguoc.Rows[index].Cells[4].Value = item.GiaTourNgoaiNuoc;
                dgvQLTourNgoaiNguoc.Rows[index].Cells[5].Value = item.SoNguoiDiNgoaiNuoc;
            }
        }
      
        //View trong nước
        private void dgvQLTourTrongNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLTourTrongNuoc.Rows.Count > 0 && e.RowIndex < dgvQLTourTrongNuoc.RowCount - 1)
            {
                string matourtn = dgvQLTourTrongNuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                DuLichDB context = new DuLichDB();
                TourTrongNuoc update = context.TourTrongNuocs.FirstOrDefault(p => p.MaTourTrongNuoc == matourtn);
                if (update != null)
                {
                    txtQLMaTour.Text = matourtn;
                    txtQLTenTour.Text = update.TenTourTrongNuoc;
                    dtQLNgayDi.Text = (update.NgayDiTrongNuoc).ToString();
                    dtQLNgayKT.Text = (update.NgayKetThucTrongNuoc).ToString();
                    txtQLGiaTour.Text = (update.GiaTourTrongNuoc).ToString();
                    numQLSoNguoiDi.Value = (decimal)(update.SoNguoiDiTrongNuoc);
                    //dtNgayKTTrongNuoc.Value = (DateTime)update.NgayKetThucTrongNuoc;
                }
            }
        }
      
        //View ngoài nước
        private void dgvQLTourNgoaiNguoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLTourNgoaiNguoc.Rows.Count > 0 && e.RowIndex < dgvQLTourNgoaiNguoc.RowCount - 1)
            {
                string matournn = dgvQLTourNgoaiNguoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                DuLichDB context = new DuLichDB();
                TourNgoaiNuoc update = context.TourNgoaiNuocs.FirstOrDefault(p => p.MaTourNgoaiNuoc == matournn);
                if (update != null)
                {
                    txtQLMaTour.Text = matournn;
                    txtQLTenTour.Text = update.TenTourNgoaiNuoc;
                    dtQLNgayDi.Text = (update.NgayDiNgoaiNuoc).ToString();
                    dtQLNgayKT.Text = (update.NgayKetThucNgoaiNuoc).ToString();
                    txtQLGiaTour.Text = (update.GiaTourNgoaiNuoc).ToString();
                    numQLSoNguoiDi.Value = (decimal)(update.SoNguoiDiNgoaiNuoc);
                    //dtNgayKTTrongNuoc.Value = (DateTime)update.NgayKetThucTrongNuoc;
                }
            }
        }

        //Thêm tour
        private void btnThemTour_Click(object sender, EventArgs e)
        {
            try
            {
                string notice = "";
                if (notice == "")
                {
                    if (string.IsNullOrEmpty(txtQLMaTour.Text))
                    {
                        notice += "Chưa nhập mã tour.";
                    }
                    if (string.IsNullOrEmpty(txtQLTenTour.Text))
                    {
                        notice += "Chưa nhập tên tour.";
                    }
                    if (string.IsNullOrEmpty(dtQLNgayDi.Text))
                    {
                        notice += "Chưa chọn ngày đi.";
                    }
                    if (string.IsNullOrEmpty(dtQLNgayKT.Text))
                    {
                        notice += "Chưa chọn ngày kết thúc.";
                    }
                    if (string.IsNullOrEmpty(txtQLGiaTour.Text))
                    {
                        notice += "Chưa nhập giá tour.";
                    }
                    if (string.IsNullOrEmpty(numQLSoNguoiDi.Text))
                    {
                        notice += "Chưa chọn số người đi.";
                    }
                }

                if ((string.IsNullOrEmpty(txtQLMaTour.Text)) || (string.IsNullOrEmpty(txtQLTenTour.Text)) || (string.IsNullOrEmpty(dtQLNgayDi.Text)) || (string.IsNullOrEmpty(dtQLNgayKT.Text)) || (string.IsNullOrEmpty(txtQLGiaTour.Text)) || (string.IsNullOrEmpty(numQLSoNguoiDi.Text)))
                {
                    MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DuLichDB context = new DuLichDB();
                    TourTrongNuoc addTN = context.TourTrongNuocs.FirstOrDefault(p => p.MaTourTrongNuoc == txtQLMaTour.Text);
                    TourNgoaiNuoc addNN = context.TourNgoaiNuocs.FirstOrDefault(o => o.MaTourNgoaiNuoc == txtQLMaTour.Text);

                    if (addTN == null || addNN == null)
                    {
                        //Thêm Tour Trong Nước
                        if (addTN == null && cmbTour.SelectedIndex == 1)
                        {
                            TourTrongNuoc s = new TourTrongNuoc()
                            {
                                MaTourTrongNuoc = txtQLMaTour.Text,
                                TenTourTrongNuoc = txtQLTenTour.Text,
                                NgayDiTrongNuoc = (DateTime)(dtQLNgayDi.Value),
                                NgayKetThucTrongNuoc = (DateTime)(dtQLNgayKT.Value),
                                GiaTourTrongNuoc = float.Parse(txtQLGiaTour.Text),
                                SoNguoiDiTrongNuoc = int.Parse(numQLSoNguoiDi.Text),
                            };

                            context.TourTrongNuocs.Add(s);

                            context.SaveChanges();

                            HienThiTourTN(context.TourTrongNuocs.ToList());

                            txtQLMaTour.Text = "";
                            txtQLTenTour.Text = "";
                            dtQLNgayDi.Value = DateTime.Now;
                            dtQLNgayKT.Value = DateTime.Now;
                            txtQLGiaTour.Text = "";
                            numQLSoNguoiDi.Value = 0;

                            MessageBox.Show("Thêm thành công!");
                        }

                        //Thêm Tour Ngoài Nước
                        else if (addNN == null && cmbTour.SelectedIndex == 0)
                        {
                            TourNgoaiNuoc r = new TourNgoaiNuoc()
                            {
                                MaTourNgoaiNuoc = txtQLMaTour.Text,
                                TenTourNgoaiNuoc = txtQLTenTour.Text,
                                NgayDiNgoaiNuoc = (DateTime)(dtQLNgayDi.Value),
                                NgayKetThucNgoaiNuoc = (DateTime)(dtQLNgayKT.Value),
                                GiaTourNgoaiNuoc = float.Parse(txtQLGiaTour.Text),
                                SoNguoiDiNgoaiNuoc = int.Parse(numQLSoNguoiDi.Text),
                            };

                            context.TourNgoaiNuocs.Add(r);

                            context.SaveChanges();

                            HienThiTourNN(context.TourNgoaiNuocs.ToList());

                            txtQLMaTour.Text = "";
                            txtQLTenTour.Text = "";
                            dtQLNgayDi.Value = DateTime.Now;
                            dtQLNgayKT.Value = DateTime.Now;
                            txtQLGiaTour.Text = "";
                            numQLSoNguoiDi.Value = 0;

                            MessageBox.Show("Thêm thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có tour này rồi!");
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Xóa tour
        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                TourTrongNuoc deleteTN = context.TourTrongNuocs.FirstOrDefault(p => p.MaTourTrongNuoc == txtQLMaTour.Text);
                TourNgoaiNuoc deleteNN = context.TourNgoaiNuocs.FirstOrDefault(p => p.MaTourNgoaiNuoc == txtQLMaTour.Text);

                if (deleteTN != null || deleteNN != null)
                {
                    //Xóa Tour Ngoài Nước
                    if (deleteTN != null)
                    {
                        context.TourTrongNuocs.Remove(deleteTN);

                        context.SaveChanges();

                        HienThiTourTN(context.TourTrongNuocs.ToList());
                        
                    }

                    //Xóa Tour Ngoài Nước
                    if (deleteNN != null)
                    {
                        context.TourNgoaiNuocs.Remove(deleteNN);

                        context.SaveChanges();

                        HienThiTourNN(context.TourNgoaiNuocs.ToList());

                    }
                    MessageBox.Show("Xoá tour thành công!");
                }
                
                else
                {
                    MessageBox.Show("Không tìm thấy tour cần xóa!");
                }

                txtQLMaTour.Text = "";
                txtQLTenTour.Text = "";
                dtQLNgayDi.Value = DateTime.Now;
                dtQLNgayKT.Value = DateTime.Now;
                txtQLGiaTour.Text = "";
                numQLSoNguoiDi.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sửa tour
        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                TourTrongNuoc updateTN = context.TourTrongNuocs.FirstOrDefault(p => p.MaTourTrongNuoc == txtQLMaTour.Text);
                TourNgoaiNuoc updateNN = context.TourNgoaiNuocs.FirstOrDefault(p => p.MaTourNgoaiNuoc == txtQLMaTour.Text);
                if (updateTN != null || updateNN != null)
                {
                    if(updateTN != null)
                    {
                        updateTN.TenTourTrongNuoc = txtQLTenTour.Text;
                        updateTN.NgayDiTrongNuoc = (DateTime)(dtQLNgayDi.Value);
                        updateTN.NgayKetThucTrongNuoc = (DateTime)(dtQLNgayKT.Value);
                        updateTN.GiaTourTrongNuoc = float.Parse(txtQLGiaTour.Text);

                        context.SaveChanges();

                        HienThiTourTN(context.TourTrongNuocs.ToList());                   
                    }
                    
                    if(updateNN != null)
                    {
                        updateNN.TenTourNgoaiNuoc = txtQLTenTour.Text;
                        updateNN.NgayDiNgoaiNuoc = (DateTime)(dtQLNgayDi.Value);
                        updateNN.NgayKetThucNgoaiNuoc = (DateTime)(dtQLNgayKT.Value);
                        updateNN.GiaTourNgoaiNuoc = float.Parse(txtQLGiaTour.Text);

                        context.SaveChanges();

                        HienThiTourNN(context.TourNgoaiNuocs.ToList());
                    }
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tour này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
