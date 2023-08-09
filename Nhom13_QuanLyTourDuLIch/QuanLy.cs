using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private Form actFormQL = null;

        private void openViewQL(Form View)
        {
            if (actFormQL != null)
                actFormQL.Close();
            actFormQL = View;
            View.TopLevel = false;
            View.FormBorderStyle = FormBorderStyle.None;
            View.Dock = DockStyle.Fill;
            pnlViewQL.Controls.Add(View);
            pnlViewQL.Tag = View;
            View.BringToFront();
            View.Show();
        }

        private void btnQLTour_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 950);
            pnlViewQL.Size = new Size(1110, 950);


            btnQLTour.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLTour.ForeColor = Color.FromArgb(64, 64, 64);

            btnQLKhachHang.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLKhachHang.ForeColor = Color.FromArgb(64, 64, 64);


            btnQLNhanVien.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLNhanVien.ForeColor = Color.FromArgb(64, 64, 64);

            openViewQL(new QuanLyTour());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 950);
            pnlViewQL.Size = new Size(1110, 950);


            btnQLTour.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLTour.ForeColor = Color.FromArgb(64, 64, 64);

            btnQLKhachHang.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLKhachHang.ForeColor = Color.FromArgb(64, 64, 64);


            btnQLNhanVien.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLNhanVien.ForeColor = Color.FromArgb(64, 64, 64);
            openViewQL(new QuanLyKhachHang());
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 950);
            pnlViewQL.Size = new Size(1110, 950);


            btnQLTour.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLTour.ForeColor = Color.FromArgb(64, 64, 64);

            btnQLKhachHang.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLKhachHang.ForeColor = Color.FromArgb(64, 64, 64);


            btnQLNhanVien.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLNhanVien.ForeColor = Color.FromArgb(64, 64, 64);
            openViewQL(new QuanLyNhanVien());
        }

        private void btnReturn_Click(object sender, EventArgs e)
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

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 950);
            pnlViewQL.Size = new Size(1110, 950);


            btnQLTour.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLTour.ForeColor = Color.FromArgb(64, 64, 64);

            btnQLKhachHang.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLKhachHang.ForeColor = Color.FromArgb(64, 64, 64);


            btnQLNhanVien.ForeColor = Color.FromArgb(64, 0, 64);
            btnQLNhanVien.ForeColor = Color.FromArgb(64, 64, 64);
            openViewQL(new QuanLyHoaDon());
        }
    }
}
