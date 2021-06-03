namespace QuanLyThuVien
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.Button btnLogOut;
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(318, 197);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(149, 40);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Nhân sự";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnReaders
            // 
            this.btnReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReaders.Image = ((System.Drawing.Image)(resources.GetObject("btnReaders.Image")));
            this.btnReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaders.Location = new System.Drawing.Point(318, 59);
            this.btnReaders.Name = "btnReaders";
            this.btnReaders.Size = new System.Drawing.Size(149, 40);
            this.btnReaders.TabIndex = 4;
            this.btnReaders.Text = "Độc giả";
            this.btnReaders.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogOut.ForeColor = System.Drawing.Color.Red;
            btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogOut.Location = new System.Drawing.Point(318, 323);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(149, 40);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Đăng Xuất";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(318, 151);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(149, 40);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnBuy.Image")));
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(318, 105);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(149, 40);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "Mua sách";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(318, 13);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(149, 40);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Sách";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 375);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(btnLogOut);
            this.Controls.Add(this.btnReaders);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Quản lý thư viện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnBuy;
    }
}