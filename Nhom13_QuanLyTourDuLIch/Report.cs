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
    public partial class formRP : Form
    {
        public formRP()
        {
            InitializeComponent();
        }

        public formRP(string makh, string tenkh, string tentour, string thanhtien, string ngaydi, string ngaykt, string ngaylap)
        {
            InitializeComponent();
            lblMaKHHD.Text = makh;
            lblTenKHHD.Text = tenkh;
            lblTenTourHD.Text = tentour;
            lblThanhTienHD.Text = thanhtien;
            lblNgayDiHD.Text = ngaydi;
            lblNgayKTHD.Text = ngaykt;
            lblNgayLapHD.Text = ngaylap;
        }

        private void Report_Load(object sender, EventArgs e)
        {
             
        }
    }
}
