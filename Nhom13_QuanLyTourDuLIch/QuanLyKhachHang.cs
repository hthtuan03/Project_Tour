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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                List<KhachHang> listKH = context.KhachHangs.ToList();
                HienThiKH(listKH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienThiKH(List<KhachHang> listKH)
        {
            dgvViewKH.Rows.Clear();
            foreach (var item in listKH)
            {
                int index = dgvViewKH.Rows.Add();
                dgvViewKH.Rows[index].Cells[0].Value = item.MaKH;
                dgvViewKH.Rows[index].Cells[1].Value = item.TenKH;
                dgvViewKH.Rows[index].Cells[2].Value = item.NgaySinhKH;
                dgvViewKH.Rows[index].Cells[3].Value = item.SDTKH;
                dgvViewKH.Rows[index].Cells[4].Value = item.DiaChiKH;
                dgvViewKH.Rows[index].Cells[5].Value = item.EmailKH;
            }
        }

        private void dgvViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewKH.Rows.Count > 0 && e.RowIndex < dgvViewKH.RowCount - 1)
            {
                string makh = dgvViewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                DuLichDB context = new DuLichDB();
                KhachHang update = context.KhachHangs.FirstOrDefault(p => p.MaKH == makh);
                if (update != null)
                {
                    txtQLMaKH.Text = makh;
                    txtQLTenKH.Text = update.TenKH;
                    dtQLNgaySinhKH.Text = (update.NgaySinhKH).ToString();
                    txtQLSoDTKH.Text = (update.SDTKH).ToString();
                    txtQLDiaChiKH.Text = update.DiaChiKH;
                    txtGmail.Text = update.EmailKH;
                }
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string notice = "";
            if (notice == "")
            {
                if (string.IsNullOrEmpty(txtQLMaKH.Text))
                {
                    notice += "Chưa nhập mã khách hàng.";
                }
                if (string.IsNullOrEmpty(txtQLTenKH.Text))
                {
                    notice += "Chưa nhập tên khách hàng.";
                }
                if (string.IsNullOrEmpty(dtQLNgaySinhKH.Text))
                {
                    notice += "Chưa chọn ngày sinh khách hàng.";
                }
                if (string.IsNullOrEmpty(txtQLSoDTKH.Text))
                {
                    notice += "Chưa nhập số điện thoại khách hàng.";
                }
                if (string.IsNullOrEmpty(txtQLDiaChiKH.Text))
                {
                    notice += "Chưa nhập địa chỉ khách hàng.";
                }
                if (string.IsNullOrEmpty(txtGmail.Text))
                {
                    notice += "Chưa nhập Gmail.";
                }
            }

            if ((string.IsNullOrEmpty(txtQLMaKH.Text)) || (string.IsNullOrEmpty(txtQLTenKH.Text)) || (string.IsNullOrEmpty(dtQLNgaySinhKH.Text)) || (string.IsNullOrEmpty(txtQLSoDTKH.Text)) || (string.IsNullOrEmpty(txtQLDiaChiKH.Text)) || (string.IsNullOrEmpty(txtGmail.Text)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DuLichDB context = new DuLichDB();
                KhachHang addKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtQLMaKH.Text);
                if (addKH == null)
                {
                    KhachHang kh = new KhachHang()
                    {
                        MaKH = txtQLMaKH.Text,
                        TenKH = txtQLTenKH.Text,
                        NgaySinhKH = dtQLNgaySinhKH.Value,
                        SDTKH = int.Parse(txtQLSoDTKH.Text),
                        DiaChiKH = txtQLDiaChiKH.Text,
                        EmailKH = txtGmail.Text
                    };
                    context.KhachHangs.Add(kh);

                    context.SaveChanges();

                    HienThiKH(context.KhachHangs.ToList());

                    txtQLMaKH.Text = "";
                    txtQLTenKH.Text = "";
                    dtQLNgaySinhKH.Value = DateTime.Now;
                    txtQLSoDTKH.Text = "";
                    txtQLDiaChiKH.Text = "";
                    txtGmail.Text = "";

                    MessageBox.Show("Thêm khách hàng thành công!");
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                KhachHang deleteKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtQLMaKH.Text);
                if (deleteKH != null)
                {
                    context.KhachHangs.Remove(deleteKH);

                    context.SaveChanges();

                    HienThiKH(context.KhachHangs.ToList());

                    MessageBox.Show("Xóa khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                }

                txtQLMaKH.Text = "";
                txtQLTenKH.Text = "";
                dtQLNgaySinhKH.Value = DateTime.Now;
                txtQLSoDTKH.Text = "";
                txtQLDiaChiKH.Text = "";
                txtGmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            DuLichDB context = new DuLichDB();
            KhachHang updateKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtQLMaKH.Text);
            if (updateKH != null)
            {
                updateKH.MaKH = txtQLMaKH.Text;
                updateKH.TenKH = txtQLTenKH.Text;
                updateKH.NgaySinhKH = (DateTime)(dtQLNgaySinhKH.Value);
                updateKH.SDTKH = int.Parse(txtQLSoDTKH.Text);
                updateKH.DiaChiKH = txtQLDiaChiKH.Text;
                updateKH.EmailKH = txtGmail.Text;

                context.SaveChanges();

                HienThiKH(context.KhachHangs.ToList());

                MessageBox.Show("Sửa thông tin khách hàng thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng!");
            }
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvViewKH.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }
            foreach (DataGridViewRow row in dgvViewKH.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[1].Value.ToString()?.IndexOf(txtTimKH.Text, StringComparison.OrdinalIgnoreCase) == -1)
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }
}
