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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
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
        }
        void FillDS()
        {
            String sql = @"Select MaNV As 'Mã tài khoản',TenNV As 'Tên nhân viên',MatKhauDN As 'Mật khẩu', SDT As 'Số điện thoại', Chucvu As 'Chức vụ', NgayBatDau As 'Ngày bắt đầu' from NhanVien";
            
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, Connection);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            dgvDSTK.DataSource = Table;
            txtDKMaNV.Focus();
        }
        void Clear()
        {
            txtDKMaNV.Clear();
            txtDKPassword.Clear();
            cbxChucVu.SelectedIndex = -1;
            txtDKTenNV.Clear();
            txtDKSDT.Clear();
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            cbxChucVu.Items.Add("Administrators");
            cbxChucVu.Items.Add("Quản trị");
            cbxChucVu.Items.Add("Nhân viên");
            this.FillDS();
        }
        private void dgvDSTK_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Object MaNV = dgvDSTK.Rows[e.RowIndex].Cells[0].Value;
            String Sql = @"Select * from NhanVien where MaNV= @MaNV";
            SqlCommand Command = new SqlCommand(Sql, Connection);
            Command.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                txtDKMaNV.Text = Convert.ToString(Reader["MaNV"]);
                txtDKTenNV.Text = Convert.ToString(Reader["TenNV"]);
                txtDKPassword.Text = Convert.ToString(Reader["MatKhauDN"]);
                txtDKSDT.Text = Convert.ToString(Reader["SDT"]);
                cbxChucVu.Text = Convert.ToString(Reader["ChucVu"]);
                dtpNBDau.Value = Convert.ToDateTime(Reader["NgayBatDau"]);
            }
            Reader.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnEdit.Enabled = false;
            try
            {
                if ((txtDKPassword.Text == "") || (txtDKMaNV.Text == "") || (cbxChucVu.Text =="") || (txtDKSDT.Text =="") || (txtDKTenNV.Text =="") || (dtpNBDau.Text.Length <= 0))
                {
                    MessageBox.Show("Vui lòng nhập thông tin");
                }
                else
                {
                    String caulenh = @"Select * from NhanVien";
                    SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, Connection);
                    String Sql = @"Insert into NhanVien values(@MaNV,@TenNV,@Password,@SDT,@Chucvu,@NgayBatDau)";
                    SqlCommand command = new SqlCommand(Sql, Connection);
                    command.Parameters.AddWithValue("@MaNV", txtDKMaNV.Text);
                    command.Parameters.AddWithValue("@TenNV", txtDKTenNV.Text);
                    command.Parameters.AddWithValue("@Password", txtDKPassword.Text);
                    command.Parameters.AddWithValue("@SDT", txtDKSDT.Text);
                    command.Parameters.AddWithValue("@Chucvu", cbxChucVu.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@NgayBatDau", dtpNBDau.Value.Date);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            this.FillDS();
            this.Clear();
            btnXoa.Enabled = true;
            btnEdit.Enabled = true;
            }     
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            try
            {
                if (dgvDSTK.SelectedCells.Count > 0)
                {
                    if (MessageBox.Show("Bạn muốn xoá tài khoản này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String Sql = @"Delete from TaiKhoan where MaNV=@MaNV";
                        SqlCommand Command = new SqlCommand(Sql, Connection);
                        Command.Parameters.AddWithValue("@MaNV", txtDKMaNV);
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
            this.FillDS();
            this.Clear();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnXoa.Enabled = false;
            try
            {
                if (dgvDSTK.SelectedCells.Count > 0)
                {
                    if (MessageBox.Show("Bạn muốn sửa tài khoản này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String Sql = @"Update NhanVien Set TenNV = @TenNV, MatKhauDN =@Pass,Chucvu =@Chucvu, NgayBatDau=@NgayBatDau where MaNV = @MaNV";
                        SqlCommand Command = new SqlCommand(Sql, Connection);
                        Command.Parameters.AddWithValue("@MaNV", txtDKMaNV.Text);
                        Command.Parameters.AddWithValue("@TenNV", txtDKTenNV.Text);
                        Command.Parameters.AddWithValue("@Pass", txtDKPassword.Text);
                        Command.Parameters.AddWithValue("@Chucvu", cbxChucVu.SelectedItem.ToString());
                        Command.Parameters.AddWithValue("@NgayBatDau", dtpNBDau.Value.Date);
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
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
            this.FillDS();
            this.Clear();
            btnAdd.Enabled = true;
            btnXoa.Enabled = true;
          
        }


    }
}
