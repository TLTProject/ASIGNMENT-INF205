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
using System.Threading;
using System.Media;
using System.Runtime.InteropServices;
namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public partial class frmMain : Form
    {
        
        public string usr;
        public frmMain()
        {
            InitializeComponent();
            mnuTask.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable()); ;
            this.Opacity = 0.8;
        }
        public string Getuser
        {
            get { return usr; }
            set { usr = value; }
        }
      
        public void GetScreen()
        {
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
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
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);
            g.FillPath(myBrush, gp);

        }
       
        //sự kiện pbxTonghop Click
        private void pbxTong_Click(object sender, EventArgs e)
        {
        }
        //Sự kiện form Main Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            MdiClient chld;
            foreach (Control ctrl in this.Controls)
            {
                try
                {
                    chld = (MdiClient)ctrl;
                    chld.BackColor = this.BackColor;
                  

                }
                catch (InvalidCastException)
                {

                }
            }
            this.SetBevel(false);
            this.mniUser.Text = usr;
            axShockwaveFlash1.Movie = Application.StartupPath + "\\caboiloi.swf";

        }
        //Sự kiện pbx Exit click
        private void pbxExit_Click(object sender, EventArgs e)
        {
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Checkbox = false;
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Username = "";
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Password = "";
            HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Settings.Default.Save();
            System.Windows.Forms.Application.Exit();
        }
        
        //Sự kiện menuitem Click frmQLSanPham
        //Sự kiện menuitem Click frmTimKiem
        //Sự kiện menuitem Click frmQLLoaiSanPham

        private void mniSP_Click(object sender, EventArgs e)
        {
           
            frmQLSanPham f = new frmQLSanPham();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 700 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }
        private void mniLoaiSP_Click(object sender, EventArgs e)
        {
            frmQLLoaiSanPham f = new frmQLLoaiSanPham();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 389 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }
        //Sự kiện menuitem Click show frmQLKhachHang
        private void mniKH_Click(object sender, EventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 480 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }

        private void mniTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 557 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }

        private void mniTK_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 600 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {

            frmLogin f = new frmLogin();
            f.Show();
            this.Close();
        }

        private void mniLienHe_Click(object sender, EventArgs e)
        {
            frmLienHe f = new frmLienHe();
            f.ShowDialog();
        }
        //Sự kiện menuitem Click frmThanhToan
        private void mniThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan f = new frmThanhToan();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 640 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }

        private void mniDMK_Click(object sender, EventArgs e)
        {
            frmDMK f = new frmDMK();
            f.MdiParent = this;
            f.Show();
            this.ClientSize = new System.Drawing.Size(1024, 480 + 40);
            this.GetScreen();
            this.panelBackground.Visible = false;
            this.mnuTask.Enabled = false;
            this.mnuTTin.Enabled = false;
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Purple);
            DrawRoundedRectangle(g, new Rectangle(0, 0, 1024, 520), 10, new SolidBrush(Color.Purple));
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Purple);
            DrawRoundedRectangle1(g, new Rectangle(0, 0, 1024, 30), 10, new SolidBrush(Color.Black));
        }
    }
}
