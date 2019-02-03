using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgFolder = new FolderBrowserDialog();
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                // read files and add to list
                dataGridView1.Rows.Clear();
                // read files
                DirectoryInfo directory = new DirectoryInfo(dlgFolder.SelectedPath);
                foreach (FileInfo file in directory.GetFiles())
                {
                    if (chk_extension.Checked)
                    {
                        dataGridView1.Rows.Add(Path.GetFileNameWithoutExtension(file.Name));
                    }
                    else
                    {
                        dataGridView1.Rows.Add(file.Name);
                    }
                }
            }
        }
    }
}
