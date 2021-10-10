using System;
using System.Windows.Forms;

using DotNetCourse.Entities;
namespace DotNetCourse
{
    public partial class frmUser : Form
    {
        Person person;
        public frmUser(string idPerson = "1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person != null)
            {
                //Cách 1
                txtHoTen.Text = $"{person.LastName} {person.FirstName}";
                //Cách 2
                txtHoTen.Text = person.FullName;
                dtpNgaySinh.Value = person.DOB;
                if (person.Sex == EGioiTinh.Nam)
                    rdNam.Checked = true;
                else if (person.Sex == EGioiTinh.Nu)
                    rdNu.Checked = true;
                else
                    rdKhac.Checked = true;

                groupBox1.Text = person.HomeTown;
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackGroudUser = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;

            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh(*.png, *.jpg)|*.png;*.jpg";
            dialog.Title = "Chọn ảnh đại diện";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                picAvatar.ImageLocation = fileName;
            }
        }
    }
}
