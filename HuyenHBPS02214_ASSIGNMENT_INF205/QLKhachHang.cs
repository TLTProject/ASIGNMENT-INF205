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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        SqlConnection Connection;
        //void FillGridView load dữ liệu lên DataGridView
        void FillGridView()
        {
            String Sql = "Select MaKH As 'Mã khách hàng', TenKH As 'Tên khách hàng', SDT As 'Số điện thoại', DiaChi As 'Địa chỉ' from KhachHang";
            SqlDataAdapter Adapter = new SqlDataAdapter(Sql, Connection);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            dgvDSKH.DataSource = Table;
        }
        //void clearform xoá các dữ liệu đã nhập vào textbox
        void ClearForm()
        {
            txtTenKH.Clear();
            txtMaKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMaKH.Focus();
        }
        //Sự kiện form frmQLKhachHang load lên
        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Focus();
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            this.FillGridView();
        }
        //Sự kiện chọn hàng trong Datagridview
        Object MaKH;
        private void dgvDSKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MaKH = dgvDSKH.Rows[e.RowIndex].Cells[0].Value;
            String Sql = @"Select * from KhachHang where MaKH= @MaKH";
            SqlCommand Command = new SqlCommand(Sql, Connection);
            Command.Parameters.AddWithValue("@MaKH", MaKH);
            SqlDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                txtMaKH.Text = Convert.ToString(Reader["MaKH"]);
                txtTenKH.Text = Convert.ToString(Reader["TenKH"]);
                txtSDT.Text = Convert.ToString(Reader["SDT"]);
                txtDiaChi.Text = Convert.ToString(Reader["DiaChi"]);
            }
            Reader.Close();
        }

        //Sự kiện nút Thêm click
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            pbxClear.Enabled = false;
            String Sql = @"Insert into KhachHang 
                           Values(@MaKH,@TenKH,@SDT,@DiaChi)";
            SqlCommand Command = new SqlCommand(Sql,Connection);
            Command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            Command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
            Command.Parameters.AddWithValue("@SDT", txtSDT.Text);
            Command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            Command.ExecuteNonQuery();
            this.FillGridView();
            this.ClearForm();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            pbxClear.Enabled = true;
                
        }

        //Sự kiện nút Xoá click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            pbxClear.Enabled = false;
            try
            {
                if (dgvDSKH.SelectedCells.Count > 0)
                {
                    if (MessageBox.Show("Bạn muốn xoá khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String Sql = @"Delete from KhachHang where MaKH=@MaKH";
                        SqlCommand Command = new SqlCommand(Sql, Connection);
                        Command.Parameters.AddWithValue("@MaKH", MaKH);
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Xoá thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.FillGridView();
            this.ClearForm();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            pbxClear.Enabled = true;
        }
        //Sự kiện nút Sửa click
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            pbxClear.Enabled = false;
            try
            {
                if (dgvDSKH.SelectedCells.Count > 0)
                {
                    if (MessageBox.Show("Bạn muốn sửa thông tin khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String Sql = @"Update KhachHang Set TenKH=@TenKH, SDT =@SDT, DiaChi =@DiaChi where MaKH = @MaKH";
                        SqlCommand Command = new SqlCommand(Sql, Connection);
                        Command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        Command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                        Command.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        Command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            this.FillGridView();
            this.ClearForm();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            pbxClear.Enabled = true;
        }
        //Sự kiện picturebox Clear click
        private void pbxClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
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

        private void frmQLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
 
    }
}
