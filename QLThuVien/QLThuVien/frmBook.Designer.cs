namespace QLThuVien
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.BOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBLISHING_YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpPublishingYear = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPublisherID_2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grInforBook = new System.Windows.Forms.GroupBox();
            this.txbAuthorID_2 = new System.Windows.Forms.TextBox();
            this.txbTypeBookID_2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nmudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataReceipt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.txbUnitPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tpProducer = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDeletePublisher = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvPulisher = new System.Windows.Forms.DataGridView();
            this.PUBLISHER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBLISHER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txbPublisherID = new System.Windows.Forms.TextBox();
            this.txbPublisherName = new System.Windows.Forms.TextBox();
            this.tpAuthor = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.AUTHOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbAuthorID = new System.Windows.Forms.TextBox();
            this.txbAuthorName = new System.Windows.Forms.TextBox();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTypeBook = new System.Windows.Forms.DataGridView();
            this.TYPE_BOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_BOOK_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.tctBook = new System.Windows.Forms.TabControl();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grInforBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudQuantity)).BeginInit();
            this.tpProducer.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPulisher)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tpAuthor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeBook)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tctBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(175, 367);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 28);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOK_ID,
            this.BOOK_NAME,
            this.QUANTITY,
            this.UNIT_PRICE,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.PUBLISHING_YEAR,
            this.DATE_RECEIPT});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(3, 20);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(1175, 443);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // BOOK_ID
            // 
            this.BOOK_ID.DataPropertyName = "BOOK_ID";
            this.BOOK_ID.HeaderText = "Mã sách";
            this.BOOK_ID.Name = "BOOK_ID";
            // 
            // BOOK_NAME
            // 
            this.BOOK_NAME.DataPropertyName = "BOOK_NAME";
            this.BOOK_NAME.HeaderText = "Tên sách";
            this.BOOK_NAME.Name = "BOOK_NAME";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TYPE_BOOK_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã loại sách";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AUTHOR_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã tác giả";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PUBLISHER_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã nhà sản xuất";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // PUBLISHING_YEAR
            // 
            this.PUBLISHING_YEAR.DataPropertyName = "PUBLISHING_YEAR";
            this.PUBLISHING_YEAR.HeaderText = "Năm sản xuất";
            this.PUBLISHING_YEAR.Name = "PUBLISHING_YEAR";
            // 
            // DATE_RECEIPT
            // 
            this.DATE_RECEIPT.DataPropertyName = "DATE_RECEIPT";
            this.DATE_RECEIPT.HeaderText = "Ngày nhập";
            this.DATE_RECEIPT.Name = "DATE_RECEIPT";
            // 
            // dtpPublishingYear
            // 
            this.dtpPublishingYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublishingYear.Location = new System.Drawing.Point(414, 122);
            this.dtpPublishingYear.Name = "dtpPublishingYear";
            this.dtpPublishingYear.Size = new System.Drawing.Size(155, 24);
            this.dtpPublishingYear.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgvBook);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 466);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sách trong thư viện";
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRepair.FlatAppearance.BorderSize = 0;
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRepair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRepair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRepair.Location = new System.Drawing.Point(115, 241);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(102, 28);
            this.btnRepair.TabIndex = 38;
            this.btnRepair.Text = "Sửa";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteBook.Location = new System.Drawing.Point(483, 241);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(102, 28);
            this.btnDeleteBook.TabIndex = 37;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddBook.Location = new System.Drawing.Point(7, 241);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(102, 28);
            this.btnAddBook.TabIndex = 36;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(287, 125);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Năm xuất bản";
            // 
            // txbPublisherID_2
            // 
            this.txbPublisherID_2.Location = new System.Drawing.Point(414, 91);
            this.txbPublisherID_2.Name = "txbPublisherID_2";
            this.txbPublisherID_2.Size = new System.Drawing.Size(155, 24);
            this.txbPublisherID_2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(287, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(287, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(11, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // grInforBook
            // 
            this.grInforBook.BackColor = System.Drawing.Color.Lavender;
            this.grInforBook.Controls.Add(this.txbAuthorID_2);
            this.grInforBook.Controls.Add(this.txbTypeBookID_2);
            this.grInforBook.Controls.Add(this.label20);
            this.grInforBook.Controls.Add(this.label17);
            this.grInforBook.Controls.Add(this.nmudQuantity);
            this.grInforBook.Controls.Add(this.label10);
            this.grInforBook.Controls.Add(this.dtpDataReceipt);
            this.grInforBook.Controls.Add(this.label1);
            this.grInforBook.Controls.Add(this.dtpPublishingYear);
            this.grInforBook.Controls.Add(this.label9);
            this.grInforBook.Controls.Add(this.txbPublisherID_2);
            this.grInforBook.Controls.Add(this.label8);
            this.grInforBook.Controls.Add(this.label2);
            this.grInforBook.Controls.Add(this.label6);
            this.grInforBook.Controls.Add(this.label5);
            this.grInforBook.Controls.Add(this.label4);
            this.grInforBook.Controls.Add(this.label3);
            this.grInforBook.Controls.Add(this.txbBookID);
            this.grInforBook.Controls.Add(this.txbBookName);
            this.grInforBook.Controls.Add(this.txbUnitPrice);
            this.grInforBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInforBook.Location = new System.Drawing.Point(7, 48);
            this.grInforBook.Name = "grInforBook";
            this.grInforBook.Size = new System.Drawing.Size(578, 187);
            this.grInforBook.TabIndex = 35;
            this.grInforBook.TabStop = false;
            this.grInforBook.Text = "Thông tin sách";
            // 
            // txbAuthorID_2
            // 
            this.txbAuthorID_2.Location = new System.Drawing.Point(414, 60);
            this.txbAuthorID_2.Name = "txbAuthorID_2";
            this.txbAuthorID_2.Size = new System.Drawing.Size(155, 24);
            this.txbAuthorID_2.TabIndex = 25;
            // 
            // txbTypeBookID_2
            // 
            this.txbTypeBookID_2.Location = new System.Drawing.Point(414, 29);
            this.txbTypeBookID_2.Name = "txbTypeBookID_2";
            this.txbTypeBookID_2.Size = new System.Drawing.Size(155, 24);
            this.txbTypeBookID_2.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(287, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 18);
            this.label20.TabIndex = 23;
            this.label20.Text = "Mã tác giả";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(216, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 18);
            this.label17.TabIndex = 22;
            this.label17.Text = "cuốn";
            // 
            // nmudQuantity
            // 
            this.nmudQuantity.Location = new System.Drawing.Point(100, 91);
            this.nmudQuantity.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nmudQuantity.Name = "nmudQuantity";
            this.nmudQuantity.Size = new System.Drawing.Size(99, 24);
            this.nmudQuantity.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(11, 156);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ngày Nhập";
            // 
            // dtpDataReceipt
            // 
            this.dtpDataReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReceipt.Location = new System.Drawing.Point(100, 153);
            this.dtpDataReceipt.Name = "dtpDataReceipt";
            this.dtpDataReceipt.Size = new System.Drawing.Size(155, 24);
            this.dtpDataReceipt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(218, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên sách";
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(100, 29);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(155, 24);
            this.txbBookID.TabIndex = 2;
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(100, 60);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(155, 24);
            this.txbBookName.TabIndex = 3;
            // 
            // txbUnitPrice
            // 
            this.txbUnitPrice.Location = new System.Drawing.Point(100, 122);
            this.txbUnitPrice.MaxLength = 10;
            this.txbUnitPrice.Name = "txbUnitPrice";
            this.txbUnitPrice.Size = new System.Drawing.Size(112, 24);
            this.txbUnitPrice.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(0, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(309, 38);
            this.label12.TabIndex = 45;
            this.label12.Text = "DANH MỤC SÁCH";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tpProducer
            // 
            this.tpProducer.Controls.Add(this.button9);
            this.tpProducer.Controls.Add(this.button10);
            this.tpProducer.Controls.Add(this.btnDeletePublisher);
            this.tpProducer.Controls.Add(this.btnAddPublisher);
            this.tpProducer.Controls.Add(this.groupBox6);
            this.tpProducer.Controls.Add(this.groupBox7);
            this.tpProducer.Location = new System.Drawing.Point(4, 25);
            this.tpProducer.Name = "tpProducer";
            this.tpProducer.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducer.Size = new System.Drawing.Size(598, 350);
            this.tpProducer.TabIndex = 2;
            this.tpProducer.Text = "Nhà sản xuất";
            this.tpProducer.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.Green;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(380, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 35);
            this.button9.TabIndex = 76;
            this.button9.Text = "Lưu";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(490, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 35);
            this.button10.TabIndex = 75;
            this.button10.Text = "Sửa";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeletePublisher.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnDeletePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDeletePublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletePublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletePublisher.Location = new System.Drawing.Point(490, 54);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(102, 35);
            this.btnDeletePublisher.TabIndex = 74;
            this.btnDeletePublisher.Text = "Xóa";
            this.btnDeletePublisher.UseVisualStyleBackColor = false;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddPublisher.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAddPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPublisher.Location = new System.Drawing.Point(380, 6);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(102, 35);
            this.btnAddPublisher.TabIndex = 73;
            this.btnAddPublisher.Text = "Thêm";
            this.btnAddPublisher.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Lavender;
            this.groupBox6.Controls.Add(this.dgvPulisher);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(592, 245);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách";
            // 
            // dgvPulisher
            // 
            this.dgvPulisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPulisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPulisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PUBLISHER_ID,
            this.PUBLISHER_NAME});
            this.dgvPulisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPulisher.Location = new System.Drawing.Point(3, 18);
            this.dgvPulisher.Name = "dgvPulisher";
            this.dgvPulisher.RowTemplate.Height = 24;
            this.dgvPulisher.Size = new System.Drawing.Size(586, 224);
            this.dgvPulisher.TabIndex = 0;
            this.dgvPulisher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPulisher_CellContentClick);
            // 
            // PUBLISHER_ID
            // 
            this.PUBLISHER_ID.DataPropertyName = "PUBLISHER_ID";
            this.PUBLISHER_ID.HeaderText = "Mã NSX";
            this.PUBLISHER_ID.Name = "PUBLISHER_ID";
            // 
            // PUBLISHER_NAME
            // 
            this.PUBLISHER_NAME.DataPropertyName = "PUBLISHER_NAME";
            this.PUBLISHER_NAME.HeaderText = "Tên NSX";
            this.PUBLISHER_NAME.Name = "PUBLISHER_NAME";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Lavender;
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.txbPublisherID);
            this.groupBox7.Controls.Add(this.txbPublisherName);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(1, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 93);
            this.groupBox7.TabIndex = 71;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin nhà sản xuất";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(11, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 18);
            this.label18.TabIndex = 9;
            this.label18.Text = "Mã NSX";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(11, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 18);
            this.label19.TabIndex = 10;
            this.label19.Text = "Tên NSX";
            // 
            // txbPublisherID
            // 
            this.txbPublisherID.Location = new System.Drawing.Point(92, 29);
            this.txbPublisherID.Name = "txbPublisherID";
            this.txbPublisherID.Size = new System.Drawing.Size(162, 24);
            this.txbPublisherID.TabIndex = 7;
            // 
            // txbPublisherName
            // 
            this.txbPublisherName.Location = new System.Drawing.Point(92, 57);
            this.txbPublisherName.Name = "txbPublisherName";
            this.txbPublisherName.Size = new System.Drawing.Size(162, 24);
            this.txbPublisherName.TabIndex = 8;
            // 
            // tpAuthor
            // 
            this.tpAuthor.BackColor = System.Drawing.Color.LightCyan;
            this.tpAuthor.Controls.Add(this.button14);
            this.tpAuthor.Controls.Add(this.button2);
            this.tpAuthor.Controls.Add(this.btnDeleteAuthor);
            this.tpAuthor.Controls.Add(this.btnAddAuthor);
            this.tpAuthor.Controls.Add(this.groupBox4);
            this.tpAuthor.Controls.Add(this.groupBox5);
            this.tpAuthor.Location = new System.Drawing.Point(4, 25);
            this.tpAuthor.Name = "tpAuthor";
            this.tpAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuthor.Size = new System.Drawing.Size(598, 350);
            this.tpAuthor.TabIndex = 1;
            this.tpAuthor.Text = "Tác giả";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.Color.Green;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button14.Location = new System.Drawing.Point(380, 54);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(102, 35);
            this.button14.TabIndex = 77;
            this.button14.Text = "Lưu";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(490, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 75;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteAuthor.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(490, 54);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(102, 35);
            this.btnDeleteAuthor.TabIndex = 74;
            this.btnDeleteAuthor.Text = "Xóa";
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddAuthor.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAddAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddAuthor.Location = new System.Drawing.Point(380, 6);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(102, 35);
            this.btnAddAuthor.TabIndex = 73;
            this.btnAddAuthor.Text = "Thêm";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.dgvAuthor);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(592, 245);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AUTHOR_ID,
            this.AUTHOR_NAME});
            this.dgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuthor.Location = new System.Drawing.Point(3, 18);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.RowTemplate.Height = 24;
            this.dgvAuthor.Size = new System.Drawing.Size(586, 224);
            this.dgvAuthor.TabIndex = 0;
            this.dgvAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAuthor_CellContentClick);
            // 
            // AUTHOR_ID
            // 
            this.AUTHOR_ID.DataPropertyName = "AUTHOR_ID";
            this.AUTHOR_ID.HeaderText = "Mã tác giả";
            this.AUTHOR_ID.Name = "AUTHOR_ID";
            // 
            // AUTHOR_NAME
            // 
            this.AUTHOR_NAME.DataPropertyName = "AUTHOR_NAME";
            this.AUTHOR_NAME.HeaderText = "Tên tác giả";
            this.AUTHOR_NAME.Name = "AUTHOR_NAME";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Lavender;
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txbAuthorID);
            this.groupBox5.Controls.Add(this.txbAuthorName);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 93);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin tác giả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(11, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Mã tác giả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(11, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tên tác giả";
            // 
            // txbAuthorID
            // 
            this.txbAuthorID.Location = new System.Drawing.Point(110, 29);
            this.txbAuthorID.Name = "txbAuthorID";
            this.txbAuthorID.Size = new System.Drawing.Size(162, 24);
            this.txbAuthorID.TabIndex = 7;
            // 
            // txbAuthorName
            // 
            this.txbAuthorName.Location = new System.Drawing.Point(110, 57);
            this.txbAuthorName.Name = "txbAuthorName";
            this.txbAuthorName.Size = new System.Drawing.Size(162, 24);
            this.txbAuthorName.TabIndex = 8;
            // 
            // tpCategory
            // 
            this.tpCategory.BackColor = System.Drawing.Color.LightBlue;
            this.tpCategory.Controls.Add(this.button3);
            this.tpCategory.Controls.Add(this.btnDeleteType);
            this.tpCategory.Controls.Add(this.btnAddType);
            this.tpCategory.Controls.Add(this.button7);
            this.tpCategory.Controls.Add(this.groupBox1);
            this.tpCategory.Controls.Add(this.groupBox3);
            this.tpCategory.Location = new System.Drawing.Point(4, 25);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(598, 350);
            this.tpCategory.TabIndex = 0;
            this.tpCategory.Text = "Thể loại";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(490, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 69;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteType.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteType.Location = new System.Drawing.Point(490, 54);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(102, 35);
            this.btnDeleteType.TabIndex = 68;
            this.btnDeleteType.Text = "Xóa";
            this.btnDeleteType.UseVisualStyleBackColor = false;
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddType.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAddType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddType.Location = new System.Drawing.Point(380, 6);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(102, 35);
            this.btnAddType.TabIndex = 67;
            this.btnAddType.Text = "Thêm";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Green;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(380, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 35);
            this.button7.TabIndex = 70;
            this.button7.Text = "Lưu";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgvTypeBook);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 245);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvTypeBook
            // 
            this.dgvTypeBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TYPE_BOOK_ID,
            this.TYPE_BOOK_NAME});
            this.dgvTypeBook.Location = new System.Drawing.Point(3, 18);
            this.dgvTypeBook.Name = "dgvTypeBook";
            this.dgvTypeBook.RowTemplate.Height = 24;
            this.dgvTypeBook.Size = new System.Drawing.Size(586, 224);
            this.dgvTypeBook.TabIndex = 0;
            this.dgvTypeBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeBook_CellContentClick);
            // 
            // TYPE_BOOK_ID
            // 
            this.TYPE_BOOK_ID.DataPropertyName = "TYPE_BOOK_ID";
            this.TYPE_BOOK_ID.HeaderText = "Mã loại sách";
            this.TYPE_BOOK_ID.Name = "TYPE_BOOK_ID";
            // 
            // TYPE_BOOK_NAME
            // 
            this.TYPE_BOOK_NAME.DataPropertyName = "TYPE_BOOK_NAME";
            this.TYPE_BOOK_NAME.HeaderText = "Tên loại sách";
            this.TYPE_BOOK_NAME.Name = "TYPE_BOOK_NAME";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txbCategoryID);
            this.groupBox3.Controls.Add(this.txbCategoryName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 93);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thể loại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(11, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Mã thể loại";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(11, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tên thể loại";
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(110, 29);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.Size = new System.Drawing.Size(162, 24);
            this.txbCategoryID.TabIndex = 7;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(110, 57);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(162, 24);
            this.txbCategoryName.TabIndex = 8;
            // 
            // tctBook
            // 
            this.tctBook.Controls.Add(this.tpCategory);
            this.tctBook.Controls.Add(this.tpAuthor);
            this.tctBook.Controls.Add(this.tpProducer);
            this.tctBook.Location = new System.Drawing.Point(587, 17);
            this.tctBook.Name = "tctBook";
            this.tctBook.SelectedIndex = 0;
            this.tctBook.Size = new System.Drawing.Size(606, 379);
            this.tctBook.TabIndex = 10;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(1135, 7);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(58, 21);
            this.cbShow.TabIndex = 71;
            this.cbShow.Text = "Xem";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(7, 371);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(162, 22);
            this.txbSearch.TabIndex = 72;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 870);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.tctBook);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.grInforBook);
            this.Controls.Add(this.btnAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grInforBook.ResumeLayout(false);
            this.grInforBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudQuantity)).EndInit();
            this.tpProducer.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPulisher)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tpAuthor.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tpCategory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeBook)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tctBook.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DateTimePicker dtpPublishingYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPublisherID_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grInforBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.TextBox txbUnitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataReceipt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmudQuantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tpProducer;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDeletePublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvPulisher;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txbPublisherID;
        private System.Windows.Forms.TextBox txbPublisherName;
        private System.Windows.Forms.TabPage tpAuthor;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbAuthorID;
        private System.Windows.Forms.TextBox txbAuthorName;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTypeBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.TabControl tctBook;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbAuthorID_2;
        private System.Windows.Forms.TextBox txbTypeBookID_2;
        private LIBRARYMANGAEDataSet lIBRARYMANGAEDataSet;
        private LIBRARYMANGAEDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private LIBRARYMANGAEDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEBOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHINGYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATERECEIPTDataGridViewTextBoxColumn;
        private LIBRARYMANGAEDataSet lIBRARYMANGAEDataSet1;
        private LIBRARYMANGAEDataSetTableAdapters.TYPE_BOOKTableAdapter tYPE_BOOKTableAdapter;
        private LIBRARYMANGAEDataSetTableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private LIBRARYMANGAEDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHER_NAME;
        private LIBRARYMANGAEDataSet lIBRARYMANGAEDataSet2;
        private LIBRARYMANGAEDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter1;
        private LIBRARYMANGAEDataSet lIBRARYMANGAEDataSet3;
        private LIBRARYMANGAEDataSetTableAdapters.TYPE_BOOKTableAdapter tYPE_BOOKTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_BOOK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHING_YEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_RECEIPT;
        private System.Windows.Forms.TextBox txbSearch;

    }
}