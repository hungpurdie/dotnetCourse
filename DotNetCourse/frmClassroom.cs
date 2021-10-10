
using DotNetCourse.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DotNetCourse
{
    public partial class frmClassroom : Form

    {
        public frmClassroom()
        {
            InitializeComponent();
            List<string> lsKhoa = new List<string>();
            //flag = false;
            cmbKhoa.DataSource = Faculty.GetList();
            cmbKhoa.DisplayMember = "Name"; // yêu cầu hiển thị tên
            cmbKhoa.ValueMember = "Id";
            //flag = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbKhoa.SelectedIndex;
            var item = cmbKhoa.SelectedItem as Faculty;//Unbox
            var lsPerson = Person.GetList(item.Id);
            dataGridView1.DataSource = lsPerson;
        }
    }
}
