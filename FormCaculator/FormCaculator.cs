using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCaculator
{
    public partial class FormCaculator : Form
    {
        public FormCaculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cong(object sender, EventArgs e)
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

                var ketQua = nSoThuNhat + nSoThuHai;
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


        private void Tru(object sender, EventArgs e)
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

        private void Nhan(object sender, EventArgs e)
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

        private void Chia(object sender, EventArgs e)
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
