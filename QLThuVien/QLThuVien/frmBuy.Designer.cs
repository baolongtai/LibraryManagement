﻿namespace QLThuVien
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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clBookName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grInforBook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grInforBook
            // 
            this.grInforBook.BackColor = System.Drawing.Color.Lavender;
            this.grInforBook.Controls.Add(this.textBox1);
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
            this.grInforBook.Size = new System.Drawing.Size(286, 162);
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
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 469);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách yêu cầu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBookName,
            this.BOOK_NAME,
            this.TYPE_BOOK_NAME,
            this.SUBJECT_NAME,
            this.QUANTITY,
            this.UNIT_PRICE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lavender;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(1064, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 28);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(896, 21);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(162, 24);
            this.cbSearch.TabIndex = 46;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(7, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 49;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Lavender;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(185, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 28);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // clBookName
            // 
            this.clBookName.DataPropertyName = "BOOK_NAME";
            this.clBookName.DataSource = this.bOOKSBindingSource;
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
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "Số lượng";
            this.QUANTITY.Name = "QUANTITY";
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grInforBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuy";
            this.Text = "Nhập yêu cầu";
            this.Load += new System.EventHandler(this.frmBuy_Load);
            this.grInforBook.ResumeLayout(false);
            this.grInforBook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grInforBook;
        private System.Windows.Forms.ComboBox cbNameReader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateBuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn clBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
    }
}