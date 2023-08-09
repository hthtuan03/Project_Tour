using Nhom13_QuanLyTourDuLIch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13_QuanLyTourDuLIch
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            try
            {
                DuLichDB context = new DuLichDB();
                List<TourTrongNuoc> tourTN = context.TourTrongNuocs.ToList();
                List<TourNgoaiNuoc> tourNN = context.TourNgoaiNuocs.ToList();

                cmbDiaDiemNoiTieng.Text = "2019";
                labelMT.Text = "TN001";
                labelTen.Text = "Hà Nội - Nhật Bản";
                string a = "H:\\Đồ án LT Windows\\icon\\NB1.jpg";
                ptTourBanChay.Image = Image.FromFile(a);
                ptTourBanChay.SizeMode = PictureBoxSizeMode.StretchImage;
                string a1 = "H:\\Đồ án LT Windows\\icon\\NB2.jpg";
                ptDiaDiemNoiTieng1.Image = Image.FromFile(a1);
                ptDiaDiemNoiTieng1.SizeMode = PictureBoxSizeMode.StretchImage;
                string a2 = "H:\\Đồ án LT Windows\\icon\\NB3.jpg";
                ptDiaDiemNoiTieng2.Image = Image.FromFile(a2);
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string a3 = "H:\\Đồ án LT Windows\\icon\\NB4.jpg";
                ptDiaDiemNoiTieng3.Image = Image.FromFile(a3);
                ptDiaDiemNoiTieng3.SizeMode = PictureBoxSizeMode.StretchImage;
                string a4 = "H:\\Đồ án LT Windows\\icon\\NB5.jpg";
                ptDiaDiemNoiTieng4.Image = Image.FromFile(a4);
                ptDiaDiemNoiTieng4.SizeMode = PictureBoxSizeMode.StretchImage;
                labelTien.Text = "30000000";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlTourBanChay_Paint(object sender, PaintEventArgs e)
        {
            /*if(cmbDiaDiemNoiTieng.SelectedIndex == 0)
            {
                labelMT.Text = "TN001";
                labelTen.Text = "Hà Nội - Nhật Bản";
                labelTien.Text = "30000000";
            }
            else if(cmbDiaDiemNoiTieng.SelectedIndex == 1)
            {
                labelMT.Text = "TT002";
                labelTen.Text = "Hà Nội - Đà Lạt";
                labelTien.Text = "6000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 2)
            {
                labelMT.Text = "TT001";
                labelTen.Text = "TP. Hồ Chí Minh - Bà Rịa-Vũng Tàu";
                labelTien.Text = "2000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 3)
            {
                labelMT.Text = "TN002";
                labelTen.Text = "TP. Hồ Chí Minh - Trung Quốc";
                labelTien.Text = "25000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 4)
            {
                labelMT.Text = "TN004";
                labelTen.Text = "Hà Nội - Hàn Quốc";
                labelTien.Text = "33000000";
            }*/
        }

        private void cmbDiaDiemNoiTieng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiaDiemNoiTieng.SelectedIndex == 0)
            {
                labelMT.Text = "TN001";
                labelTen.Text = "Hà Nội - Nhật Bản";
                string a = "H:\\Đồ án LT Windows\\icon\\NB1.jpg";
                ptTourBanChay.Image = Image.FromFile(a);
                ptTourBanChay.SizeMode = PictureBoxSizeMode.StretchImage;
                string a1 = "H:\\Đồ án LT Windows\\icon\\NB2.jpg";
                ptDiaDiemNoiTieng1.Image = Image.FromFile(a1);
                ptDiaDiemNoiTieng1.SizeMode = PictureBoxSizeMode.StretchImage;
                string a2 = "H:\\Đồ án LT Windows\\icon\\NB3.jpg";
                ptDiaDiemNoiTieng2.Image = Image.FromFile(a2);
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string a3 = "H:\\Đồ án LT Windows\\icon\\NB4.jpg";
                ptDiaDiemNoiTieng3.Image = Image.FromFile(a3);
                ptDiaDiemNoiTieng3.SizeMode = PictureBoxSizeMode.StretchImage;
                string a4 = "H:\\Đồ án LT Windows\\icon\\NB5.jpg";
                ptDiaDiemNoiTieng4.Image = Image.FromFile(a4);
                ptDiaDiemNoiTieng4.SizeMode = PictureBoxSizeMode.StretchImage;
                labelTien.Text = "30000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 1)
            {
                labelMT.Text = "TT002";
                labelTen.Text = "Hà Nội - Đà Lạt";
                string b = "H:\\Đồ án LT Windows\\icon\\DL1.jpg";
                ptTourBanChay.Image = Image.FromFile(b);
                ptTourBanChay.SizeMode = PictureBoxSizeMode.StretchImage;
                string b1 = "H:\\Đồ án LT Windows\\icon\\DL2.jpg";
                ptDiaDiemNoiTieng1.Image = Image.FromFile(b1);
                ptDiaDiemNoiTieng1.SizeMode = PictureBoxSizeMode.StretchImage;
                string b2 = "H:\\Đồ án LT Windows\\icon\\DL3.jpg";
                ptDiaDiemNoiTieng2.Image = Image.FromFile(b2);
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string b3 = "H:\\Đồ án LT Windows\\icon\\DL4.jpg";
                ptDiaDiemNoiTieng3.Image = Image.FromFile(b3);
                ptDiaDiemNoiTieng3.SizeMode = PictureBoxSizeMode.StretchImage;
                string b4 = "H:\\Đồ án LT Windows\\icon\\DL5.jpg";
                ptDiaDiemNoiTieng4.Image = Image.FromFile(b4);
                ptDiaDiemNoiTieng4.SizeMode = PictureBoxSizeMode.StretchImage;
                labelTien.Text = "6000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 2)
            {
                labelMT.Text = "TT001";
                labelTen.Text = "TP. Hồ Chí Minh - Bà Rịa-Vũng Tàu";             
                string c = "H:\\Đồ án LT Windows\\icon\\VT1.jpg";
                ptTourBanChay.Image = Image.FromFile(c);
                ptTourBanChay.SizeMode = PictureBoxSizeMode.StretchImage;
                string c1 = "H:\\Đồ án LT Windows\\icon\\VT2.jpg";
                ptDiaDiemNoiTieng1.Image = Image.FromFile(c1);
                ptDiaDiemNoiTieng1.SizeMode = PictureBoxSizeMode.StretchImage;
                string c2 = "H:\\Đồ án LT Windows\\icon\\VT3.jpg";
                ptDiaDiemNoiTieng2.Image = Image.FromFile(c2);
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string c3 = "H:\\Đồ án LT Windows\\icon\\VT4.jpg";
                ptDiaDiemNoiTieng3.Image = Image.FromFile(c3);
                ptDiaDiemNoiTieng3.SizeMode = PictureBoxSizeMode.StretchImage;
                string c4 = "H:\\Đồ án LT Windows\\icon\\VT5.jpg";
                ptDiaDiemNoiTieng4.Image = Image.FromFile(c4);
                ptDiaDiemNoiTieng4.SizeMode = PictureBoxSizeMode.StretchImage;
                labelTien.Text = "2000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 3)
            {
                labelMT.Text = "TN002";
                labelTen.Text = "TP. Hồ Chí Minh - Trung Quốc";
                string d = "H:\\Đồ án LT Windows\\icon\\TQ1.jpg";
                ptTourBanChay.Image = Image.FromFile(d);
                ptTourBanChay.SizeMode = PictureBoxSizeMode.StretchImage;
                string d1 = "H:\\Đồ án LT Windows\\icon\\TQ2.jpg";
                ptDiaDiemNoiTieng1.Image = Image.FromFile(d1);
                ptDiaDiemNoiTieng1.SizeMode = PictureBoxSizeMode.StretchImage;
                string d2 = "H:\\Đồ án LT Windows\\icon\\TQ3.jpg";
                ptDiaDiemNoiTieng2.Image = Image.FromFile(d2);
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string d3 = "H:\\Đồ án LT Windows\\icon\\TQ4.jpg";
                ptDiaDiemNoiTieng3.Image = Image.FromFile(d3);
                ptDiaDiemNoiTieng3.SizeMode = PictureBoxSizeMode.StretchImage;
                string d4 = "H:\\Đồ án LT Windows\\icon\\TQ5.jpg";
                ptDiaDiemNoiTieng4.Image = Image.FromFile(d4);
                ptDiaDiemNoiTieng4.SizeMode = PictureBoxSizeMode.StretchImage;
                labelTien.Text = "25000000";
            }
            else if (cmbDiaDiemNoiTieng.SelectedIndex == 4)
            {
                labelMT.Text = "TN004";
                labelTen.Text = "Hà Nội - Hàn Quốc";
                string f = "H:\\Đồ án LT Windows\\icon\\HQ1.jpg";
                ptTourBanChay.Image = Image.FromFile(f);
                ptTourBanChay.SizeMode = PictureBoxSizeMode.StretchImage;
                string f1 = "H:\\Đồ án LT Windows\\icon\\HQ2.jpg";
                ptDiaDiemNoiTieng1.Image = Image.FromFile(f1);
                ptDiaDiemNoiTieng1.SizeMode = PictureBoxSizeMode.StretchImage;
                string f2 = "H:\\Đồ án LT Windows\\icon\\HQ3.jpg";
                ptDiaDiemNoiTieng2.Image = Image.FromFile(f2);
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string f3 = "H:\\Đồ án LT Windows\\icon\\HQ4.jpg";
                ptDiaDiemNoiTieng3.Image = Image.FromFile(f3);
                ptDiaDiemNoiTieng3.SizeMode = PictureBoxSizeMode.StretchImage;
                ptDiaDiemNoiTieng2.SizeMode = PictureBoxSizeMode.StretchImage;
                string f4 = "H:\\Đồ án LT Windows\\icon\\HQ5.jpg";
                ptDiaDiemNoiTieng4.Image = Image.FromFile(f4);
                ptDiaDiemNoiTieng4.SizeMode = PictureBoxSizeMode.StretchImage;
                labelTien.Text = "33000000";
            }
        }
    }
}
