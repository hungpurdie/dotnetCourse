using DotNetCourse.Entities;
using System;
using System.Windows.Forms;

namespace DotNetCourse
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            var ls = Person.GetList();
            personBindingSource.DataSource = ls;
            gridSinhVien.DataSource = personBindingSource;
        }
        public Person selectedPerson
        {
            get
            {
                var p = personBindingSource.Current as Person;
                return p;
            }
        }
        private void gridSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedPerson != null)
            {
                var f = new frmUser(selectedPerson.Id);
                f.Show();
            }
        }

        private void gridSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Bạn có chắc là muốn xóa sinh viên này không?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                personBindingSource.RemoveCurrent();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
