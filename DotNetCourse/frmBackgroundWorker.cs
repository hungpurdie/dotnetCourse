using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetCourse
{
    public partial class frmBackgroundWorker : Form
    {
        public frmBackgroundWorker()
        {
            InitializeComponent();
            

        }
        void addNode(TreeNode ParentNode, string ParentDirectory, int level)
        {
            try
            {
                if (level < 5)
                {


                    var directoryInfo = new DirectoryInfo(ParentDirectory);
                    var directories = directoryInfo.GetDirectories();
                    if (directories.Length > 0)
                    {
                        foreach (var directory in directories)
                        {

                            TreeNode node = new TreeNode(directory.Name);
                            ParentNode.Nodes.Add(node);

                            addNode(node, directory.FullName, level + 1);
                        }
                    }
                }
            }
            catch
            {

            }

        }

        private void frmBackgroundWorker_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BackgroundWorker worker = new BackgroundWorker();
            List<TreeNode> ls = new List<TreeNode>();

            worker.DoWork += (t, w) =>
            {
                
                var drivers = Environment.GetLogicalDrives();
                foreach (var drive in drivers)
                {
                    TreeNode nodeDrive = new TreeNode(drive);
                    ls.Add(nodeDrive);
                    addNode(nodeDrive, drive, 1);
                }
            };
            worker.RunWorkerCompleted += (t, w) =>
            {
                treeView1.Nodes.AddRange(ls.ToArray());
                pictureBox1.Visible = false;
            };
            worker.RunWorkerAsync();

           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
