namespace TrangsucWF
{
    partial class FormThemSP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_maloai = new System.Windows.Forms.ComboBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            this.txt_chatlieu = new System.Windows.Forms.TextBox();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.txt_masanpham = new System.Windows.Forms.TextBox();
            this.lb_maloai = new System.Windows.Forms.Label();
            this.lb_hinhanh = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_chatlieu = new System.Windows.Forms.Label();
            this.lb_Tensp = new System.Windows.Forms.Label();
            this.lb_masp = new System.Windows.Forms.Label();
            this.lb_titleEdit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_chon);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_maloai);
            this.panel1.Controls.Add(this.txt_gia);
            this.panel1.Controls.Add(this.txt_hinhanh);
            this.panel1.Controls.Add(this.txt_chatlieu);
            this.panel1.Controls.Add(this.txt_tensanpham);
            this.panel1.Controls.Add(this.txt_masanpham);
            this.panel1.Controls.Add(this.lb_maloai);
            this.panel1.Controls.Add(this.lb_hinhanh);
            this.panel1.Controls.Add(this.lb_gia);
            this.panel1.Controls.Add(this.lb_chatlieu);
            this.panel1.Controls.Add(this.lb_Tensp);
            this.panel1.Controls.Add(this.lb_masp);
            this.panel1.Controls.Add(this.lb_titleEdit);
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 332);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picture1);
            this.groupBox1.Location = new System.Drawing.Point(474, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 176);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình sản phẩm";
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(11, 17);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(149, 149);
            this.picture1.TabIndex = 22;
            this.picture1.TabStop = false;
            // 
            // btn_chon
            // 
            this.btn_chon.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_chon.Location = new System.Drawing.Point(377, 216);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(64, 24);
            this.btn_chon.TabIndex = 24;
            this.btn_chon.Text = "Chọn hình";
            this.btn_chon.UseVisualStyleBackColor = false;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHuy.Location = new System.Drawing.Point(311, 280);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 30);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThemSP.Location = new System.Drawing.Point(185, 280);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(78, 30);
            this.btnThemSP.TabIndex = 21;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "VNĐ";
            // 
            // cb_maloai
            // 
            this.cb_maloai.FormattingEnabled = true;
            this.cb_maloai.Location = new System.Drawing.Point(140, 89);
            this.cb_maloai.Name = "cb_maloai";
            this.cb_maloai.Size = new System.Drawing.Size(301, 21);
            this.cb_maloai.TabIndex = 19;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(140, 181);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(216, 20);
            this.txt_gia.TabIndex = 17;
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(140, 220);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(231, 20);
            this.txt_hinhanh.TabIndex = 16;
            // 
            // txt_chatlieu
            // 
            this.txt_chatlieu.Location = new System.Drawing.Point(140, 151);
            this.txt_chatlieu.Name = "txt_chatlieu";
            this.txt_chatlieu.Size = new System.Drawing.Size(300, 20);
            this.txt_chatlieu.TabIndex = 14;
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Location = new System.Drawing.Point(140, 121);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(300, 20);
            this.txt_tensanpham.TabIndex = 13;
            // 
            // txt_masanpham
            // 
            this.txt_masanpham.Location = new System.Drawing.Point(140, 59);
            this.txt_masanpham.Name = "txt_masanpham";
            this.txt_masanpham.Size = new System.Drawing.Size(300, 20);
            this.txt_masanpham.TabIndex = 11;
            // 
            // lb_maloai
            // 
            this.lb_maloai.AutoSize = true;
            this.lb_maloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maloai.Location = new System.Drawing.Point(13, 93);
            this.lb_maloai.Name = "lb_maloai";
            this.lb_maloai.Size = new System.Drawing.Size(101, 17);
            this.lb_maloai.TabIndex = 10;
            this.lb_maloai.Text = "Loại sản phẩm";
            // 
            // lb_hinhanh
            // 
            this.lb_hinhanh.AutoSize = true;
            this.lb_hinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hinhanh.Location = new System.Drawing.Point(13, 220);
            this.lb_hinhanh.Name = "lb_hinhanh";
            this.lb_hinhanh.Size = new System.Drawing.Size(107, 17);
            this.lb_hinhanh.TabIndex = 9;
            this.lb_hinhanh.Text = "Hình ảnh (URL)";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.Location = new System.Drawing.Point(13, 184);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(30, 17);
            this.lb_gia.TabIndex = 6;
            this.lb_gia.Text = "Giá";
            // 
            // lb_chatlieu
            // 
            this.lb_chatlieu.AutoSize = true;
            this.lb_chatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chatlieu.Location = new System.Drawing.Point(13, 154);
            this.lb_chatlieu.Name = "lb_chatlieu";
            this.lb_chatlieu.Size = new System.Drawing.Size(63, 17);
            this.lb_chatlieu.TabIndex = 5;
            this.lb_chatlieu.Text = "Chất liệu";
            // 
            // lb_Tensp
            // 
            this.lb_Tensp.AutoSize = true;
            this.lb_Tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tensp.Location = new System.Drawing.Point(13, 124);
            this.lb_Tensp.Name = "lb_Tensp";
            this.lb_Tensp.Size = new System.Drawing.Size(99, 17);
            this.lb_Tensp.TabIndex = 4;
            this.lb_Tensp.Text = "Tên sản phẩm";
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masp.Location = new System.Drawing.Point(13, 62);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(93, 17);
            this.lb_masp.TabIndex = 3;
            this.lb_masp.Text = "Mã sản phẩm";
            // 
            // lb_titleEdit
            // 
            this.lb_titleEdit.AutoSize = true;
            this.lb_titleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_titleEdit.Location = new System.Drawing.Point(170, 5);
            this.lb_titleEdit.Name = "lb_titleEdit";
            this.lb_titleEdit.Size = new System.Drawing.Size(239, 25);
            this.lb_titleEdit.TabIndex = 2;
            this.lb_titleEdit.Text = "THÊM SẢN PHẨM MỚI";
            // 
            // FormThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(701, 365);
            this.Controls.Add(this.panel1);
            this.Name = "FormThemSP";
            this.Text = "FormThemSP";
            this.Load += new System.EventHandler(this.FormThemSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_maloai;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_hinhanh;
        private System.Windows.Forms.TextBox txt_chatlieu;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.TextBox txt_masanpham;
        private System.Windows.Forms.Label lb_maloai;
        private System.Windows.Forms.Label lb_hinhanh;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_chatlieu;
        private System.Windows.Forms.Label lb_Tensp;
        private System.Windows.Forms.Label lb_masp;
        private System.Windows.Forms.Label lb_titleEdit;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picture1;
    }
}