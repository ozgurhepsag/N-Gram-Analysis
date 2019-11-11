using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGram_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseFileBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                browseFileName.Text = openFileDialog1.SelectedPath;
                FileOperations fileOp = new FileOperations(browseFileName.Text);

                int freq = fileOp.GetUnigram().GetFrequency("ben");
                Console.WriteLine(freq);
                Console.Read();
            }
        }
    }
}
