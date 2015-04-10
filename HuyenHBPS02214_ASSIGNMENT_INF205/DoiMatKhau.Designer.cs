namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    partial class frmDMK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnDMK = new System.Windows.Forms.Button();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxthoatform = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxthoatform)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTK);
            this.panel1.Controls.Add(this.btnDMK);
            this.panel1.Controls.Add(this.txtMKM);
            this.panel1.Controls.Add(this.txtMKC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(280, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 236);
            this.panel1.TabIndex = 0;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTK.Location = new System.Drawing.Point(20, 12);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(159, 37);
            this.lblTK.TabIndex = 4;
            this.lblTK.Text = "Tài khoản";
            // 
            // btnDMK
            // 
            this.btnDMK.BackColor = System.Drawing.Color.Snow;
            this.btnDMK.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnDMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnDMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMK.Location = new System.Drawing.Point(157, 157);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(195, 23);
            this.btnDMK.TabIndex = 3;
            this.btnDMK.Text = "Đổi mật khẩu";
            this.btnDMK.UseVisualStyleBackColor = false;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(157, 118);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(195, 20);
            this.txtMKM.TabIndex = 2;
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(157, 88);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '*';
            this.txtMKC.Size = new System.Drawing.Size(195, 20);
            this.txtMKC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // pbxthoatform
            // 
            this.pbxthoatform.Image = global::HuyenHBPS02214_ASSIGNMENT_INF205.Properties.Resources.thoatform;
            this.pbxthoatform.Location = new System.Drawing.Point(3, 3);
            this.pbxthoatform.Name = "pbxthoatform";
            this.pbxthoatform.Size = new System.Drawing.Size(20, 20);
            this.pbxthoatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxthoatform.TabIndex = 16;
            this.pbxthoatform.TabStop = false;
            this.pbxthoatform.Click += new System.EventHandler(this.pbxthoatform_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(21, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thoát";
            // 
            // frmDMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.pbxthoatform);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDMK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxthoatform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxthoatform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTK;

    }
}