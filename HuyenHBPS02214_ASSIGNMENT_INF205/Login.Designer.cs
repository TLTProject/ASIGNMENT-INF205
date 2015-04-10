namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmini = new System.Windows.Forms.Label();
            this.pbxx = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkbxRemember = new System.Windows.Forms.CheckBox();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxx)).BeginInit();
            this.SuspendLayout();
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(12, 0);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(1036, 535);
            this.axShockwaveFlash1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblmini);
            this.panel2.Controls.Add(this.pbxx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 30);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblmini
            // 
            this.lblmini.AutoSize = true;
            this.lblmini.BackColor = System.Drawing.Color.Transparent;
            this.lblmini.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmini.Location = new System.Drawing.Point(1025, 4);
            this.lblmini.Name = "lblmini";
            this.lblmini.Size = new System.Drawing.Size(10, 12);
            this.lblmini.TabIndex = 1;
            this.lblmini.Text = "_";
            this.lblmini.Click += new System.EventHandler(this.lblmini_Click);
            // 
            // pbxx
            // 
            this.pbxx.BackColor = System.Drawing.Color.Transparent;
            this.pbxx.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.x;
            this.pbxx.Location = new System.Drawing.Point(1042, 9);
            this.pbxx.Name = "pbxx";
            this.pbxx.Size = new System.Drawing.Size(14, 14);
            this.pbxx.TabIndex = 0;
            this.pbxx.TabStop = false;
            this.pbxx.Click += new System.EventHandler(this.pbxx_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Location = new System.Drawing.Point(924, 319);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkbxRemember
            // 
            this.chkbxRemember.AutoSize = true;
            this.chkbxRemember.BackColor = System.Drawing.Color.Purple;
            this.chkbxRemember.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxRemember.ForeColor = System.Drawing.Color.White;
            this.chkbxRemember.Location = new System.Drawing.Point(795, 324);
            this.chkbxRemember.Name = "chkbxRemember";
            this.chkbxRemember.Size = new System.Drawing.Size(83, 17);
            this.chkbxRemember.TabIndex = 3;
            this.chkbxRemember.Text = "Remember?";
            this.chkbxRemember.UseVisualStyleBackColor = false;
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.BackColor = System.Drawing.Color.Purple;
            this.lblThongbao.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.White;
            this.lblThongbao.Location = new System.Drawing.Point(793, 283);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(56, 13);
            this.lblThongbao.TabIndex = 3;
            this.lblThongbao.Text = "Thông báo";
            this.lblThongbao.Visible = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPwd.Location = new System.Drawing.Point(795, 254);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(204, 20);
            this.txtPwd.TabIndex = 2;
            // 
            // txtUsr
            // 
            this.txtUsr.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtUsr.Location = new System.Drawing.Point(795, 207);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(204, 20);
            this.txtUsr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(792, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 30);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(720, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(792, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tài khoản";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 536);
            this.Controls.Add(this.chkbxRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.axShockwaveFlash1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLogin_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkbxRemember;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmini;
        private System.Windows.Forms.PictureBox pbxx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}

