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
using System.Data.Sql;

namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public partial class frmDMK : Form
    {
        public frmDMK()
        {
            InitializeComponent();
        }
        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        SqlConnection Connection;
        string User;
        private void frmDMK_Load(object sender, EventArgs e)
        {
           
            frmMain f = (frmMain)this.MdiParent;
            User = f.mniUser.Text;
            lblTK.Text = User;
        }
        private void btnDMK_Click(object sender, EventArgs e)
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            String sql = @"Select * from NhanVien where MaNV = '"+User+"'";
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, Connection);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            DataRow dr = Table.Rows[0]; 
            if (txtMKC.Text == dr[2].ToString())
            {
                String Sql = @"Update NhanVien set MatKhauDN =@Password where MaNV = @MaNV";
                SqlCommand Command = new SqlCommand(Sql, Connection);
                Command.Parameters.AddWithValue("@MaNV", User);
                Command.Parameters.AddWithValue("@Password", txtMKM.Text);
                Command.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công");
                txtMKC.Clear();
                txtMKM.Clear();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                txtMKC.Clear();
                txtMKM.Clear();
            }
            
        }

        private void pbxthoatform_Click(object sender, EventArgs e)
        {

            this.MdiParent.Height = 520;
            this.MdiParent.MainMenuStrip.Enabled = true;
            frmMain f = (frmMain)this.MdiParent;
            f.GetScreen();
            f.panelBackground.Visible = true;
            f.mnuTTin.Enabled = true;
            this.Close();
        }


    }
}
