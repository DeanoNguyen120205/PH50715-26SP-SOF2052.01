using DuAnMau_QuanLyPhongtro_PH50715.BLL;
using System;
using System.Windows.Forms;

namespace DuAnMau_QuanLyPhongtro_PH50715
{
    public partial class QLKhachThue : Form
    {
        // ================= BIẾN TOÀN CỤC =================
        private int _idSelected = -1;
        private bool _isLoading = false; // chặn SelectionChanged khi load

        public QLKhachThue()
        {
            InitializeComponent();

            dgvKhachThue.SelectionChanged += dgvKhachThue_SelectionChanged;

            LoadData();
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            _isLoading = true;

            dgvKhachThue.AutoGenerateColumns = false;
            dgvKhachThue.Columns.Clear();

            dgvKhachThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachThue.MultiSelect = false;

            dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idKhachThue",
                HeaderText = "ID",
                DataPropertyName = "idKhachThue",
                Width = 50
            });

            dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tenKhachThue",
                HeaderText = "Tên khách",
                DataPropertyName = "tenKhachThue",
                Width = 150
            });

            dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "gioiTinh_kh",
                HeaderText = "Giới tính",
                DataPropertyName = "gioiTinh_kh",
                Width = 80
            });

            dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soCanCuoc_kh",
                HeaderText = "CCCD",
                DataPropertyName = "soCanCuoc_kh",
                Width = 130
            });

            dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soDienThoai_kh",
                HeaderText = "SĐT",
                DataPropertyName = "soDienThoai_kh",
                Width = 120
            });

            dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tuoi_kh",
                HeaderText = "Tuổi",
                DataPropertyName = "tuoi_kh",
                Width = 50
            });

            dgvKhachThue.DataSource = KhachThueBLL.GetAll();

            _idSelected = -1;
            _isLoading = false;
        }

        // ================= SELECTION CHANGED =================
        private void dgvKhachThue_SelectionChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            if (dgvKhachThue.CurrentRow == null) return;

            DataGridViewRow row = dgvKhachThue.CurrentRow;
            if (row.Cells["idKhachThue"].Value == null) return;

            _idSelected = Convert.ToInt32(row.Cells["idKhachThue"].Value);

            txtHoTen.Text = row.Cells["tenKhachThue"].Value?.ToString();
            txtCCCDKhach.Text = row.Cells["soCanCuoc_kh"].Value?.ToString();
            txtSDTKhachHang.Text = row.Cells["soDienThoai_kh"].Value?.ToString();
            txtTuoiKhachHang.Text = row.Cells["tuoi_kh"].Value?.ToString();

            string gioiTinh = row.Cells["gioiTinh_kh"].Value?.ToString();
            rdoNamKH.Checked = gioiTinh == "Nam";
            rdoNuKH.Checked = gioiTinh == "Nữ";
        }

        // ================= HỖ TRỢ =================
        private string GetGioiTinh()
        {
            if (rdoNamKH.Checked) return "Nam";
            if (rdoNuKH.Checked) return "Nữ";
            return "";
        }

        private void ClearForm()
        {
            txtHoTen.Clear();
            txtCCCDKhach.Clear();
            txtSDTKhachHang.Clear();
            txtTuoiKhachHang.Clear();
            rdoNamKH.Checked = false;
            rdoNuKH.Checked = false;
            _idSelected = -1;
        }

        // ================= THÊM =================
        private void btnThemKhachThue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Tên khách không được trống");
                return;
            }

            if (!int.TryParse(txtTuoiKhachHang.Text, out int tuoi))
            {
                MessageBox.Show("Tuổi không hợp lệ");
                return;
            }

            if (GetGioiTinh() == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }

            KhachThueBLL.Add(
                txtHoTen.Text.Trim(),
                GetGioiTinh(),
                txtCCCDKhach.Text.Trim(),
                txtSDTKhachHang.Text.Trim(),
                tuoi
            );

            MessageBox.Show("Thêm thành công");
            LoadData();
            ClearForm();
        }

        // ================= SỬA =================
        private void btnSuaKhachThue_Click(object sender, EventArgs e)
        {
            if (_idSelected == -1)
            {
                MessageBox.Show("Chưa chọn khách để sửa");
                return;
            }

            KhachThueBLL.Update(
                _idSelected,
                txtHoTen.Text.Trim(),
                GetGioiTinh(),
                txtCCCDKhach.Text.Trim(),
                txtSDTKhachHang.Text.Trim(),
                int.Parse(txtTuoiKhachHang.Text)
            );

            MessageBox.Show("Cập nhật thành công");
            LoadData();
            ClearForm();
        }

        // ================= XÓA =================
        private void btnXoaKhachThue_Click(object sender, EventArgs e)
        {
            if (_idSelected == -1)
            {
                MessageBox.Show("Chưa chọn khách để xóa");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc muốn xóa khách này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            KhachThueBLL.Delete(_idSelected);

            MessageBox.Show("Xóa thành công");
            LoadData();
            ClearForm();
        }

        // ================= LÀM MỚI =================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            dgvKhachThue.ClearSelection();
        }
    }
}
