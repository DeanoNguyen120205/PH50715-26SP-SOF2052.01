namespace Hieu_ASM
{
    partial class QLPhongTro
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
            btnThem = new Button();
            tabPage1 = new TabPage();
            dgvDsHoaDon = new DataGridView();
            gbThongTinPhieu = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblNgayTao = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            colmaPhong = new DataGridViewTextBoxColumn();
            coldienTich = new DataGridViewTextBoxColumn();
            colGiaThue = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            txtMaPhong = new TextBox();
            lblTenHangHoa = new Label();
            lblDonGia = new Label();
            lblSoLuong = new Label();
            btnThemCT = new Button();
            btnSuaCT = new Button();
            btnXoaCT = new Button();
            gbChiTietPhieu = new GroupBox();
            txtTienIch = new TextBox();
            txtGiaThue = new TextBox();
            txtDienTich = new TextBox();
            txtTinhTrangPhong = new TextBox();
            txtMoTa = new TextBox();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsHoaDon).BeginInit();
            gbThongTinPhieu.SuspendLayout();
            tabControl1.SuspendLayout();
            gbChiTietPhieu.SuspendLayout();
            SuspendLayout();
            // 
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = SystemColors.Highlight;
            lblPhieuBanHang.Location = new Point(284, 23);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(183, 25);
            lblPhieuBanHang.TabIndex = 5;
            lblPhieuBanHang.Text = "Quản Lý Phòng Trọ";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(58, 152);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDsHoaDon);
            tabPage1.Controls.Add(lblPhieuBanHang);
            tabPage1.Controls.Add(gbChiTietPhieu);
            tabPage1.Controls.Add(gbThongTinPhieu);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phòng Trọ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDsHoaDon
            // 
            dgvDsHoaDon.AllowUserToAddRows = false;
            dgvDsHoaDon.AllowUserToDeleteRows = false;
            dgvDsHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsHoaDon.Columns.AddRange(new DataGridViewColumn[] { colmaPhong, coldienTich, colGiaThue, colTrangThai });
            dgvDsHoaDon.Location = new Point(41, 298);
            dgvDsHoaDon.Margin = new Padding(3, 2, 3, 2);
            dgvDsHoaDon.Name = "dgvDsHoaDon";
            dgvDsHoaDon.ReadOnly = true;
            dgvDsHoaDon.RowHeadersWidth = 51;
            dgvDsHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsHoaDon.Size = new Size(679, 101);
            dgvDsHoaDon.TabIndex = 6;
            // 
            // gbThongTinPhieu
            // 
            gbThongTinPhieu.Controls.Add(txtDienTich);
            gbThongTinPhieu.Controls.Add(txtGiaThue);
            gbThongTinPhieu.Controls.Add(txtMaPhong);
            gbThongTinPhieu.Controls.Add(radioButton2);
            gbThongTinPhieu.Controls.Add(radioButton1);
            gbThongTinPhieu.Controls.Add(label3);
            gbThongTinPhieu.Controls.Add(label2);
            gbThongTinPhieu.Controls.Add(label1);
            gbThongTinPhieu.Controls.Add(btnLamMoi);
            gbThongTinPhieu.Controls.Add(btnXoa);
            gbThongTinPhieu.Controls.Add(btnSua);
            gbThongTinPhieu.Controls.Add(btnThem);
            gbThongTinPhieu.Controls.Add(lblNgayTao);
            gbThongTinPhieu.Location = new Point(34, 47);
            gbThongTinPhieu.Margin = new Padding(3, 2, 3, 2);
            gbThongTinPhieu.Name = "gbThongTinPhieu";
            gbThongTinPhieu.Padding = new Padding(3, 2, 3, 2);
            gbThongTinPhieu.Size = new Size(343, 204);
            gbThongTinPhieu.TabIndex = 4;
            gbThongTinPhieu.TabStop = false;
            gbThongTinPhieu.Text = "Phòng trọ";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(201, 120);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hết";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(136, 120);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Còn";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 122);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Trạng Thái Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Giá Thuê";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Diện Tích";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(183, 178);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(82, 22);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(183, 152);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(58, 178);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(29, 36);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(62, 15);
            lblNgayTao.TabIndex = 0;
            lblNgayTao.Text = "Mã Phòng";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 451);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Phòng Trọ Chi Tiết";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // colmaPhong
            // 
            colmaPhong.HeaderText = "Mã Phòng";
            colmaPhong.Name = "colmaPhong";
            colmaPhong.ReadOnly = true;
            // 
            // coldienTich
            // 
            coldienTich.HeaderText = "Diện Tích";
            coldienTich.Name = "coldienTich";
            coldienTich.ReadOnly = true;
            // 
            // colGiaThue
            // 
            colGiaThue.HeaderText = "Giá Thuê";
            colGiaThue.Name = "colGiaThue";
            colGiaThue.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(95, 33);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(218, 23);
            txtMaPhong.TabIndex = 11;
            // 
            // lblTenHangHoa
            // 
            lblTenHangHoa.AutoSize = true;
            lblTenHangHoa.Location = new Point(18, 45);
            lblTenHangHoa.Name = "lblTenHangHoa";
            lblTenHangHoa.Size = new Size(49, 15);
            lblTenHangHoa.TabIndex = 0;
            lblTenHangHoa.Text = "Tiện Ích";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(4, 70);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(102, 15);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Tình Trạng Phòng";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(44, 94);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(41, 15);
            lblSoLuong.TabIndex = 0;
            lblSoLuong.Text = "Mô tả ";
            // 
            // btnThemCT
            // 
            btnThemCT.Location = new Point(68, 136);
            btnThemCT.Margin = new Padding(3, 2, 3, 2);
            btnThemCT.Name = "btnThemCT";
            btnThemCT.Size = new Size(82, 22);
            btnThemCT.TabIndex = 3;
            btnThemCT.Text = "Thêm";
            btnThemCT.UseVisualStyleBackColor = true;
            // 
            // btnSuaCT
            // 
            btnSuaCT.Location = new Point(156, 136);
            btnSuaCT.Margin = new Padding(3, 2, 3, 2);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(82, 22);
            btnSuaCT.TabIndex = 3;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            // 
            // btnXoaCT
            // 
            btnXoaCT.Location = new Point(243, 136);
            btnXoaCT.Margin = new Padding(3, 2, 3, 2);
            btnXoaCT.Name = "btnXoaCT";
            btnXoaCT.Size = new Size(82, 22);
            btnXoaCT.TabIndex = 3;
            btnXoaCT.Text = "Xóa";
            btnXoaCT.UseVisualStyleBackColor = true;
            // 
            // gbChiTietPhieu
            // 
            gbChiTietPhieu.Controls.Add(txtMoTa);
            gbChiTietPhieu.Controls.Add(txtTinhTrangPhong);
            gbChiTietPhieu.Controls.Add(txtTienIch);
            gbChiTietPhieu.Controls.Add(btnXoaCT);
            gbChiTietPhieu.Controls.Add(btnSuaCT);
            gbChiTietPhieu.Controls.Add(btnThemCT);
            gbChiTietPhieu.Controls.Add(lblSoLuong);
            gbChiTietPhieu.Controls.Add(lblDonGia);
            gbChiTietPhieu.Controls.Add(lblTenHangHoa);
            gbChiTietPhieu.Location = new Point(382, 47);
            gbChiTietPhieu.Margin = new Padding(3, 2, 3, 2);
            gbChiTietPhieu.Name = "gbChiTietPhieu";
            gbChiTietPhieu.Padding = new Padding(3, 2, 3, 2);
            gbChiTietPhieu.Size = new Size(338, 200);
            gbChiTietPhieu.TabIndex = 3;
            gbChiTietPhieu.TabStop = false;
            gbChiTietPhieu.Text = "Chi tiết phòng";
            // 
            // txtTienIch
            // 
            txtTienIch.Location = new Point(107, 33);
            txtTienIch.Name = "txtTienIch";
            txtTienIch.Size = new Size(218, 23);
            txtTienIch.TabIndex = 12;
            // 
            // txtGiaThue
            // 
            txtGiaThue.Location = new Point(95, 90);
            txtGiaThue.Name = "txtGiaThue";
            txtGiaThue.Size = new Size(218, 23);
            txtGiaThue.TabIndex = 12;
            // 
            // txtDienTich
            // 
            txtDienTich.Location = new Point(95, 62);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.Size = new Size(218, 23);
            txtDienTich.TabIndex = 13;
            // 
            // txtTinhTrangPhong
            // 
            txtTinhTrangPhong.Location = new Point(107, 63);
            txtTinhTrangPhong.Name = "txtTinhTrangPhong";
            txtTinhTrangPhong.Size = new Size(218, 23);
            txtTinhTrangPhong.TabIndex = 14;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(107, 93);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(218, 23);
            txtMoTa.TabIndex = 15;
            // 
            // QLPhongTro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "QLPhongTro";
            Text = "QLPhongTro";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsHoaDon).EndInit();
            gbThongTinPhieu.ResumeLayout(false);
            gbThongTinPhieu.PerformLayout();
            tabControl1.ResumeLayout(false);
            gbChiTietPhieu.ResumeLayout(false);
            gbChiTietPhieu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPhieuBanHang;
        private Button btnThem;
        private TabPage tabPage1;
        private DataGridView dgvDsHoaDon;
        private GroupBox gbThongTinPhieu;
        private Label label2;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Label lblNgayTao;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private DataGridViewTextBoxColumn colmaPhong;
        private DataGridViewTextBoxColumn coldienTich;
        private DataGridViewTextBoxColumn colGiaThue;
        private DataGridViewTextBoxColumn colTrangThai;
        private GroupBox gbChiTietPhieu;
        private TextBox txtMoTa;
        private TextBox txtTinhTrangPhong;
        private TextBox txtTienIch;
        private Button btnXoaCT;
        private Button btnSuaCT;
        private Button btnThemCT;
        private Label lblSoLuong;
        private Label lblDonGia;
        private Label lblTenHangHoa;
        private TextBox txtDienTich;
        private TextBox txtGiaThue;
        private TextBox txtMaPhong;
    }
}