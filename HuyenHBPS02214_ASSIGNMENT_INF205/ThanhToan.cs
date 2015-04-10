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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        SqlConnection Connection;
        DataSet dataSet = new DataSet();
        SqlDataAdapter Adapter;
        string User;
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.MdiParent;
            User = f.mniUser.Text;
            txtMaKH.Focus();
            Connection = new SqlConnection(ConnectionString);
            //Hiển thị ngày hiện tại lên ô nhập bắt đầu
            txtNgayGD.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            Connection.Open();
            //Truy vấn loại sản phẩm và đổ vào dataSet
            String Sql =@"Select * from LoaiSanPham";
            Adapter = new SqlDataAdapter(Sql, Connection);
            Adapter.Fill(dataSet,"LoaiSanPham");
            //Truy vấn Sản phẩm và đổ vào dataSet
            String caulenh = @"Select * from SanPham";
            Adapter = new SqlDataAdapter(caulenh, Connection);
            Adapter.Fill(dataSet, "SanPham");
            dataSet.Tables["SanPham"].PrimaryKey = new DataColumn[]
            {
                dataSet.Tables["SanPham"].Columns["MaSP"]
            };
            //Hiển thị lên Combobox Loại
            cbxLoai.DataSource = dataSet.Tables["LoaiSanPham"];
            cbxLoai.ValueMember = "MaLoaiSP";
            cbxLoai.DisplayMember = "LoaiSP";

            nudSoLuong.Value = 1;
            btnBot.Enabled = false;
            btnTaoMoi.Enabled = false;
            cbxLoai.SelectedIndex = -1;
            cbxSanPham.SelectedIndex = -1;

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

        private void cbxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lọc sản phẩm theo loại được chọn
            DataView view = new DataView(dataSet.Tables["SanPham"]);
            view.RowFilter = "LoaiSanPham_MaLoaiSP='" + cbxLoai.SelectedValue + "'";
            //Hiển thị lên Combobox sản phẩm
            cbxSanPham.DataSource = view;
            cbxSanPham.ValueMember = "MaSP";
            cbxSanPham.DisplayMember = "TenSP";
        }
        double TongTien = 0;
        string MCTHD;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy mã hàng hoá được chọn tại combobox
                string MaSP = Convert.ToString(cbxSanPham.SelectedValue);
                DataRow Row = dataSet.Tables["SanPham"].Rows.Find(MaSP);
                //Lấy thông tin hàng hoá được chọn
                String TenSP = Convert.ToString(Row["TenSP"]);
                double DonGia = Convert.ToDouble(Row["DonGia"]);
                int SoLuong = Convert.ToInt32(nudSoLuong.Value);
                //Kiểm soát hàng tồn kho
                int SoLuongTon = Convert.ToInt32(Row["SoLuong"]);
                int SoLuongChon = Convert.ToInt32(nudSoLuong.Value);
                if (SoLuongChon > SoLuongTon)
                {
                    MessageBox.Show("Trong kho còn " + SoLuongTon + " sản phẩm");
                }
                else if ((cbxLoai.Text == "Chọn loại sản phẩm") || (cbxSanPham.Text == "Chọn sản phẩm"))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                }
                else if (nudSoLuong.Value == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng sản phẩm");
                }
                else
                {
                    btnBot.Enabled = true;
                    //Bổ sung lưới
                    dgvCTHD.Rows.Add(MaSP, TenSP, DonGia, SoLuong);
                    //Trừ đi số lượng tồn
                    String Sql = @"Update SanPham Set TenSP =@TenSP, DonGia=@DonGia, SoLuong=@SoLuong,ChiTietSP=@ChiTietSP where MaSP=@MaSP";
                    SqlCommand Command = new SqlCommand(Sql, Connection);
                    Command.Parameters.AddWithValue("@MaSP", MaSP);
                    Command.Parameters.AddWithValue("@TenSP", TenSP);
                    Command.Parameters.AddWithValue("@DonGia", DonGia);
                    Command.Parameters.AddWithValue("@SoLuong", SoLuongTon - SoLuongChon);
                    Command.Parameters.AddWithValue("@ChiTietSP", Row["ChiTietSP"]);
                    Command.ExecuteNonQuery();
                    MaSP = "";         
                    //Tổng hợp số liệu
                    TongTien += SoLuong * DonGia;
                    txtSoHang.Text = dgvCTHD.Rows.Count.ToString();
                    txtTongTien.Text = String.Format("{0:0,0}", TongTien).Replace(",", ".");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }
        string MaSP;
        string TenSP;
        int SoLuong;
        double DonGia;
        DataGridViewRow ViewRow = new DataGridViewRow();
        private void dgvCTHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy sản phẩm được chọn trên lưới
            ViewRow = dgvCTHD.Rows[e.RowIndex];
            MaSP = Convert.ToString(ViewRow.Cells[0].Value);
            TenSP = Convert.ToString(ViewRow.Cells[1].Value);
            DonGia = Convert.ToInt32(ViewRow.Cells[2].Value);
            SoLuong = Convert.ToInt32(ViewRow.Cells[3].Value);
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvCTHD.Rows.Count == 0)
                {
                    btnBot.Enabled = false;
                    MessageBox.Show("Chưa có sản phẩm nào được chọn");
                }
                else
                {
                    //Lấy thông tin của sản phẩm được chọn trên lưới
                    //Xoá sản phẩm ra khỏi lưới
                    TongTien -=SoLuong * DonGia;
                    dgvCTHD.Rows.Remove(ViewRow);                
                    txtTongTien.Text = String.Format("{0:0,0}", TongTien).Replace(",", ".");
                    if (txtTongTien.Text == "00")
                    {
                        txtTongTien.Text = "";
                    }
                    txtSoHang.Text = dgvCTHD.Rows.Count.ToString();
                    //Tìm sản phẩm bị xoá trong DataSet
                    DataRow Row = dataSet.Tables["SanPham"].Rows.Find(MaSP);
                    //Phục hồi số lượng tồn
                    String Sql = @"Update SanPham Set TenSP =@TenSP, DonGia=@DonGia, SoLuong=@SoLuong,ChiTietSP=@ChiTietSP where MaSP=@MaSP";
                    SqlCommand Command = new SqlCommand(Sql, Connection);
                    Command.Parameters.AddWithValue("@MaSP", MaSP);
                    Command.Parameters.AddWithValue("@TenSP", TenSP);
                    Command.Parameters.AddWithValue("@DonGia", DonGia);
                    Command.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(Row["SoLuong"]));
                    Command.Parameters.AddWithValue("@ChiTietSP", Row["ChiTietSP"]);
                    Command.ExecuteNonQuery();
                    SqlCommand cmm = new SqlCommand("Delete from ChiTietHoaDon where HoaDon_MaHD=@MaHD and SanPham_MaSP=@MaSP");
                    cmm.Parameters.AddWithValue("@MaHD", MCTHD);
                    cmm.Parameters.AddWithValue("@MaHD", MaSP);
                    Command.ExecuteNonQuery();
                }
                   
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
            finally
            {

            } 
        }
        string MaHD;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tiến hành thanh toán hoá đơn", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(dgvCTHD.Rows.Count > 0 )
                   {
                       string NgayGD = DateTime.Now.ToString();
                       string Sql = @"Insert into HoaDon Values(@MaHD,@TongTien,@NgayGD,@NhanVien_MaNV,@KhachHang_MaKH)";
                       SqlCommand Command = new SqlCommand(Sql, Connection);
                       String caulenh = @"Select * from HoaDon";
                       Adapter = new SqlDataAdapter(caulenh, Connection);
                       DataTable Table = new DataTable();
                       Adapter.Fill(Table);
                       int count = Table.Rows.Count + 1;
                       MaHD = "HD000" + count.ToString();
                       Command.Parameters.AddWithValue("@MaHD", MaHD);
                       Command.Parameters.AddWithValue("@TongTien", TongTien);
                       Command.Parameters.AddWithValue("@NgayGD", DateTime.Now);
                       Command.Parameters.AddWithValue("@NhanVien_MaNV", User);
                       Command.Parameters.AddWithValue("@KhachHang_MaKH", txtMaKH.Text);
                       Command.ExecuteNonQuery();     
                        //Thêm vào CTHD
                       SqlDataAdapter adapter = new SqlDataAdapter("Select * from ChiTietHoaDon", Connection);
                       DataTable tb = new DataTable();
                       adapter.Fill(tb);
                       int cthd = tb.Rows.Count + 1;
                       DataGridViewRow ViewRow = new DataGridViewRow();
                      
                       for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                       {

                           ViewRow = dgvCTHD.Rows[i];
                           MaSP = Convert.ToString(ViewRow.Cells[0].Value);
                           MCTHD = "CT0" + cthd.ToString();
                           String sqlInsert = @"Insert into ChiTietHoaDon Values(@MaCTHD,@SoLuongSP,@HoaDon_MaHD,@SanPham_MaSP)";
                           SqlCommand cmd = new SqlCommand(sqlInsert, Connection);
                           cmd.Parameters.AddWithValue("@MaCTHD", MCTHD);
                           cmd.Parameters.AddWithValue("@SoLuongSP", SoLuong);
                           cmd.Parameters.AddWithValue("@HoaDon_MaHD", MaHD);
                           cmd.Parameters.AddWithValue("@SanPham_MaSP", MaSP);
                           cmd.ExecuteNonQuery();
                           cthd += 1;
                       }
                       MessageBox.Show("Thanh toán thành công");
                       btnThanhToan.Enabled = false;
                       btnTaoMoi.Enabled = true;
                       btnBot.Enabled = false;
                       btnThem.Enabled = false;
                   }
                   else
                   {
                       MessageBox.Show("Vui lòng chọn mua sản phẩm");
                   }
                }
            }
          catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

         finally
            {
               
                txtMaKH.Focus();
            }


        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = true;
            txtMaKH.Clear();
            txtSoHang.Clear();
            txtTongTien.Clear();
            dgvCTHD.Rows.Clear();
            btnTaoMoi.Enabled = false;
            txtMaKH.Focus();
            btnBot.Enabled = true;
            btnThem.Enabled = true;
        }




    }
}
