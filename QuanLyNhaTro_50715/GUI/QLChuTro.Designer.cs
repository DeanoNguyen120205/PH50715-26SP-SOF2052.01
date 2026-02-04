namespace DuAnMau_QuanLyPhongtro_PH50715
{
    partial class QLChuTro
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
            colPhoneNumber = new DataGridViewTextBoxColumn();
            txtCCCDCT = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtTuoiCT = new TextBox();
            label4 = new Label();
            txtSDTCT = new TextBox();
            colCCCD = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            dgvChuTro = new DataGridView();
            colAge = new DataGridViewTextBoxColumn();
            label3 = new Label();
            rdoNuCT = new RadioButton();
            rdoNamCT = new RadioButton();
            lblTrangThai = new Label();
            groupBox1 = new GroupBox();
            txtHoTenCT = new TextBox();
            lblNgayTao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChuTro).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = SystemColors.Highlight;
            lblPhieuBanHang.Location = new Point(299, 25);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(159, 25);
            lblPhieuBanHang.TabIndex = 14;
            lblPhieuBanHang.Text = "Quản Lý Chủ Trọ";
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.HeaderText = "SĐT";
            colPhoneNumber.Name = "colPhoneNumber";
            // 
            // txtCCCDCT
            // 
            txtCCCDCT.Location = new Point(229, 100);
            txtCCCDCT.Margin = new Padding(3, 2, 3, 2);
            txtCCCDCT.Name = "txtCCCDCT";
            txtCCCDCT.Size = new Size(218, 23);
            txtCCCDCT.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 103);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 26;
            label2.Text = "Số CCCD";
            // 
            // button4
            // 
            button4.Location = new Point(465, 58);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 24;
            button4.Text = "Làm Mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnLamMoi_Click;
            // 
            // button3
            // 
            button3.Location = new Point(304, 58);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnXoa_Click;
            // 
            // button2
            // 
            button2.Location = new Point(176, 58);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSua_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // txtTuoiCT
            // 
            txtTuoiCT.Location = new Point(390, 169);
            txtTuoiCT.Margin = new Padding(3, 2, 3, 2);
            txtTuoiCT.Name = "txtTuoiCT";
            txtTuoiCT.Size = new Size(218, 23);
            txtTuoiCT.TabIndex = 20;
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
            // txtSDTCT
            // 
            txtSDTCT.Location = new Point(390, 139);
            txtSDTCT.Margin = new Padding(3, 2, 3, 2);
            txtSDTCT.Name = "txtSDTCT";
            txtSDTCT.Size = new Size(218, 23);
            txtSDTCT.TabIndex = 18;
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
            // dgvChuTro
            // 
            dgvChuTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChuTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChuTro.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colGender, colCCCD, colPhoneNumber, colAge });
            dgvChuTro.Location = new Point(36, 275);
            dgvChuTro.Name = "dgvChuTro";
            dgvChuTro.Size = new Size(728, 150);
            dgvChuTro.TabIndex = 15;
            dgvChuTro.CellClick += dgvChuTro_CellClick;
            // 
            // colAge
            // 
            colAge.HeaderText = "Tuổi";
            colAge.Name = "colAge";
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
            // rdoNuCT
            // 
            rdoNuCT.AutoSize = true;
            rdoNuCT.Location = new Point(195, 164);
            rdoNuCT.Margin = new Padding(3, 2, 3, 2);
            rdoNuCT.Name = "rdoNuCT";
            rdoNuCT.Size = new Size(41, 19);
            rdoNuCT.TabIndex = 11;
            rdoNuCT.TabStop = true;
            rdoNuCT.Text = "Nữ";
            rdoNuCT.UseVisualStyleBackColor = true;
            // 
            // rdoNamCT
            // 
            rdoNamCT.AutoSize = true;
            rdoNamCT.Location = new Point(86, 164);
            rdoNamCT.Margin = new Padding(3, 2, 3, 2);
            rdoNamCT.Name = "rdoNamCT";
            rdoNamCT.Size = new Size(51, 19);
            rdoNamCT.TabIndex = 12;
            rdoNamCT.TabStop = true;
            rdoNamCT.Text = "Nam";
            rdoNamCT.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCCCDCT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtTuoiCT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSDTCT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rdoNuCT);
            groupBox1.Controls.Add(rdoNamCT);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(txtHoTenCT);
            groupBox1.Controls.Add(lblNgayTao);
            groupBox1.Location = new Point(91, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 197);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chủ trọ";
            // 
            // txtHoTenCT
            // 
            txtHoTenCT.Location = new Point(86, 136);
            txtHoTenCT.Margin = new Padding(3, 2, 3, 2);
            txtHoTenCT.Name = "txtHoTenCT";
            txtHoTenCT.Size = new Size(218, 23);
            txtHoTenCT.TabIndex = 10;
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
            // QLChuTro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPhieuBanHang);
            Controls.Add(dgvChuTro);
            Controls.Add(groupBox1);
            Name = "QLChuTro";
            Text = "QLChuTro";
            ((System.ComponentModel.ISupportInitialize)dgvChuTro).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhieuBanHang;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private TextBox txtCCCDCT;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtTuoiCT;
        private Label label4;
        private TextBox txtSDTCT;
        private DataGridViewTextBoxColumn colCCCD;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colID;
        private DataGridView dgvChuTro;
        private DataGridViewTextBoxColumn colAge;
        private Label label3;
        private RadioButton rdoNuCT;
        private RadioButton rdoNamCT;
        private Label lblTrangThai;
        private GroupBox groupBox1;
        private TextBox txtHoTenCT;
        private Label lblNgayTao;
    }
}