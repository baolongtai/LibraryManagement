namespace QLThuVien
{
    partial class frmBuy
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
            this.grInforBook = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateBuy = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNameReader = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBookRegister = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAcces = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clBookName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grInforBook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // grInforBook
            // 
            this.grInforBook.BackColor = System.Drawing.Color.Lavender;
            this.grInforBook.Controls.Add(this.btnCancel);
            this.grInforBook.Controls.Add(this.textBox1);
            this.grInforBook.Controls.Add(this.btnAcces);
            this.grInforBook.Controls.Add(this.comboBox1);
            this.grInforBook.Controls.Add(this.label2);
            this.grInforBook.Controls.Add(this.dtpDateBuy);
            this.grInforBook.Controls.Add(this.label1);
            this.grInforBook.Controls.Add(this.cbNameReader);
            this.grInforBook.Controls.Add(this.label7);
            this.grInforBook.Controls.Add(this.label6);
            this.grInforBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInforBook.Location = new System.Drawing.Point(7, 48);
            this.grInforBook.Name = "grInforBook";
            this.grInforBook.Size = new System.Drawing.Size(286, 466);
            this.grInforBook.TabIndex = 20;
            this.grInforBook.TabStop = false;
            this.grInforBook.Text = "Thông tin mua";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 24);
            this.textBox1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 26);
            this.comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã sinh viên";
            // 
            // dtpDateBuy
            // 
            this.dtpDateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBuy.Location = new System.Drawing.Point(119, 122);
            this.dtpDateBuy.Name = "dtpDateBuy";
            this.dtpDateBuy.Size = new System.Drawing.Size(155, 24);
            this.dtpDateBuy.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày mua";
            // 
            // cbNameReader
            // 
            this.cbNameReader.FormattingEnabled = true;
            this.cbNameReader.Location = new System.Drawing.Point(119, 91);
            this.cbNameReader.Name = "cbNameReader";
            this.cbNameReader.Size = new System.Drawing.Size(155, 26);
            this.cbNameReader.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgvBookRegister);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 469);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách yêu cầu";
            // 
            // dgvBookRegister
            // 
            this.dgvBookRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBookName,
            this.BOOK_NAME,
            this.TYPE_BOOK_NAME,
            this.SUBJECT_NAME,
            this.UNIT_PRICE});
            this.dgvBookRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookRegister.Location = new System.Drawing.Point(3, 20);
            this.dgvBookRegister.Name = "dgvBookRegister";
            this.dgvBookRegister.RowTemplate.Height = 24;
            this.dgvBookRegister.Size = new System.Drawing.Size(861, 446);
            this.dgvBookRegister.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 38);
            this.label4.TabIndex = 48;
            this.label4.Text = "DANH MỤC ĐĂNG KÝ SÁCH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAcces
            // 
            this.btnAcces.BackColor = System.Drawing.Color.Lavender;
            this.btnAcces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcces.ForeColor = System.Drawing.Color.Green;
            this.btnAcces.Location = new System.Drawing.Point(14, 157);
            this.btnAcces.Name = "btnAcces";
            this.btnAcces.Size = new System.Drawing.Size(108, 28);
            this.btnAcces.TabIndex = 49;
            this.btnAcces.Text = "Đăng ký";
            this.btnAcces.UseVisualStyleBackColor = false;
            this.btnAcces.Click += new System.EventHandler(this.btnAcces_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Lavender;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(166, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 28);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // clBookName
            // 
            this.clBookName.DataPropertyName = "BOOK_NAME";
            this.clBookName.HeaderText = "Tên sách";
            this.clBookName.Name = "clBookName";
            this.clBookName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clBookName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BOOK_NAME
            // 
            this.BOOK_NAME.DataPropertyName = "BOOK_NAME";
            this.BOOK_NAME.HeaderText = "Mã sách";
            this.BOOK_NAME.Name = "BOOK_NAME";
            this.BOOK_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TYPE_BOOK_NAME
            // 
            this.TYPE_BOOK_NAME.DataPropertyName = "TYPE_BOOK_NAME";
            this.TYPE_BOOK_NAME.HeaderText = "Thể loại";
            this.TYPE_BOOK_NAME.Name = "TYPE_BOOK_NAME";
            // 
            // SUBJECT_NAME
            // 
            this.SUBJECT_NAME.DataPropertyName = "SUBJECT_NAME";
            this.SUBJECT_NAME.HeaderText = "Môn học";
            this.SUBJECT_NAME.Name = "SUBJECT_NAME";
            // 
            // UNIT_PRICE
            // 
            this.UNIT_PRICE.DataPropertyName = "UNIT_PRICE";
            this.UNIT_PRICE.HeaderText = "Đơn giá";
            this.UNIT_PRICE.Name = "UNIT_PRICE";
            // 
            // frmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grInforBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuy";
            this.Text = "Nhập yêu cầu";
            this.Load += new System.EventHandler(this.frmBuy_Load);
            this.grInforBook.ResumeLayout(false);
            this.grInforBook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grInforBook;
        private System.Windows.Forms.ComboBox cbNameReader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBookRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateBuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAcces;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn clBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
    }
}