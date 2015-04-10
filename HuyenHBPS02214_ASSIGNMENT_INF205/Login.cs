using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        String ConnectionString = @"workstation id=hbhcenter.mssql.somee.com;packet size=4096;user id=ps02214_SQLLogin_1;pwd=b9he7x6fme;data source=hbhcenter.mssql.somee.com;persist security info=False;initial catalog=hbhcenter";
        SqlConnection Connection;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\saodungdua.swf";
            if (HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Checkbox == true)
          {
              txtUsr.Text = HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Username;
              txtPwd.Text = HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Password;
              chkbxRemember.Checked = true;
          }
            else
          {
              HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Checkbox = false;
              HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Username = "";
              HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Password = "";
              chkbxRemember.Checked = false;
          }
         
        }

        public static void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Brush myBrush)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);
            g.FillPath(myBrush, gp);

        }
        public static void DrawRoundedRectangle1(Graphics g, Rectangle r, int d, Brush myBrush)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(r.X + r.Width, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);
            g.FillPath(myBrush, gp);
        }
        public static void DrawRoundedRectangle2(Graphics g, Rectangle r, int d, Brush myBrush)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);
            g.FillPath(myBrush, gp);

        }

        private void pbxx_Click(object sender, EventArgs e)
        {
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Checkbox = false;
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Username = "";
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Password = "";
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Save();
            System.Windows.Forms.Application.Exit();
        }

        private void lblmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkbxRemember.Checked)
            {
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Checkbox = true;
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Username = txtUsr.Text;
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Password = txtPwd.Text;
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Save();
            }

            if (chkbxRemember.Checked == false)
            {
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Checkbox = false;
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Username = "";
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Password = "";
                HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Save();
            }
            try
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();
                String Sql = "Select * from NhanVien where MaNV = '" + txtUsr.Text + "' and MatKhauDN = '" + txtPwd.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Sql, Connection);
                DataTable Table = new DataTable();
                Adapter.Fill(Table);
            
                if (Table.Rows.Count > 0)
                {
                    DataRow dr = Table.Rows[0];
                    if(dr[4].ToString() == "Quản trị")
                    {
                        frmMain Main = new frmMain();
                        Main.Getuser = txtUsr.Text;
                        Main.Show();
                        this.Hide();

                    }
                    if(dr[4].ToString() == "Administrators")
                    {
                        frmMain Main = new frmMain();
                        Main.Getuser = txtUsr.Text;
                        Main.Show();
                        this.Hide();

                    }
                    if(dr[4].ToString() == "Nhân viên")
                    {
                        frmMain Main = new frmMain();
                        Main.Getuser = txtUsr.Text;
                        Main.Show();
                        Main.mniQuanTri.Enabled = false;
                        this.Hide();
                    }
                }
               
                else
                {
                    lblThongbao.Visible = true;
                    lblThongbao.Text = "Tài khoản không tồn tại!";
                    txtUsr.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }


        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Purple);
            DrawRoundedRectangle(g, new Rectangle(0, 0, 1068, 536), 10, new SolidBrush(Color.Purple));

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Purple);
            DrawRoundedRectangle2(g, new Rectangle(0, 0, 1068,30), 10, new SolidBrush(Color.Black));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Purple);
            DrawRoundedRectangle1(g, new Rectangle(0, 0, 1068, 30), 10, new SolidBrush(Color.Black));
        }


    }
}
