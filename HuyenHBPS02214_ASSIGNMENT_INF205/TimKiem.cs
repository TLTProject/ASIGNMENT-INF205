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
using System.Data.Sql;
using System.Data.SqlClient;

namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public partial class frmTimKiem : Form
    {
        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        SqlConnection Connection;
        SqlDataAdapter Adapter;
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            string Sql = @"Select * from LoaiSanPham";
            Adapter = new SqlDataAdapter(Sql, Connection);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            cbxChon.DataSource = Table;
            cbxChon.ValueMember = "MaLoaiSP";
            cbxChon.DisplayMember = "LoaiSP";
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
            Connection.Close();
        }

        private void cbxChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLoaiSP = cbxChon.SelectedValue.ToString();
            string Sql = @"Select MaSP As 'Mã sản phẩm',TenSP As 'Tên sản phẩm', Convert(decimal,DonGia) As 'Đơn giá', SoLuong As 'Số lượng', LoaiSanPham_MaLoaiSP As 'Mã loại sản phẩm' from SanPham where LoaiSanPham_MaLoaiSP = @MaLoaiSP";
            Adapter = new SqlDataAdapter(Sql, Connection);
            Adapter.SelectCommand.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            dgvDSKQ.DataSource = Table;
        }


    }
}
