using Nhom13_QuanLyTourDuLIch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                List<NhanVien> listNV = context.NhanViens.ToList();
                //comboChucVuNV(listNV);
                HienThiNV(listNV);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void comboChucVuNV(List<NhanVien> listNV)
        {         
            this.cmbChucVuNV.DataSource = listNV;
            this.cmbChucVuNV.DisplayMember = "ChucVu";
            this.cmbChucVuNV.ValueMember = "MaNV";            
        }*/

        private void HienThiNV(List<NhanVien> listNV)
        {
            dgvQLNhanVien.Rows.Clear();
            foreach (var item in listNV)
            {
                int index = dgvQLNhanVien.Rows.Add();
                dgvQLNhanVien.Rows[index].Cells[0].Value = item.MaNV;
                dgvQLNhanVien.Rows[index].Cells[1].Value = item.TenNV;
                dgvQLNhanVien.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvQLNhanVien.Rows[index].Cells[3].Value = item.SDT;
                dgvQLNhanVien.Rows[index].Cells[4].Value = item.DiaChi;
                dgvQLNhanVien.Rows[index].Cells[5].Value = item.ChucVu;
            }
        }

        private void dgvQLNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLNhanVien.Rows.Count > 0 && e.RowIndex < dgvQLNhanVien.RowCount - 1)
            {
                string manv = dgvQLNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                DuLichDB context = new DuLichDB();
                NhanVien update = context.NhanViens.FirstOrDefault(p => p.MaNV == manv);
                if (update != null)
                {
                    txtQLMSNV.Text = manv;
                    txtQLTenNV.Text = update.TenNV;
                    dtQLNgaySinhNV.Text = (update.NgaySinh).ToString();
                    txtQLSoDTNV.Text = (update.SDT).ToString();
                    txtQLDiaChiNV.Text = update.DiaChi;
                    cmbChucVuNV.Text = update.ChucVu;
                }
            }
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            //lọc  các đối tượng "Nhân Viên" có  ChucVu bằng giá trị được chọn từ ComboBox 
            var listNV = context.NhanViens.ToList().Where(o => o.ChucVu == cmbTimNV.Text).ToList();
            HienThiNV(listNV);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string notice = "";
            if(notice == "")
            {
                if (string.IsNullOrEmpty(txtQLMSNV.Text))
                {
                    notice += "Chưa nhập mã nhân viên.";
                }
                if (string.IsNullOrEmpty(txtQLTenNV.Text))
                {
                    notice += "Chưa nhập tên nhân viên.";
                }
                if (string.IsNullOrEmpty(dtQLNgaySinhNV.Text))
                {
                    notice += "Chưa chọn ngày sinh nhân viên.";
                }
                if (string.IsNullOrEmpty(txtQLSoDTNV.Text))
                {
                    notice += "Chưa nhập số điện thoại nhân viên.";
                }
                if (string.IsNullOrEmpty(txtQLDiaChiNV.Text))
                {
                    notice += "Chưa nhập địa chỉ nhân viên.";
                }
                if (string.IsNullOrEmpty(cmbChucVuNV.Text))
                {
                    notice += "Chưa chọn chức vụ nhân viên.";
                }
            }
          
            if ((string.IsNullOrEmpty(txtQLMSNV.Text)) || (string.IsNullOrEmpty(txtQLTenNV.Text)) || (string.IsNullOrEmpty(dtQLNgaySinhNV.Text)) || (string.IsNullOrEmpty(txtQLSoDTNV.Text))  || (string.IsNullOrEmpty(txtQLDiaChiNV.Text)) || (string.IsNullOrEmpty(cmbChucVuNV.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DuLichDB context = new DuLichDB();
                NhanVien addNV = context.NhanViens.FirstOrDefault(p => p.MaNV ==  txtQLMSNV.Text);
                if (addNV == null)
                {
                    NhanVien nv = new NhanVien()
                    {
                        MaNV = txtQLMSNV.Text,
                        TenNV = txtQLTenNV.Text,
                        NgaySinh = dtQLNgaySinhNV.Value,
                        SDT = int.Parse(txtQLSoDTNV.Text),
                        DiaChi = txtQLDiaChiNV.Text,
                        ChucVu = cmbChucVuNV.Text
                    };
                    context.NhanViens.Add(nv);

                    context.SaveChanges();

                    HienThiNV(context.NhanViens.ToList());

                    txtQLMSNV.Text = "";
                    txtQLTenNV.Text = "";
                    dtQLNgaySinhNV.Value = DateTime.Now;
                    txtQLSoDTNV.Text = "";
                    txtQLDiaChiNV.Text = "";
                    cmbChucVuNV.SelectedItem = "";

                    MessageBox.Show("Thêm nhân viên thành công!");
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                NhanVien deleteNV = context.NhanViens.FirstOrDefault(p => p.MaNV == txtQLMSNV.Text);
                if (deleteNV != null)
                {
                    context.NhanViens.Remove(deleteNV);

                    context.SaveChanges();

                    HienThiNV(context.NhanViens.ToList());

                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên!");
                }

                txtQLMSNV.Text = "";
                txtQLTenNV.Text = "";
                dtQLNgaySinhNV.Value = DateTime.Now;
                txtQLSoDTNV.Text = "";
                txtQLDiaChiNV.Text = "";
                cmbChucVuNV.SelectedItem = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            NhanVien updateNV = context.NhanViens.FirstOrDefault(p => p.MaNV == txtQLMSNV.Text);
            if(updateNV != null)
            {
                updateNV.MaNV = txtQLMSNV.Text;
                updateNV.TenNV = txtQLTenNV.Text;
                updateNV.NgaySinh = (DateTime)(dtQLNgaySinhNV.Value);
                updateNV.SDT = int.Parse(txtQLSoDTNV.Text);
                updateNV.DiaChi = txtQLDiaChiNV.Text;
                updateNV.ChucVu = cmbChucVuNV.Text;

                context.SaveChanges();

                HienThiNV(context.NhanViens.ToList());

                MessageBox.Show("Sửa thông tin nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên!");
            }
        }
    }
}
