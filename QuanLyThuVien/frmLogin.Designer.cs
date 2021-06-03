namespace QuanLyThuVien
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(443, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(248, 51);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Đăng Nhập";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(386, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên đăng nhập";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(386, 115);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Mật khẩu";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Green;
            this.btLogin.Image = ((System.Drawing.Image)(resources.GetObject("btLogin.Image")));
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(424, 202);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(151, 38);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseMnemonic = false;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(594, 202);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(127, 38);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(497, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(497, 112);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(224, 22);
            this.txtPass.TabIndex = 7;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(497, 140);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(78, 21);
            this.cbShow.TabIndex = 8;
            this.cbShow.Text = "Hiển thị";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 264);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox cbShow;
    }
}

