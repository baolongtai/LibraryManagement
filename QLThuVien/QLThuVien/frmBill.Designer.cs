namespace QLThuVien
{
    partial class frmBill
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 38);
            this.label4.TabIndex = 49;
            this.label4.Text = "DANH MỤC HÓA ĐƠN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBillID,
            this.clReaderID,
            this.clReaderName,
            this.clBookID,
            this.clBookName,
            this.clCategory,
            this.clUnitPrice});
            this.dataGridView1.Location = new System.Drawing.Point(465, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 569);
            this.dataGridView1.TabIndex = 50;
            // 
            // clBillID
            // 
            this.clBillID.HeaderText = "Mã hóa đơn";
            this.clBillID.Name = "clBillID";
            // 
            // clReaderID
            // 
            this.clReaderID.HeaderText = "Mã sinh viên";
            this.clReaderID.Name = "clReaderID";
            // 
            // clReaderName
            // 
            this.clReaderName.HeaderText = "Tên sinh viên";
            this.clReaderName.Name = "clReaderName";
            // 
            // clBookID
            // 
            this.clBookID.HeaderText = "Mã sách";
            this.clBookID.Name = "clBookID";
            // 
            // clBookName
            // 
            this.clBookName.HeaderText = "Tên sách";
            this.clBookName.Name = "clBookName";
            // 
            // clCategory
            // 
            this.clCategory.HeaderText = "Thể loại";
            this.clCategory.Name = "clCategory";
            // 
            // clUnitPrice
            // 
            this.clUnitPrice.HeaderText = "Đơn giá";
            this.clUnitPrice.Name = "clUnitPrice";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 870);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnitPrice;

    }
}