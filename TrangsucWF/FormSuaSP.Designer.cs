namespace TrangsucWF
{
    partial class FormSua
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
            this.lb_titleEdit = new System.Windows.Forms.Label();
            this.lb_masp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_maspham = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            this.txt_chatlieu = new System.Windows.Forms.TextBox();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.lb_loaisp = new System.Windows.Forms.Label();
            this.lb_maloai = new System.Windows.Forms.Label();
            this.lb_hinhanh = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_chatlieu = new System.Windows.Forms.Label();
            this.lb_Tensp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titleEdit
            // 
            this.lb_titleEdit.AutoSize = true;
            this.lb_titleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_titleEdit.Location = new System.Drawing.Point(141, 12);
            this.lb_titleEdit.Name = "lb_titleEdit";
            this.lb_titleEdit.Size = new System.Drawing.Size(300, 25);
            this.lb_titleEdit.TabIndex = 2;
            this.lb_titleEdit.Text = "SỬA THÔNG TIN SẢN PHẨM";
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masp.Location = new System.Drawing.Point(13, 69);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(93, 17);
            this.lb_masp.TabIndex = 3;
            this.lb_masp.Text = "Mã sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_maspham);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_browse);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_gia);
            this.panel1.Controls.Add(this.txt_hinhanh);
            this.panel1.Controls.Add(this.txt_chatlieu);
            this.panel1.Controls.Add(this.txt_tensanpham);
            this.panel1.Controls.Add(this.lb_loaisp);
            this.panel1.Controls.Add(this.lb_maloai);
            this.panel1.Controls.Add(this.lb_hinhanh);
            this.panel1.Controls.Add(this.lb_gia);
            this.panel1.Controls.Add(this.lb_chatlieu);
            this.panel1.Controls.Add(this.lb_Tensp);
            this.panel1.Controls.Add(this.lb_masp);
            this.panel1.Controls.Add(this.lb_titleEdit);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 316);
            this.panel1.TabIndex = 4;
            // 
            // lb_maspham
            // 
            this.lb_maspham.AutoSize = true;
            this.lb_maspham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maspham.Location = new System.Drawing.Point(143, 69);
            this.lb_maspham.Name = "lb_maspham";
            this.lb_maspham.Size = new System.Drawing.Size(66, 17);
            this.lb_maspham.TabIndex = 25;
            this.lb_maspham.Text = "hinh thuc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picture1);
            this.groupBox1.Location = new System.Drawing.Point(462, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 176);
            this.groupBox1.TabIndex = 24;
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
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_browse.Location = new System.Drawing.Point(376, 222);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(64, 24);
            this.btn_browse.TabIndex = 23;
            this.btn_browse.Text = "Chọn hình";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_edit.Location = new System.Drawing.Point(184, 263);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(78, 30);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Lưu";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_exit.Location = new System.Drawing.Point(293, 263);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 30);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "VNĐ";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(140, 179);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(231, 20);
            this.txt_gia.TabIndex = 17;
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(140, 222);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(231, 20);
            this.txt_hinhanh.TabIndex = 16;
            // 
            // txt_chatlieu
            // 
            this.txt_chatlieu.Location = new System.Drawing.Point(140, 151);
            this.txt_chatlieu.Name = "txt_chatlieu";
            this.txt_chatlieu.Size = new System.Drawing.Size(301, 20);
            this.txt_chatlieu.TabIndex = 14;
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Location = new System.Drawing.Point(140, 123);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(301, 20);
            this.txt_tensanpham.TabIndex = 13;
            // 
            // lb_loaisp
            // 
            this.lb_loaisp.AutoSize = true;
            this.lb_loaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaisp.Location = new System.Drawing.Point(143, 97);
            this.lb_loaisp.Name = "lb_loaisp";
            this.lb_loaisp.Size = new System.Drawing.Size(66, 17);
            this.lb_loaisp.TabIndex = 10;
            this.lb_loaisp.Text = "hinh thuc";
            // 
            // lb_maloai
            // 
            this.lb_maloai.AutoSize = true;
            this.lb_maloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maloai.Location = new System.Drawing.Point(13, 97);
            this.lb_maloai.Name = "lb_maloai";
            this.lb_maloai.Size = new System.Drawing.Size(101, 17);
            this.lb_maloai.TabIndex = 10;
            this.lb_maloai.Text = "Loại sản phẩm";
            // 
            // lb_hinhanh
            // 
            this.lb_hinhanh.AutoSize = true;
            this.lb_hinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hinhanh.Location = new System.Drawing.Point(13, 222);
            this.lb_hinhanh.Name = "lb_hinhanh";
            this.lb_hinhanh.Size = new System.Drawing.Size(107, 17);
            this.lb_hinhanh.TabIndex = 9;
            this.lb_hinhanh.Text = "Hình ảnh (URL)";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.Location = new System.Drawing.Point(13, 182);
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
            this.lb_Tensp.Location = new System.Drawing.Point(13, 126);
            this.lb_Tensp.Name = "lb_Tensp";
            this.lb_Tensp.Size = new System.Drawing.Size(99, 17);
            this.lb_Tensp.TabIndex = 4;
            this.lb_Tensp.Text = "Tên sản phẩm";
            // 
            // FormSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(706, 340);
            this.Controls.Add(this.panel1);
            this.Name = "FormSua";
            this.Text = "FormSua";
            this.Load += new System.EventHandler(this.FormSua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_titleEdit;
        private System.Windows.Forms.Label lb_masp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_chatlieu;
        private System.Windows.Forms.Label lb_Tensp;
        private System.Windows.Forms.Label lb_hinhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_hinhanh;
        private System.Windows.Forms.TextBox txt_chatlieu;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.Label lb_maloai;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_maspham;
        private System.Windows.Forms.Label lb_loaisp;
    }
}