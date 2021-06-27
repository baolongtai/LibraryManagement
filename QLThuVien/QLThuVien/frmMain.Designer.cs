namespace QLThuVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.grbManage = new System.Windows.Forms.GroupBox();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.gbUnregistered = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbRegister = new System.Windows.Forms.CheckBox();
            this.gbRegistered = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clCodeReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNameReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbUnregistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(187, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 104);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(3, 200);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(180, 50);
            this.btnBill.TabIndex = 19;
            this.btnBill.Text = "Hóa Đơn";
            this.btnBill.UseCompatibleTextRendering = true;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // grbManage
            // 
            this.grbManage.BackColor = System.Drawing.Color.Azure;
            this.grbManage.Controls.Add(this.btnReader);
            this.grbManage.Controls.Add(this.btnBill);
            this.grbManage.Controls.Add(this.btnBuy);
            this.grbManage.Controls.Add(this.btnBook);
            this.grbManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbManage.Location = new System.Drawing.Point(0, 0);
            this.grbManage.Name = "grbManage";
            this.grbManage.Size = new System.Drawing.Size(187, 263);
            this.grbManage.TabIndex = 31;
            this.grbManage.TabStop = false;
            this.grbManage.Text = "Quản lý";
            this.grbManage.UseCompatibleTextRendering = true;
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReader.FlatAppearance.BorderSize = 0;
            this.btnReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.Location = new System.Drawing.Point(3, 88);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(180, 50);
            this.btnReader.TabIndex = 35;
            this.btnReader.Text = "Quản lý độc giả";
            this.btnReader.UseCompatibleTextRendering = true;
            this.btnReader.UseVisualStyleBackColor = false;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(3, 144);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(180, 50);
            this.btnBuy.TabIndex = 18;
            this.btnBuy.Text = "Mua sách";
            this.btnBuy.UseCompatibleTextRendering = true;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(3, 32);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(180, 50);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Quản lý sách";
            this.btnBook.UseCompatibleTextRendering = true;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 116);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.grbManage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 935);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 829);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 106);
            this.panel4.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Azure;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(0, 56);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 50);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(187, 50);
            this.btnLogOut.TabIndex = 37;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseCompatibleTextRendering = true;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.gbRegister);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(187, 116);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(1060, 935);
            this.pnlShow.TabIndex = 35;
            // 
            // gbRegister
            // 
            this.gbRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegister.Controls.Add(this.gbUnregistered);
            this.gbRegister.Controls.Add(this.cbRegister);
            this.gbRegister.Controls.Add(this.gbRegistered);
            this.gbRegister.Location = new System.Drawing.Point(420, 6);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(640, 674);
            this.gbRegister.TabIndex = 0;
            this.gbRegister.TabStop = false;
            // 
            // gbUnregistered
            // 
            this.gbUnregistered.Controls.Add(this.dataGridView2);
            this.gbUnregistered.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUnregistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnregistered.Location = new System.Drawing.Point(3, 675);
            this.gbUnregistered.Name = "gbUnregistered";
            this.gbUnregistered.Size = new System.Drawing.Size(634, 657);
            this.gbUnregistered.TabIndex = 2;
            this.gbUnregistered.TabStop = false;
            this.gbUnregistered.Text = "Thông tin sinh viên chưa đăng ký mua sách";
            this.gbUnregistered.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(628, 634);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sinh viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sinh viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Trạng thái";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cbRegister
            // 
            this.cbRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegister.AutoSize = true;
            this.cbRegister.Location = new System.Drawing.Point(538, 6);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(96, 21);
            this.cbRegister.TabIndex = 1;
            this.cbRegister.Text = "Rồi / Chưa";
            this.cbRegister.UseVisualStyleBackColor = true;
            this.cbRegister.CheckedChanged += new System.EventHandler(this.cbRegister_CheckedChanged);
            // 
            // gbRegistered
            // 
            this.gbRegistered.Controls.Add(this.dataGridView1);
            this.gbRegistered.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistered.Location = new System.Drawing.Point(3, 18);
            this.gbRegistered.Name = "gbRegistered";
            this.gbRegistered.Size = new System.Drawing.Size(634, 657);
            this.gbRegistered.TabIndex = 1;
            this.gbRegistered.TabStop = false;
            this.gbRegistered.Text = "Thông tin sinh viên đăng ký mua sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodeReader,
            this.clNameReader,
            this.clBookName,
            this.clStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 634);
            this.dataGridView1.TabIndex = 0;
            // 
            // clCodeReader
            // 
            this.clCodeReader.HeaderText = "Mã sinh viên";
            this.clCodeReader.Name = "clCodeReader";
            // 
            // clNameReader
            // 
            this.clNameReader.HeaderText = "Tên sinh viên";
            this.clNameReader.Name = "clNameReader";
            // 
            // clBookName
            // 
            this.clBookName.HeaderText = "Tên sách";
            this.clBookName.Name = "clBookName";
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Trạng thái";
            this.clStatus.Name = "clStatus";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1247, 1051);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.grbManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbUnregistered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbRegistered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.GroupBox grbManage;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.CheckBox cbRegister;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.GroupBox gbRegistered;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodeReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNameReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.GroupBox gbUnregistered;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}