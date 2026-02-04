namespace DuAnMau_QuanLyPhongtro_PH50715
{
    partial class QLKhachThue
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
            lblPhieuBanHang = new Label();
            btnLamMoiKhachThue = new Button();
            btnXoaKhachThue = new Button();
            btnSuaKhachThue = new Button();
            btnThemKhachThue = new Button();
            txtTuoiKhachHang = new TextBox();
            label4 = new Label();
            txtSDTKhachHang = new TextBox();
            label3 = new Label();
            txtCCCDKhach = new TextBox();
            label2 = new Label();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colCCCD = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            rdoNuKH = new RadioButton();
            rdoNamKH = new RadioButton();
            lblTrangThai = new Label();
            txtHoTen = new TextBox();
            lblNgayTao = new Label();
            colAge = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            dgvKhachThue = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachThue).BeginInit();
            SuspendLayout();
            // 
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = SystemColors.Highlight;
            lblPhieuBanHang.Location = new Point(335, 27);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(191, 25);
            lblPhieuBanHang.TabIndex = 15;
            lblPhieuBanHang.Text = "Quản Lý Khách Thuê";
            // 
            // btnLamMoiKhachThue
            // 
            btnLamMoiKhachThue.Location = new Point(465, 58);
            btnLamMoiKhachThue.Name = "btnLamMoiKhachThue";
            btnLamMoiKhachThue.Size = new Size(75, 23);
            btnLamMoiKhachThue.TabIndex = 24;
            btnLamMoiKhachThue.Text = "Làm Mới";
            btnLamMoiKhachThue.UseVisualStyleBackColor = true;
            // 
            // btnXoaKhachThue
            // 
            btnXoaKhachThue.Location = new Point(304, 58);
            btnXoaKhachThue.Name = "btnXoaKhachThue";
            btnXoaKhachThue.Size = new Size(75, 23);
            btnXoaKhachThue.TabIndex = 23;
            btnXoaKhachThue.Text = "Xóa";
            btnXoaKhachThue.UseVisualStyleBackColor = true;
            btnXoaKhachThue.Click += btnXoaKhachThue_Click;
            // 
            // btnSuaKhachThue
            // 
            btnSuaKhachThue.Location = new Point(176, 58);
            btnSuaKhachThue.Name = "btnSuaKhachThue";
            btnSuaKhachThue.Size = new Size(75, 23);
            btnSuaKhachThue.TabIndex = 22;
            btnSuaKhachThue.Text = "Sửa";
            btnSuaKhachThue.UseVisualStyleBackColor = true;
            btnSuaKhachThue.Click += btnSuaKhachThue_Click;
            // 
            // btnThemKhachThue
            // 
            btnThemKhachThue.Location = new Point(32, 58);
            btnThemKhachThue.Name = "btnThemKhachThue";
            btnThemKhachThue.Size = new Size(75, 23);
            btnThemKhachThue.TabIndex = 21;
            btnThemKhachThue.Text = "Thêm";
            btnThemKhachThue.UseVisualStyleBackColor = true;
            btnThemKhachThue.Click += btnThemKhachThue_Click;
            // 
            // txtTuoiKhachHang
            // 
            txtTuoiKhachHang.Location = new Point(390, 169);
            txtTuoiKhachHang.Margin = new Padding(3, 2, 3, 2);
            txtTuoiKhachHang.Name = "txtTuoiKhachHang";
            txtTuoiKhachHang.Size = new Size(218, 23);
            txtTuoiKhachHang.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 172);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 19;
            label4.Text = "Tuổi";
            // 
            // txtSDTKhachHang
            // 
            txtSDTKhachHang.Location = new Point(390, 139);
            txtSDTKhachHang.Margin = new Padding(3, 2, 3, 2);
            txtSDTKhachHang.Name = "txtSDTKhachHang";
            txtSDTKhachHang.Size = new Size(218, 23);
            txtSDTKhachHang.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 142);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 17;
            label3.Text = "SĐT";
            // 
            // txtCCCDKhach
            // 
            txtCCCDKhach.Location = new Point(390, 112);
            txtCCCDKhach.Margin = new Padding(3, 2, 3, 2);
            txtCCCDKhach.Name = "txtCCCDKhach";
            txtCCCDKhach.Size = new Size(218, 23);
            txtCCCDKhach.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 115);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 15;
            label2.Text = "Số CCCD";
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.HeaderText = "SĐT";
            colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colCCCD
            // 
            colCCCD.HeaderText = "Số CCCD";
            colCCCD.Name = "colCCCD";
            // 
            // colGender
            // 
            colGender.HeaderText = "Giới Tính";
            colGender.Name = "colGender";
            // 
            // colName
            // 
            colName.HeaderText = "Tên";
            colName.Name = "colName";
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // rdoNuKH
            // 
            rdoNuKH.AutoSize = true;
            rdoNuKH.Location = new Point(195, 164);
            rdoNuKH.Margin = new Padding(3, 2, 3, 2);
            rdoNuKH.Name = "rdoNuKH";
            rdoNuKH.Size = new Size(41, 19);
            rdoNuKH.TabIndex = 11;
            rdoNuKH.TabStop = true;
            rdoNuKH.Text = "Nữ";
            rdoNuKH.UseVisualStyleBackColor = true;
            // 
            // rdoNamKH
            // 
            rdoNamKH.AutoSize = true;
            rdoNamKH.Location = new Point(86, 164);
            rdoNamKH.Margin = new Padding(3, 2, 3, 2);
            rdoNamKH.Name = "rdoNamKH";
            rdoNamKH.Size = new Size(51, 19);
            rdoNamKH.TabIndex = 12;
            rdoNamKH.TabStop = true;
            rdoNamKH.Text = "Nam";
            rdoNamKH.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(15, 164);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(55, 15);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Giới Tính";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(86, 136);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(218, 23);
            txtHoTen.TabIndex = 10;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(20, 139);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(46, 15);
            lblNgayTao.TabIndex = 9;
            lblNgayTao.Text = "Họ tên ";
            // 
            // colAge
            // 
            colAge.HeaderText = "Tuổi";
            colAge.Name = "colAge";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoiKhachThue);
            groupBox1.Controls.Add(btnXoaKhachThue);
            groupBox1.Controls.Add(btnSuaKhachThue);
            groupBox1.Controls.Add(btnThemKhachThue);
            groupBox1.Controls.Add(txtTuoiKhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDTKhachHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCCCDKhach);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdoNuKH);
            groupBox1.Controls.Add(rdoNamKH);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(lblNgayTao);
            groupBox1.Location = new Point(91, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 197);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách Thuê";
            // 
            // dgvKhachThue
            // 
            dgvKhachThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachThue.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colGender, colCCCD, colPhoneNumber, colAge });
            dgvKhachThue.Location = new Point(36, 273);
            dgvKhachThue.Name = "dgvKhachThue";
            dgvKhachThue.Size = new Size(728, 150);
            dgvKhachThue.TabIndex = 13;
            // 
            // QLKhachThue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPhieuBanHang);
            Controls.Add(groupBox1);
            Controls.Add(dgvKhachThue);
            Name = "QLKhachThue";
            Text = "QLKhachThue";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachThue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhieuBanHang;
        private Button btnLamMoiKhachThue;
        private Button btnXoaKhachThue;
        private Button btnSuaKhachThue;
        private Button btnThemKhachThue;
        private TextBox txtTuoiKhachHang;
        private Label label4;
        private TextBox txtSDTKhachHang;
        private Label label3;
        private TextBox txtCCCDKhach;
        private Label label2;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colCCCD;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colID;
        private RadioButton rdoNuKH;
        private RadioButton rdoNamKH;
        private Label lblTrangThai;
        private TextBox txtHoTen;
        private Label lblNgayTao;
        private DataGridViewTextBoxColumn colAge;
        private GroupBox groupBox1;
        private DataGridView dgvKhachThue;
    }
}