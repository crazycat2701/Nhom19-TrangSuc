namespace TrangsucWF
{
    partial class FormCTHD
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gv_ctsp = new System.Windows.Forms.DataGridView();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_ngaygiao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_diadiemgiaohang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_ngaymuahang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tendangnhap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.lb_mahoadon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctsp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHuy.Location = new System.Drawing.Point(497, 459);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 28);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(347, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng tiền:";
            // 
            // gv_ctsp
            // 
            this.gv_ctsp.BackgroundColor = System.Drawing.Color.Ivory;
            this.gv_ctsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ctsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masanpham,
            this.tensanpham,
            this.dongia,
            this.Soluong,
            this.Thanhtien});
            this.gv_ctsp.Location = new System.Drawing.Point(16, 21);
            this.gv_ctsp.Name = "gv_ctsp";
            this.gv_ctsp.Size = new System.Drawing.Size(546, 142);
            this.gv_ctsp.TabIndex = 0;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(133, 41);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(56, 16);
            this.lb_sdt.TabIndex = 10;
            this.lb_sdt.Text = "hinhthuc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số điện thoại:";
            // 
            // lb_ngaygiao
            // 
            this.lb_ngaygiao.AutoSize = true;
            this.lb_ngaygiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaygiao.Location = new System.Drawing.Point(133, 112);
            this.lb_ngaygiao.Name = "lb_ngaygiao";
            this.lb_ngaygiao.Size = new System.Drawing.Size(56, 16);
            this.lb_ngaygiao.TabIndex = 8;
            this.lb_ngaygiao.Text = "hinhthuc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thời gian giao hàng:";
            // 
            // lb_diadiemgiaohang
            // 
            this.lb_diadiemgiaohang.AutoSize = true;
            this.lb_diadiemgiaohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diadiemgiaohang.Location = new System.Drawing.Point(133, 88);
            this.lb_diadiemgiaohang.Name = "lb_diadiemgiaohang";
            this.lb_diadiemgiaohang.Size = new System.Drawing.Size(56, 16);
            this.lb_diadiemgiaohang.TabIndex = 6;
            this.lb_diadiemgiaohang.Text = "hinhthuc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa điểm giao hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(512, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "VNĐ";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.ForeColor = System.Drawing.Color.Red;
            this.lb_tongtien.Location = new System.Drawing.Point(430, 176);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(64, 16);
            this.lb_tongtien.TabIndex = 10;
            this.lb_tongtien.Text = "hinhthuc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lb_tongtien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.gv_ctsp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 211);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // lb_ngaymuahang
            // 
            this.lb_ngaymuahang.AutoSize = true;
            this.lb_ngaymuahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaymuahang.Location = new System.Drawing.Point(133, 63);
            this.lb_ngaymuahang.Name = "lb_ngaymuahang";
            this.lb_ngaymuahang.Size = new System.Drawing.Size(56, 16);
            this.lb_ngaymuahang.TabIndex = 4;
            this.lb_ngaymuahang.Text = "hinhthuc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày mua hàng:";
            // 
            // lb_tendangnhap
            // 
            this.lb_tendangnhap.AutoSize = true;
            this.lb_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendangnhap.Location = new System.Drawing.Point(133, 17);
            this.lb_tendangnhap.Name = "lb_tendangnhap";
            this.lb_tendangnhap.Size = new System.Drawing.Size(56, 16);
            this.lb_tendangnhap.TabIndex = 2;
            this.lb_tendangnhap.Text = "hinhthuc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lb_trangthai.Location = new System.Drawing.Point(82, 29);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(48, 13);
            this.lb_trangthai.TabIndex = 7;
            this.lb_trangthai.Text = "hinhthuc";
            // 
            // lb_mahoadon
            // 
            this.lb_mahoadon.AutoSize = true;
            this.lb_mahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lb_mahoadon.Location = new System.Drawing.Point(82, 10);
            this.lb_mahoadon.Name = "lb_mahoadon";
            this.lb_mahoadon.Size = new System.Drawing.Size(48, 13);
            this.lb_mahoadon.TabIndex = 5;
            this.lb_mahoadon.Text = "hinhthuc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_trangthai);
            this.panel1.Controls.Add(this.lb_mahoadon);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(337, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 53);
            this.panel1.TabIndex = 27;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_title.Location = new System.Drawing.Point(143, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(211, 24);
            this.lb_title.TabIndex = 26;
            this.lb_title.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_ngaygiao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_diadiemgiaohang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_ngaymuahang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_tendangnhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 141);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // Masanpham
            // 
            this.Masanpham.DataPropertyName = "Masanpham";
            this.Masanpham.HeaderText = "Mã SP";
            this.Masanpham.Name = "Masanpham";
            this.Masanpham.Width = 80;
            // 
            // tensanpham
            // 
            this.tensanpham.DataPropertyName = "Tensanpham";
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.Width = 150;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "Giasanpham";
            this.dongia.HeaderText = "Đơn giá (VNĐ)";
            this.dongia.Name = "dongia";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 60;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền (VNĐ)";
            this.Thanhtien.Name = "Thanhtien";
            // 
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 497);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCTHD";
            this.Text = "FormCTHD";
            this.Load += new System.EventHandler(this.FormCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctsp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gv_ctsp;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_ngaygiao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_diadiemgiaohang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_ngaymuahang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_tendangnhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.Label lb_mahoadon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
    }
}