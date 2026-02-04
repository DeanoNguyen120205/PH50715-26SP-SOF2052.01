namespace Hieu_ASM
{
    partial class QLDichVu
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
            textBox2 = new TextBox();
            lblTenHangHoa = new Label();
            lblPhieuBanHang = new Label();
            btnThem = new Button();
            txtNgayTao = new TextBox();
            dgvDsHoaDon = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colTenKhach = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colNgayBatDau = new DataGridViewTextBoxColumn();
            colNgayKetThuc = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            gbChiTietPhieu = new GroupBox();
            btnXoaCT = new Button();
            txtSoLuong = new TextBox();
            btnSuaCT = new Button();
            btnThemCT = new Button();
            lblSoLuong = new Label();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            txtTenHangHoa = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            gbThongTinPhieu = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblNgayTao = new Label();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvDsHoaDon).BeginInit();
            gbChiTietPhieu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gbThongTinPhieu.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 102);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 7;
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
            // lblPhieuBanHang
            // 
            lblPhieuBanHang.AutoSize = true;
            lblPhieuBanHang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuBanHang.ForeColor = SystemColors.Highlight;
            lblPhieuBanHang.Location = new Point(282, 20);
            lblPhieuBanHang.Name = "lblPhieuBanHang";
            lblPhieuBanHang.Size = new Size(158, 25);
            lblPhieuBanHang.TabIndex = 5;
            lblPhieuBanHang.Text = "Quản Lý Dịch Vụ";
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
            // txtNgayTao
            // 
            txtNgayTao.Location = new Point(96, 46);
            txtNgayTao.Margin = new Padding(3, 2, 3, 2);
            txtNgayTao.Name = "txtNgayTao";
            txtNgayTao.Size = new Size(218, 23);
            txtNgayTao.TabIndex = 1;
            // 
            // dgvDsHoaDon
            // 
            dgvDsHoaDon.AllowUserToAddRows = false;
            dgvDsHoaDon.AllowUserToDeleteRows = false;
            dgvDsHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colTenKhach, colTenPhong, colNgayBatDau, colNgayKetThuc, colTrangThai });
            dgvDsHoaDon.Location = new Point(41, 298);
            dgvDsHoaDon.Margin = new Padding(3, 2, 3, 2);
            dgvDsHoaDon.Name = "dgvDsHoaDon";
            dgvDsHoaDon.ReadOnly = true;
            dgvDsHoaDon.RowHeadersWidth = 51;
            dgvDsHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsHoaDon.Size = new Size(679, 101);
            dgvDsHoaDon.TabIndex = 6;
            // 
            // colMaHD
            // 
            colMaHD.HeaderText = "Mã HĐ";
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            // 
            // colTenKhach
            // 
            colTenKhach.HeaderText = "Tên Khách";
            colTenKhach.Name = "colTenKhach";
            colTenKhach.ReadOnly = true;
            // 
            // colTenPhong
            // 
            colTenPhong.HeaderText = "Tên Phòng";
            colTenPhong.Name = "colTenPhong";
            colTenPhong.ReadOnly = true;
            // 
            // colNgayBatDau
            // 
            colNgayBatDau.HeaderText = "ngày Bắt Đầu";
            colNgayBatDau.Name = "colNgayBatDau";
            colNgayBatDau.ReadOnly = true;
            // 
            // colNgayKetThuc
            // 
            colNgayKetThuc.HeaderText = "Ngày Kết Thúc";
            colNgayKetThuc.Name = "colNgayKetThuc";
            colNgayKetThuc.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // gbChiTietPhieu
            // 
            gbChiTietPhieu.Controls.Add(btnXoaCT);
            gbChiTietPhieu.Controls.Add(txtSoLuong);
            gbChiTietPhieu.Controls.Add(btnSuaCT);
            gbChiTietPhieu.Controls.Add(btnThemCT);
            gbChiTietPhieu.Controls.Add(lblSoLuong);
            gbChiTietPhieu.Controls.Add(txtDonGia);
            gbChiTietPhieu.Controls.Add(lblDonGia);
            gbChiTietPhieu.Controls.Add(txtTenHangHoa);
            gbChiTietPhieu.Controls.Add(lblTenHangHoa);
            gbChiTietPhieu.Location = new Point(382, 47);
            gbChiTietPhieu.Margin = new Padding(3, 2, 3, 2);
            gbChiTietPhieu.Name = "gbChiTietPhieu";
            gbChiTietPhieu.Padding = new Padding(3, 2, 3, 2);
            gbChiTietPhieu.Size = new Size(338, 200);
            gbChiTietPhieu.TabIndex = 3;
            gbChiTietPhieu.TabStop = false;
            gbChiTietPhieu.Text = "Chi tiết dịch vụ";
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
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(109, 96);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(217, 23);
            txtSoLuong.TabIndex = 1;
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
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(44, 94);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(41, 15);
            lblSoLuong.TabIndex = 0;
            lblSoLuong.Text = "Mô tả ";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(109, 71);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(217, 23);
            txtDonGia.TabIndex = 1;
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
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new Point(109, 46);
            txtTenHangHoa.Margin = new Padding(3, 2, 3, 2);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.ReadOnly = true;
            txtTenHangHoa.Size = new Size(217, 23);
            txtTenHangHoa.TabIndex = 1;
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
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbThongTinPhieu
            // 
            gbThongTinPhieu.Controls.Add(textBox2);
            gbThongTinPhieu.Controls.Add(label2);
            gbThongTinPhieu.Controls.Add(textBox1);
            gbThongTinPhieu.Controls.Add(label1);
            gbThongTinPhieu.Controls.Add(btnLamMoi);
            gbThongTinPhieu.Controls.Add(btnXoa);
            gbThongTinPhieu.Controls.Add(btnSua);
            gbThongTinPhieu.Controls.Add(btnThem);
            gbThongTinPhieu.Controls.Add(txtNgayTao);
            gbThongTinPhieu.Controls.Add(lblNgayTao);
            gbThongTinPhieu.Location = new Point(34, 47);
            gbThongTinPhieu.Margin = new Padding(3, 2, 3, 2);
            gbThongTinPhieu.Name = "gbThongTinPhieu";
            gbThongTinPhieu.Padding = new Padding(3, 2, 3, 2);
            gbThongTinPhieu.Size = new Size(343, 204);
            gbThongTinPhieu.TabIndex = 4;
            gbThongTinPhieu.TabStop = false;
            gbThongTinPhieu.Text = "Dịch Vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Ngày Bắt Đầu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 73);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Ngày Tạo ";
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
            lblNgayTao.Location = new Point(30, 45);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(44, 15);
            lblNgayTao.TabIndex = 0;
            lblNgayTao.Text = "Mã HĐ";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // QLDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "QLDichVu";
            Text = "QLDichVu";
            ((System.ComponentModel.ISupportInitialize)dgvDsHoaDon).EndInit();
            gbChiTietPhieu.ResumeLayout(false);
            gbChiTietPhieu.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gbThongTinPhieu.ResumeLayout(false);
            gbThongTinPhieu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private Label lblTenHangHoa;
        private Label lblPhieuBanHang;
        private Button btnThem;
        private TextBox txtNgayTao;
        private DataGridView dgvDsHoaDon;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colTenKhach;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colNgayBatDau;
        private DataGridViewTextBoxColumn colNgayKetThuc;
        private DataGridViewTextBoxColumn colTrangThai;
        private GroupBox gbChiTietPhieu;
        private Button btnXoaCT;
        private TextBox txtSoLuong;
        private Button btnSuaCT;
        private Button btnThemCT;
        private Label lblSoLuong;
        private TextBox txtDonGia;
        private Label lblDonGia;
        private TextBox txtTenHangHoa;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox gbThongTinPhieu;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Label lblNgayTao;
        private TabPage tabPage2;
    }
}