namespace QuanLy_N6_Agile
{
    partial class Form2
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
            btn_Thoat = new Button();
            btn_Timkiem = new Button();
            txt_MaSv = new TextBox();
            txtGDTC = new TextBox();
            txtTinHoc = new TextBox();
            txtTiengAnh = new TextBox();
            txtTen = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btn_Update = new Button();
            dgv_ThongTin = new DataGridView();
            btnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ThongTin).BeginInit();
            SuspendLayout();
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(740, 403);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 42;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Timkiem
            // 
            btn_Timkiem.Location = new Point(740, 144);
            btn_Timkiem.Name = "btn_Timkiem";
            btn_Timkiem.Size = new Size(94, 29);
            btn_Timkiem.TabIndex = 41;
            btn_Timkiem.Text = "Tìm Kiếm";
            btn_Timkiem.UseVisualStyleBackColor = true;
            btn_Timkiem.Click += btn_TimKiem_Click;
            // 
            // txt_MaSv
            // 
            txt_MaSv.Location = new Point(269, 146);
            txt_MaSv.Name = "txt_MaSv";
            txt_MaSv.Size = new Size(393, 27);
            txt_MaSv.TabIndex = 40;
            // 
            // txtGDTC
            // 
            txtGDTC.Location = new Point(269, 412);
            txtGDTC.Name = "txtGDTC";
            txtGDTC.Size = new Size(393, 27);
            txtGDTC.TabIndex = 39;
            // 
            // txtTinHoc
            // 
            txtTinHoc.Location = new Point(269, 339);
            txtTinHoc.Name = "txtTinHoc";
            txtTinHoc.Size = new Size(393, 27);
            txtTinHoc.TabIndex = 38;
            // 
            // txtTiengAnh
            // 
            txtTiengAnh.Location = new Point(269, 273);
            txtTiengAnh.Name = "txtTiengAnh";
            txtTiengAnh.Size = new Size(393, 27);
            txtTiengAnh.TabIndex = 37;
            // 
            // txtTen
            // 
            txtTen.Enabled = false;
            txtTen.Location = new Point(269, 208);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(393, 27);
            txtTen.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(158, 412);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 35;
            label10.Text = "GDTC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(152, 339);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 34;
            label11.Text = "TinHoc";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(152, 273);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 33;
            label12.Text = "TiengAnh";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(152, 208);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 31;
            label13.Text = "Họ Tên SV";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(152, 146);
            label14.Name = "label14";
            label14.Size = new Size(51, 20);
            label14.TabIndex = 32;
            label14.Text = "Mã SV";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(740, 229);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 30;
            btn_Update.Text = "Cập Nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // dgv_ThongTin
            // 
            dgv_ThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ThongTin.Location = new Point(110, 504);
            dgv_ThongTin.Name = "dgv_ThongTin";
            dgv_ThongTin.RowHeadersWidth = 51;
            dgv_ThongTin.RowTemplate.Height = 29;
            dgv_ThongTin.Size = new Size(761, 153);
            dgv_ThongTin.TabIndex = 29;
            dgv_ThongTin.CellContentClick += dgv_ThongTin_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(740, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 469);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(415, 83);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 26;
            label2.Text = "Giảng Viên";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 666);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Timkiem);
            Controls.Add(txt_MaSv);
            Controls.Add(txtGDTC);
            Controls.Add(txtTinHoc);
            Controls.Add(txtTiengAnh);
            Controls.Add(txtTen);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btn_Update);
            Controls.Add(dgv_ThongTin);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Thoat;
        private Button btn_Timkiem;
        private TextBox txt_MaSv;
        private TextBox txtGDTC;
        private TextBox txtTinHoc;
        private TextBox txtTiengAnh;
        private TextBox txtTen;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btn_Update;
        private DataGridView dgv_ThongTin;
        private Button btnClear;
        private Label label3;
        private Label label2;
    }
}