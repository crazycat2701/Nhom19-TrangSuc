namespace TrangsucWF
{
    partial class FormQLPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLPhieuNhap));
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.gv_phieunhap = new System.Windows.Forms.DataGridView();
            this.Maphieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennguoilap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaylapphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.gb_find = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_trangthai1 = new System.Windows.Forms.ComboBox();
            this.dtpk_den = new System.Windows.Forms.DateTimePicker();
            this.dtpk_tu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpk_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.txt_nguoilap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_maphieunhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_phieunhap)).BeginInit();
            this.gb_find.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_close.Location = new System.Drawing.Point(678, 512);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(102, 28);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_title.Location = new System.Drawing.Point(286, 5);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(241, 25);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "QUẢN LÝ PHIẾU NHẬP";
            // 
            // gv_phieunhap
            // 
            this.gv_phieunhap.BackgroundColor = System.Drawing.Color.Ivory;
            this.gv_phieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_phieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieunhap,
            this.Tennguoilap,
            this.Ngaylapphieu,
            this.Tongtien,
            this.Trangthai,
            this.updatedetail});
            this.gv_phieunhap.Location = new System.Drawing.Point(17, 273);
            this.gv_phieunhap.Name = "gv_phieunhap";
            this.gv_phieunhap.ReadOnly = true;
            this.gv_phieunhap.Size = new System.Drawing.Size(739, 208);
            this.gv_phieunhap.TabIndex = 9;
            this.gv_phieunhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_phieunhap_CellContentClick);
            this.gv_phieunhap.SelectionChanged += new System.EventHandler(this.gv_phieunhap_SelectionChanged);
            // 
            // Maphieunhap
            // 
            this.Maphieunhap.DataPropertyName = "Maphieunhap";
            this.Maphieunhap.HeaderText = "Mã phiếu nhập";
            this.Maphieunhap.Name = "Maphieunhap";
            this.Maphieunhap.ReadOnly = true;
            // 
            // Tennguoilap
            // 
            this.Tennguoilap.DataPropertyName = "Tennguoilap";
            this.Tennguoilap.FillWeight = 130F;
            this.Tennguoilap.HeaderText = "Tên người lập";
            this.Tennguoilap.Name = "Tennguoilap";
            this.Tennguoilap.ReadOnly = true;
            this.Tennguoilap.Width = 130;
            // 
            // Ngaylapphieu
            // 
            this.Ngaylapphieu.DataPropertyName = "Ngaylapphieu";
            this.Ngaylapphieu.HeaderText = "Ngày lập phiếu";
            this.Ngaylapphieu.Name = "Ngaylapphieu";
            this.Ngaylapphieu.ReadOnly = true;
            this.Ngaylapphieu.Width = 120;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền (VNĐ)";
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.ReadOnly = true;
            this.Tongtien.Width = 120;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            this.Trangthai.Width = 120;
            // 
            // updatedetail
            // 
            this.updatedetail.HeaderText = "Xem/Thêm chi tiết";
            this.updatedetail.Image = ((System.Drawing.Image)(resources.GetObject("updatedetail.Image")));
            this.updatedetail.Name = "updatedetail";
            this.updatedetail.ReadOnly = true;
            this.updatedetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updatedetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.updatedetail.Width = 70;
            // 
            // gb_find
            // 
            this.gb_find.Controls.Add(this.label5);
            this.gb_find.Controls.Add(this.cbb_trangthai1);
            this.gb_find.Controls.Add(this.dtpk_den);
            this.gb_find.Controls.Add(this.dtpk_tu);
            this.gb_find.Controls.Add(this.label4);
            this.gb_find.Controls.Add(this.label3);
            this.gb_find.Controls.Add(this.btn_find);
            this.gb_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_find.Location = new System.Drawing.Point(17, 201);
            this.gb_find.Name = "gb_find";
            this.gb_find.Size = new System.Drawing.Size(739, 55);
            this.gb_find.TabIndex = 6;
            this.gb_find.TabStop = false;
            this.gb_find.Text = "TÌM KIẾM PHIẾU NHẬP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đến";
            // 
            // cbb_trangthai1
            // 
            this.cbb_trangthai1.FormattingEnabled = true;
            this.cbb_trangthai1.Location = new System.Drawing.Point(98, 20);
            this.cbb_trangthai1.Name = "cbb_trangthai1";
            this.cbb_trangthai1.Size = new System.Drawing.Size(121, 24);
            this.cbb_trangthai1.TabIndex = 11;
            // 
            // dtpk_den
            // 
            this.dtpk_den.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_den.Location = new System.Drawing.Point(526, 20);
            this.dtpk_den.Name = "dtpk_den";
            this.dtpk_den.Size = new System.Drawing.Size(127, 22);
            this.dtpk_den.TabIndex = 10;
            // 
            // dtpk_tu
            // 
            this.dtpk_tu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_tu.Location = new System.Drawing.Point(334, 21);
            this.dtpk_tu.Name = "dtpk_tu";
            this.dtpk_tu.Size = new System.Drawing.Size(127, 22);
            this.dtpk_tu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày lập phiếu";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_find.Location = new System.Drawing.Point(672, 19);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(49, 25);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_add.Location = new System.Drawing.Point(344, 22);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(168, 28);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gb_find);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.gv_phieunhap);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 494);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_maphieunhap);
            this.groupBox1.Controls.Add(this.bt_update);
            this.groupBox1.Controls.Add(this.cbb_trangthai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpk_ngaylap);
            this.groupBox1.Controls.Add(this.txt_nguoilap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LẬP PHIẾU NHẬP";
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.PowderBlue;
            this.bt_update.Location = new System.Drawing.Point(344, 66);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(168, 28);
            this.bt_update.TabIndex = 18;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Location = new System.Drawing.Point(139, 115);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(177, 24);
            this.cbb_trangthai.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trạng thái";
            // 
            // dtpk_ngaylap
            // 
            this.dtpk_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_ngaylap.Location = new System.Drawing.Point(139, 82);
            this.dtpk_ngaylap.Name = "dtpk_ngaylap";
            this.dtpk_ngaylap.Size = new System.Drawing.Size(177, 22);
            this.dtpk_ngaylap.TabIndex = 11;
            // 
            // txt_nguoilap
            // 
            this.txt_nguoilap.Location = new System.Drawing.Point(139, 52);
            this.txt_nguoilap.Name = "txt_nguoilap";
            this.txt_nguoilap.Size = new System.Drawing.Size(177, 22);
            this.txt_nguoilap.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày lập phiếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Người lập phiếu";
            // 
            // lb_maphieunhap
            // 
            this.lb_maphieunhap.AutoSize = true;
            this.lb_maphieunhap.Location = new System.Drawing.Point(138, 25);
            this.lb_maphieunhap.Name = "lb_maphieunhap";
            this.lb_maphieunhap.Size = new System.Drawing.Size(56, 16);
            this.lb_maphieunhap.TabIndex = 19;
            this.lb_maphieunhap.Text = "hinhthuc";
            // 
            // FormQLPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 552);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLPhieuNhap";
            this.Text = "FormQLPhieuNhap";
            this.Load += new System.EventHandler(this.FormQLPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_phieunhap)).EndInit();
            this.gb_find.ResumeLayout(false);
            this.gb_find.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridView gv_phieunhap;
        private System.Windows.Forms.GroupBox gb_find;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_trangthai1;
        private System.Windows.Forms.DateTimePicker dtpk_den;
        private System.Windows.Forms.DateTimePicker dtpk_tu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.ComboBox cbb_trangthai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpk_ngaylap;
        private System.Windows.Forms.TextBox txt_nguoilap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennguoilap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaylapphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewImageColumn updatedetail;
        private System.Windows.Forms.Label lb_maphieunhap;
    }
}