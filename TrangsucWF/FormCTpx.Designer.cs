namespace TrangsucWF
{
    partial class FormCTpx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTpx));
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gv_phieuxuat = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_sanpham = new System.Windows.Forms.DataGridView();
            this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_maphieuxuat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masanpham = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_tonkho = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_phieuxuat)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_sanpham)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Pink;
            this.btn_save.Location = new System.Drawing.Point(544, 443);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 31);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_title.Location = new System.Drawing.Point(248, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(238, 25);
            this.lb_title.TabIndex = 30;
            this.lb_title.Text = "CHI TIẾT PHIẾU XUẤT";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.gv_phieuxuat);
            this.panel3.Location = new System.Drawing.Point(422, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 294);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(143, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "PHIẾU XUẤT";
            // 
            // gv_phieuxuat
            // 
            this.gv_phieuxuat.AllowUserToAddRows = false;
            this.gv_phieuxuat.BackgroundColor = System.Drawing.Color.Ivory;
            this.gv_phieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_phieuxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.soluong,
            this.Thanhtien,
            this.delete});
            this.gv_phieuxuat.Location = new System.Drawing.Point(3, 66);
            this.gv_phieuxuat.Name = "gv_phieuxuat";
            this.gv_phieuxuat.ReadOnly = true;
            this.gv_phieuxuat.Size = new System.Drawing.Size(358, 219);
            this.gv_phieuxuat.TabIndex = 0;
            this.gv_phieuxuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_phieuxuat_CellContentClick);
            this.gv_phieuxuat.SelectionChanged += new System.EventHandler(this.gv_phieuxuat_SelectionChanged);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "Masanpham";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 70;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 80;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền (VNĐ)";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Xóa";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.gv_sanpham);
            this.panel2.Location = new System.Drawing.Point(7, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 294);
            this.panel2.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_find);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 50);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(135, 18);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(193, 20);
            this.txt_find.TabIndex = 11;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã / Tên sản phẩm";
            // 
            // gv_sanpham
            // 
            this.gv_sanpham.BackgroundColor = System.Drawing.Color.Ivory;
            this.gv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masanpham,
            this.tensanpham,
            this.giasanpham});
            this.gv_sanpham.Location = new System.Drawing.Point(5, 66);
            this.gv_sanpham.Name = "gv_sanpham";
            this.gv_sanpham.ReadOnly = true;
            this.gv_sanpham.Size = new System.Drawing.Size(365, 217);
            this.gv_sanpham.TabIndex = 12;
            this.gv_sanpham.SelectionChanged += new System.EventHandler(this.gv_sanpham_SelectionChanged);
            // 
            // masanpham
            // 
            this.masanpham.DataPropertyName = "Masanpham";
            this.masanpham.HeaderText = "Mã sản phẩm";
            this.masanpham.Name = "masanpham";
            this.masanpham.ReadOnly = true;
            this.masanpham.Width = 60;
            // 
            // tensanpham
            // 
            this.tensanpham.DataPropertyName = "Tensanpham";
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.ReadOnly = true;
            this.tensanpham.Width = 160;
            // 
            // giasanpham
            // 
            this.giasanpham.DataPropertyName = "Giasanpham";
            this.giasanpham.HeaderText = "Đơn giá (VNĐ)";
            this.giasanpham.Name = "giasanpham";
            this.giasanpham.ReadOnly = true;
            this.giasanpham.Width = 75;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(22, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 385);
            this.panel1.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tonkho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.lb_maphieuxuat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_masanpham);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Xuất";
            // 
            // lb_maphieuxuat
            // 
            this.lb_maphieuxuat.AutoSize = true;
            this.lb_maphieuxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maphieuxuat.Location = new System.Drawing.Point(101, 29);
            this.lb_maphieuxuat.Name = "lb_maphieuxuat";
            this.lb_maphieuxuat.Size = new System.Drawing.Size(64, 16);
            this.lb_maphieuxuat.TabIndex = 24;
            this.lb_maphieuxuat.Text = "hinhthuc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã phiếu nhập";
            // 
            // txt_masanpham
            // 
            this.txt_masanpham.Location = new System.Drawing.Point(287, 26);
            this.txt_masanpham.Name = "txt_masanpham";
            this.txt_masanpham.Size = new System.Drawing.Size(106, 22);
            this.txt_masanpham.TabIndex = 22;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_add.Location = new System.Drawing.Point(681, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 27);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Thêm / Sửa";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số lượng";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_close.Location = new System.Drawing.Point(662, 443);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 31);
            this.btn_close.TabIndex = 33;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(482, 26);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(55, 22);
            this.txt_soluong.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tồn kho";
            // 
            // lb_tonkho
            // 
            this.lb_tonkho.AutoSize = true;
            this.lb_tonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tonkho.Location = new System.Drawing.Point(611, 29);
            this.lb_tonkho.Name = "lb_tonkho";
            this.lb_tonkho.Size = new System.Drawing.Size(64, 16);
            this.lb_tonkho.TabIndex = 27;
            this.lb_tonkho.Text = "hinhthuc";
            // 
            // FormCTpx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Name = "FormCTpx";
            this.Text = "Form Chi Tiết Phiếu Xuất";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_phieuxuat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_sanpham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gv_phieuxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv_sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasanpham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_maphieuxuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_masanpham;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_tonkho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soluong;
    }
}