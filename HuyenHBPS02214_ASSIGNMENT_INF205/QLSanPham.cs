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
using System.IO;

namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public partial class frmQLSanPham : Form
    {
       
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        DataSet dataSet = new DataSet();
        SqlDataReader Reader = null;
        SqlConnection Connection = null;
        SqlDataAdapter adapter = null;
        //Sự kiện FillListView, load dữ liệu vào Listview
        public void FillListView(string sql, ListView lvi)
        {
            try
            {
                this.lstviewDSSP.Items.Clear();         
                SqlCommand Command = new SqlCommand(sql, Connection);
                adapter = new SqlDataAdapter("Select * from LoaiSanPham ", Connection);
                adapter.Fill(dataSet, "LoaiSanPham");
                cbxLoaiSP.DataSource = dataSet.Tables["LoaiSanPham"];
                cbxLoaiSP.ValueMember = "MaLoaiSP";
                cbxLoaiSP.DisplayMember = "LoaiSP";
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    ListViewItem item;
                    item = new ListViewItem(Reader[0].ToString());
                    for (int j = 1; j < Reader.FieldCount; j++)
                        item.SubItems.Add(Reader[j].ToString());
                    lstviewDSSP.Items.Add(item);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cbxLoaiSP.Text = "Chọn loại sản phẩm";
                Reader.Close();
            }
        }
        //Clear các textbox
        public void ClearForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            cbxLoaiSP.SelectedIndex = -1;
            txtSL.Clear();
            txtChiTiet.Clear();
            pbxHinhAnh.ImageLocation = "";
            lblTaiAnh.Visible = true;
            txtMaSP.Focus();
        }
        //Sự kiện Form QLSanPham Load
        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Focus();
            String sql = "Select MaSP, TenSP, LoaiSP,Convert(decimal,DonGia), SoLuong, ChiTietSP from SanPham,LoaiSanPham where SanPham.LoaiSanPham_MaLoaiSP = LoaiSanPham.MaLoaiSP";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            this.FillListView(sql, lstviewDSSP);
            cbxLoaiSP.SelectedIndex = -1;
            pbxHinhAnh.ImageLocation = "Images/";
            
        }
        //Sự kiện item listview được chọn
        private void lstviewDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTaiAnh.Visible = false;
            txtMaSP.Focus();
            idSP = lstviewDSSP.FocusedItem.Text;
            String Sql = @"Select MaSP, TenSP, LoaiSP,Convert(decimal,DonGia) As DonGia, SoLuong, ChiTietSP,HinhAnh from SanPham,LoaiSanPham where SanPham.LoaiSanPham_MaLoaiSP = LoaiSanPham.MaLoaiSP and MaSP= @MaSP";
            SqlCommand Command = new SqlCommand(Sql, Connection);
            Command.Parameters.AddWithValue("@MaSP", idSP);
            SqlDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                dongia = Convert.ToDouble(Reader["DonGia"]);
                txtDonGia.Text = String.Format("{0:0,0}", dongia).Replace(",", ".");
                txtMaSP.Text = Convert.ToString(Reader["MaSP"]);
                txtTenSP.Text = Convert.ToString(Reader["TenSP"]);
                cbxLoaiSP.Text = Convert.ToString(Reader["LoaiSP"]);
                txtSL.Text = Convert.ToString(Reader["SoLuong"]);
                txtChiTiet.Text = Convert.ToString(Reader["ChiTietSP"]);
                pbxHinhAnh.ImageLocation = "Images/" + Reader["HinhAnh"];
            }
            Reader.Close();
        }
        //Biến lưu mã số sản phẩm
        string idSP;
        //Biến lưu loại sản phẩm
        string idMLSP;
        //Sự kiện nút Thêm click
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            pbxClear.Enabled = false;
            try
            {
                if ((txtMaSP.Text == "") || (txtTenSP.Text == "") || (txtSL.Text == "") || (txtDonGia.Text == "")
                   || (txtChiTiet.Text == "") || (cbxLoaiSP.SelectedValue.ToString() == "") || pbxHinhAnh.ImageLocation == "Images/")
                {
                     MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                     String SQLstr = "Select LoaiSP from SanPham,LoaiSanPham where SanPham.LoaiSanPham_MaLoaiSP = LoaiSanPham.MaLoaiSP and LoaiSanPham_MaLoaiSP = @MaLoaiSP";
                     SqlCommand Cmm = new SqlCommand(SQLstr, Connection);
                     Cmm.Parameters.AddWithValue("@MaLoaiSP", cbxLoaiSP.SelectedValue.ToString());
                     SqlDataReader Reader = Cmm.ExecuteReader();
                     if (Reader.Read())
                     {
                        idMLSP = Convert.ToString(Reader["LoaiSP"]);

                     }
                     Reader.Close();
                     String sql = "Insert into SanPham Values(@MaSP,@TenSP,@DonGia,@SoLuong,@ChiTietSP,@HinhAnh,@LoaiSanPham_MaLoaiSP)";
                     SqlCommand command = new SqlCommand(sql, Connection);
                     command.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                     command.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                     command.Parameters.AddWithValue("@DonGia", Convert.ToDouble(txtDonGia.Text.Replace(".","")));
                     command.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSL.Text));
                     command.Parameters.AddWithValue("@ChiTietSP", txtChiTiet.Text);
                     command.Parameters.AddWithValue("@HinhAnh", pbxHinhAnh.ImageLocation.Split('/')[1]);
                     command.Parameters.AddWithValue("@LoaiSanPham_MaLoaiSP", cbxLoaiSP.SelectedValue.ToString());
                     command.ExecuteNonQuery();
                     ListViewItem lvi = new ListViewItem(txtMaSP.Text);
                     lvi.SubItems.Add(txtTenSP.Text);
                     lvi.SubItems.Add(idMLSP);
                     lvi.SubItems.Add(txtDonGia.Text);
                     lvi.SubItems.Add(txtSL.Text);
                     lvi.SubItems.Add(txtChiTiet.Text);
                     lstviewDSSP.Items.Add(lvi);
                     this.ClearForm();
                }    
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            pbxClear.Enabled = true;
        }
        double dongia;
        //Sự kiện nút Xoá click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            pbxClear.Enabled = false;
            try
            {
                if (lstviewDSSP.SelectedItems.Count > 0)
                {
                    int selectindex = lstviewDSSP.SelectedIndices[0];
                    if (MessageBox.Show("Bạn muốn xoá sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lstviewDSSP.Items.Remove(lstviewDSSP.Items[selectindex]);
                        string Sql = "Delete from SanPham where MaSP ='" + idSP + "'";
                        SqlCommand Command = new SqlCommand(Sql, Connection);
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Xoá thành công");
                        this.ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            pbxClear.Enabled = true;
            
        }
        //Sự kiện nút Sửa click
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            pbxClear.Enabled = false;
             try
            {
                if (lstviewDSSP.SelectedItems.Count > 0)
                {
                    int selectindex = lstviewDSSP.SelectedIndices[0];
                    if (MessageBox.Show("Bạn muốn sửa sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String SQLstr = "Select LoaiSP from SanPham,LoaiSanPham where SanPham.LoaiSanPham_MaLoaiSP = LoaiSanPham.MaLoaiSP and LoaiSanPham_MaLoaiSP = @MaLoaiSP";
                        SqlCommand Cmm = new SqlCommand(SQLstr, Connection);
                        Cmm.Parameters.AddWithValue("@MaLoaiSP", cbxLoaiSP.SelectedValue.ToString());
                        SqlDataReader Reader = Cmm.ExecuteReader();
                        if (Reader.Read())
                        {
                            idMLSP = Convert.ToString(Reader["LoaiSP"]);

                        }
                        Reader.Close();
                        String sql = @"Update SanPham Set TenSP=@TenSP,DonGia=@DonGia,SoLuong=@SoLuong,ChiTietSP=@ChiTietSP,HinhAnh=@HinhAnh,LoaiSanPham_MaLoaiSP=@MaLoaiSP where MaSP = @MaSP";
                        SqlCommand command = new SqlCommand(sql, Connection);
                        command.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                        command.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                        command.Parameters.AddWithValue("@DonGia", Convert.ToDouble(txtDonGia.Text.Replace(".","")));
                        command.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(txtSL.Text));
                        command.Parameters.AddWithValue("@ChiTietSP", txtChiTiet.Text);
                        command.Parameters.AddWithValue("@MaLoaiSP", cbxLoaiSP.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@HinhAnh", pbxHinhAnh.ImageLocation.Split('/')[1]);
                        command.ExecuteNonQuery();
                        lstviewDSSP.Items.Remove(lstviewDSSP.Items[selectindex]);
                        ListViewItem lvi = new ListViewItem(txtMaSP.Text);
                        lvi.SubItems.Add(txtTenSP.Text);
                        lvi.SubItems.Add(idMLSP);
                        lvi.SubItems.Add(dongia.ToString());
                        lvi.SubItems.Add(txtSL.Text);
                        lvi.SubItems.Add(txtChiTiet.Text);
                        lstviewDSSP.Items.Add(lvi);
                        MessageBox.Show("Sửa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
             btnThem.Enabled = true;
             btnXoa.Enabled = true;
             pbxClear.Enabled = true;
            this.ClearForm();
           
        }
 
        //Sự kiện picturebox Clear click
        private void pbxClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }
        //Sự kiện pbxThoatform click
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
        string duongdan;
        string ten;
        private void pbxHinhAnh_Click(object sender, EventArgs e)
        {
            lblTaiAnh.Visible = false;
            if (ofdHinhAnh.ShowDialog() == DialogResult.OK)
            {
                duongdan = ofdHinhAnh.FileName;
                ten = ofdHinhAnh.SafeFileName;
                File.Copy(duongdan, "Images/" + ten, true);
                pbxHinhAnh.ImageLocation = "Images/" + ten;
            }
            else if (pbxHinhAnh.ImageLocation !="")
            {
                lblTaiAnh.Visible = false;
                
            }
            else
            {
                lblTaiAnh.Visible = true;
            }
        }

        private void lblTaiAnh_Click(object sender, EventArgs e)
        {
            lblTaiAnh.Visible = false;
            if (ofdHinhAnh.ShowDialog() == DialogResult.OK)
            {
                duongdan = ofdHinhAnh.FileName;
                ten = ofdHinhAnh.SafeFileName;
                File.Copy(duongdan, "Images/" + ten, true);
                pbxHinhAnh.ImageLocation = "Images/" + ten;
            }
            else
            {
                lblTaiAnh.Visible = true;
            }
        }

    }
}
