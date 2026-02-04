using DuAnMau_QuanLyPhongtro_PH50715.BLL;
using System;
using System.Windows.Forms;

namespace DuAnMau_QuanLyPhongtro_PH50715
{
    public partial class QLChuTro : Form
    {
        private int _idSelected = -1;

        public QLChuTro()
        {
            InitializeComponent();
            this.Load += QLChuTro_Load;
        }

        // ================= FORM LOAD =================
        private void QLChuTro_Load(object sender, EventArgs e)
        {
            dgvChuTro.AutoGenerateColumns = false;
            InitGrid();
            LoadData();
            ClearForm();
        }

        // ================= INIT GRID =================
        private void InitGrid()
        {
            dgvChuTro.Columns.Clear();
            dgvChuTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChuTro.MultiSelect = false;

            dgvChuTro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdChuTro",
                HeaderText = "ID",
                DataPropertyName = "idChuTro",
                Width = 50
            });

            dgvChuTro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenChuTro",
                HeaderText = "Tên chủ trọ",
                DataPropertyName = "tenChuTro",
                Width = 150
            });

            dgvChuTro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GioiTinh",
                HeaderText = "Giới tính",
                DataPropertyName = "gioiTinh_ct",
                Width = 80
            });

            dgvChuTro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoCanCuoc",
                HeaderText = "CCCD",
                DataPropertyName = "soCanCuoc_ct",
                Width = 130
            });

            dgvChuTro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                HeaderText = "SĐT",
                DataPropertyName = "soDienThoai_ct",
                Width = 120
            });

            dgvChuTro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tuoi",
                HeaderText = "Tuổi",
                DataPropertyName = "tuoi_ct",
                Width = 50
            });
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            dgvChuTro.DataSource = ChuTroBLL.GetAll();
            dgvChuTro.ClearSelection();   // ⭐ CHỐT BUG TỰ SELECT
            _idSelected = -1;
        }

        // ================= SELECT =================
        //private void dgvChuTro_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvChuTro.SelectedRows.Count == 0) return;

        //    DataGridViewRow row = dgvChuTro.SelectedRows[0];
        //    if (row.Cells["IdChuTro"].Value == null) return;

        //    _idSelected = Convert.ToInt32(row.Cells["IdChuTro"].Value);

        //    txtHoTenCT.Text = row.Cells["TenChuTro"].Value?.ToString();
        //    txtCCCDCT.Text = row.Cells["SoCanCuoc"].Value?.ToString();
        //    txtSDTCT.Text = row.Cells["SoDienThoai"].Value?.ToString();
        //    txtTuoiCT.Text = row.Cells["Tuoi"].Value?.ToString();

        //    string gt = row.Cells["GioiTinh"].Value?.ToString();
        //    rdoNamCT.Checked = gt == "Nam";
        //    rdoNuCT.Checked = gt == "Nữ";
        //}
        private void dgvChuTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChuTro.Rows[e.RowIndex];

            if (row.Cells["IdChuTro"].Value == null) return;

            _idSelected = Convert.ToInt32(row.Cells["IdChuTro"].Value);

            txtHoTenCT.Text = row.Cells["TenChuTro"].Value?.ToString();
            txtCCCDCT.Text = row.Cells["SoCanCuoc"].Value?.ToString();
            txtSDTCT.Text = row.Cells["SoDienThoai"].Value?.ToString();
            txtTuoiCT.Text = row.Cells["Tuoi"].Value?.ToString();

            string gt = row.Cells["GioiTinh"].Value?.ToString();
            rdoNamCT.Checked = gt == "Nam";
            rdoNuCT.Checked = gt == "Nữ";
        }

        // ================= HELPERS =================
        private string GetGioiTinh()
        {
            if (rdoNamCT.Checked) return "Nam";
            if (rdoNuCT.Checked) return "Nữ";
            return "";
        }

        private void ClearForm()
        {
            txtHoTenCT.Clear();
            txtCCCDCT.Clear();
            txtSDTCT.Clear();
            txtTuoiCT.Clear();
            rdoNamCT.Checked = false;
            rdoNuCT.Checked = false;
            _idSelected = -1;
            dgvChuTro.ClearSelection();
        }

        // ================= ADD =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTenCT.Text))
            {
                MessageBox.Show("Tên không được trống");
                return;
            }

            if (!int.TryParse(txtTuoiCT.Text, out int tuoi))
            {
                MessageBox.Show("Tuổi không hợp lệ");
                return;
            }

            if (GetGioiTinh() == "")
            {
                MessageBox.Show("Chọn giới tính");
                return;
            }

            ChuTroBLL.Insert(
                txtHoTenCT.Text.Trim(),
                GetGioiTinh(),
                txtCCCDCT.Text.Trim(),
                txtSDTCT.Text.Trim(),
                tuoi
            );

            LoadData();
            ClearForm();
        }

        // ================= UPDATE =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_idSelected == -1)
            {
                MessageBox.Show("Chưa chọn dữ liệu");
                return;
            }

            ChuTroBLL.Update(
                _idSelected,
                txtHoTenCT.Text.Trim(),
                GetGioiTinh(),
                txtCCCDCT.Text.Trim(),
                txtSDTCT.Text.Trim(),
                int.Parse(txtTuoiCT.Text)
            );

            LoadData();
            ClearForm();
        }

        // ================= DELETE =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_idSelected == -1)
            {
                MessageBox.Show("Chưa chọn dữ liệu");
                return;
            }

            if (MessageBox.Show("Xóa chủ trọ này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            ChuTroBLL.Delete(_idSelected);
            LoadData();
            ClearForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
