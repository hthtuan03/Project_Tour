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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private Form actForm = null;

        private void openView(Form View)
        {
            if(actForm != null) 
                actForm.Close();
            actForm = View;
            View.TopLevel = false;
            View.FormBorderStyle = FormBorderStyle.None;
            View.Dock = DockStyle.Fill;
            pnlView.Controls.Add(View);
            pnlView.Tag = View;
            View.BringToFront();
            View.Show();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            //openView(new frmTrangChu());
        }

        private void btnTourTrongNuoc_Click(object sender, EventArgs e)
        {
            pnlView.Size = new Size(1192, 785);
            this.Size = new Size(1218, 933);

            this.Hide();
            frmTourTrongNuoc tourTN = new frmTourTrongNuoc();

            tourTN.ShowDialog();
        }

        private void btnTourNgoaiNuoc_Click(object sender, EventArgs e)
        {
            pnlView.Size = new Size(1192, 785);
            this.Size = new Size(1218, 933);

            this.Hide();
            frmTourNgoaiNguoc tourNN = new frmTourNgoaiNguoc();
            
            tourNN.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(970, 640);
            pnlView.Size = new Size(980, 785);

            
            btnTourTrongNuoc.ForeColor = Color.FromArgb(64, 0, 64);
            btnTourTrongNuoc.ForeColor = Color.FromArgb(64, 64, 64);
            
            btnTourNgoaiNuoc.ForeColor = Color.FromArgb(64, 0, 64);
            btnTourNgoaiNuoc.ForeColor = Color.FromArgb(64, 64, 64);
         

            btnQuanLyThongTin.ForeColor = Color.FromArgb(64, 0, 64);
            btnQuanLyThongTin.ForeColor = Color.FromArgb(64, 64, 64);
           
            openView(new frmTrangChu());
        }

        private void btnQuanLyThongTin_Click(object sender, EventArgs e)
        {
            pnlView.Size = new Size(1192, 785);
            this.Size = new Size(1218, 933);

            this.Hide();
            QuanLy ql = new QuanLy();

            ql.ShowDialog();
        }
    }
}
