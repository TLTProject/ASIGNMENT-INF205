using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Data.Sql;

namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public partial class frmQLLoaiSanPham : Form
    {
        public frmQLLoaiSanPham()
        {
            InitializeComponent();
        }
        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        SqlConnection Connection;
        private void pbxthoatform_Click(object sender, EventArgs e)
        {
            this.MdiParent.Height = 520;
            this.MdiParent.MainMenuStrip.Enabled = true;
            frmMain f = (frmMain)this.MdiParent;
            f.GetScreen();
            f.panelBackground.Visible = true;
            f.mnuTTin.Enabled = true;
            this.Close();
            Connection.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            try
            {
                if ((txtLSPham.Text =="") || (txtMLSPham.Text ==""))
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu");
                }
                else
                {
                    String Sql = @"Insert into LoaiSanPham
                           Values(@MaLoaiSP,@LoaiSP)";
                    SqlCommand Command = new SqlCommand(Sql, Connection);
                    Command.Parameters.AddWithValue("@MaLoaiSP", txtMLSPham.Text);
                    Command.Parameters.AddWithValue("@LoaiSP", txtLSPham.Text);
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnCapNhat.Enabled = true;
            
        }

        private void frmQLLoaiSanPham_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            try
            {
                if  ((txtMLSPham.Text == ""))
                {
                    MessageBox.Show("Vui lòng chọn mã loại sản phẩm");
                }
                else
                {
                    String Sql = @"Update LoaiSanPham Set LoaiSP=@LoaiSP where MaLoaiSP = @MaLoaiSP";
                    SqlCommand Command = new SqlCommand(Sql, Connection);
                    Command.Parameters.AddWithValue("@MaLoaiSP", txtMLSPham.Text);
                    Command.Parameters.AddWithValue("@LoaiSP", txtLSPham.Text);
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnCapNhat.Enabled = true;

        
        }
    }
}
