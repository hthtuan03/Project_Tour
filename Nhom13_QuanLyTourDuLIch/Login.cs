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
using System.Data.SqlClient;


namespace Nhom13_QuanLyTourDuLIch
{
    public partial class frmLogin : Form
    {   
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /*string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (tk.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản!"); return; }
            else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); return; }
            else
            {
                //SQL
            }

            /*frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();*/

            //Application.Exit();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GHISU8I\\SQLEXPRESS;Initial Catalog=QLTourDuLichDoAn;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "Select * from Login where Username = '"+tk+"' and Password = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read() == true)
                {
                    frmMain main = new frmMain();
                    this.Hide();                  
                    main.ShowDialog();                   
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}
