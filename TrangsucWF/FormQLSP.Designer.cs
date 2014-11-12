namespace TrangsucWF
{
    partial class FormQLSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_product = new System.Windows.Forms.DataGridView();
            this.gb_find = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanphammoi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_product)).BeginInit();
            this.gb_find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gv_product);
            this.panel1.Controls.Add(this.gb_find);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 543);
            this.panel1.TabIndex = 0;
            // 
            // gv_product
            // 
            this.gv_product.BackgroundColor = System.Drawing.Color.Ivory;
            this.gv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masanpham,
            this.tensanpham,
            this.chatlieu,
            this.giasanpham,
            this.hinhanh,
            this.tenloai,
            this.sanphammoi,
            this.Edit});
            this.gv_product.GridColor = System.Drawing.SystemColors.HotTrack;
            this.gv_product.Location = new System.Drawing.Point(18, 111);
            this.gv_product.Name = "gv_product";
            this.gv_product.ReadOnly = true;
            this.gv_product.Size = new System.Drawing.Size(769, 409);
            this.gv_product.TabIndex = 6;
            this.gv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_product_CellContentClick);
            // 
            // gb_find
            // 
            this.gb_find.Controls.Add(this.pictureBox1);
            this.gb_find.Controls.Add(this.btn_find);
            this.gb_find.Controls.Add(this.txt_find);
            this.gb_find.Location = new System.Drawing.Point(138, 41);
            this.gb_find.Name = "gb_find";
            this.gb_find.Size = new System.Drawing.Size(607, 53);
            this.gb_find.TabIndex = 5;
            this.gb_find.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_find.Location = new System.Drawing.Point(510, 17);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(80, 24);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(60, 20);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(435, 20);
            this.txt_find.TabIndex = 3;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_title.Location = new System.Drawing.Point(329, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(225, 25);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_add.Location = new System.Drawing.Point(530, 570);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_close.Location = new System.Drawing.Point(703, 570);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 28);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // masanpham
            // 
            this.masanpham.DataPropertyName = "Masanpham";
            this.masanpham.HeaderText = "Mã SP";
            this.masanpham.MinimumWidth = 20;
            this.masanpham.Name = "masanpham";
            this.masanpham.ReadOnly = true;
            this.masanpham.Width = 70;
            // 
            // tensanpham
            // 
            this.tensanpham.DataPropertyName = "Tensanpham";
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.MinimumWidth = 20;
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.ReadOnly = true;
            this.tensanpham.Width = 150;
            // 
            // chatlieu
            // 
            this.chatlieu.DataPropertyName = "Chatlieu";
            this.chatlieu.HeaderText = "Chất liệu";
            this.chatlieu.MinimumWidth = 20;
            this.chatlieu.Name = "chatlieu";
            this.chatlieu.ReadOnly = true;
            // 
            // giasanpham
            // 
            this.giasanpham.DataPropertyName = "Giasanpham";
            this.giasanpham.HeaderText = "Giá (VNĐ)";
            this.giasanpham.MinimumWidth = 20;
            this.giasanpham.Name = "giasanpham";
            this.giasanpham.ReadOnly = true;
            this.giasanpham.Width = 80;
            // 
            // hinhanh
            // 
            this.hinhanh.HeaderText = "Hình ảnh";
            this.hinhanh.MinimumWidth = 20;
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.ReadOnly = true;
            this.hinhanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hinhanh.Width = 60;
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "Tenloai";
            this.tenloai.HeaderText = "Loại SP";
            this.tenloai.MinimumWidth = 20;
            this.tenloai.Name = "tenloai";
            this.tenloai.ReadOnly = true;
            // 
            // sanphammoi
            // 
            this.sanphammoi.HeaderText = "Hiện/Ẩn";
            this.sanphammoi.MinimumWidth = 20;
            this.sanphammoi.Name = "sanphammoi";
            this.sanphammoi.ReadOnly = true;
            this.sanphammoi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sanphammoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sanphammoi.Width = 50;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Sửa";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 20;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 30;
            // 
            // FormQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(860, 619);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLSP";
            this.Text = "FormQLSP";
            this.Load += new System.EventHandler(this.FormQLSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_product)).EndInit();
            this.gb_find.ResumeLayout(false);
            this.gb_find.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gv_product;
        private System.Windows.Forms.GroupBox gb_find;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasanpham;
        private System.Windows.Forms.DataGridViewImageColumn hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sanphammoi;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}