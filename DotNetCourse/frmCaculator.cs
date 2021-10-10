using System;
using System.Windows.Forms;

namespace DotNetCourse
{
    public partial class frmCaculator : Form
    {
        public frmCaculator()
        {
            InitializeComponent();
        }

        private void frmCaculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {

                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nSoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ nhất",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuHai, out temp))
                    nSoThuHai = double.Parse(soThuHai);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ hai",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                var ketQua = nSoThuNhat + nSoThuHai;

                lblKetQua.Text = ketQua.ToString("N0");
            }
            #region Catch error
            catch (FormatException ex)
            {
                MessageBox.Show(
                    $"Lỗi định dạng. Vui lòng nhập số. Chi tiết lỗi: {ex.Message}",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                    $"Lỗi tràn số. Vui lòng nhập số ngắn lại. Chi tiết lỗi: {ex.Message}",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi rồi bạn ơi. Chi tiết lỗi: {ex.Message}",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            #endregion
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                {
                    nSoThuNhat = Convert.ToInt64(soThuNhat);
                }
                else
                {

                    MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số lại số thứ nhất", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuNhat, out temp))
                {
                    nSoThuHai = long.Parse(soThuHai);
                }

                var ketQua = nSoThuNhat - nSoThuHai;
                lblKetQua.Text = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số. Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi trán số. Vui lòng nhấp số bé hơn.Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn ơi. Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                {
                    nSoThuNhat = Convert.ToInt64(soThuNhat);
                }
                else
                {

                    MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số lại số thứ nhất", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuNhat, out temp))
                {
                    nSoThuHai = long.Parse(soThuHai);
                }

                var ketQua = nSoThuNhat * nSoThuHai;
                lblKetQua.Text = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số. Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi trán số. Vui lòng nhấp số bé hơn.Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn ơi. Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                {
                    nSoThuNhat = double.Parse(soThuNhat);

                }
                else
                {

                    MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số lại số thứ nhất", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuNhat, out temp))
                {
                    nSoThuHai = double.Parse(soThuHai);
                }
                else
                {

                    MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số lại số thứ nhất", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var KetQua1 = nSoThuNhat / nSoThuHai;

                lblKetQua.Text = Convert.ToString(KetQua1);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhấp số. Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi trán số. Vui lòng nhấp số bé hơn.Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn ơi. Chi tiết lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
