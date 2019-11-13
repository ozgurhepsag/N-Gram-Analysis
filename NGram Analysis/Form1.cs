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
        FileOperations fileOp;
        List<KeyValuePair<NGram, int>> sortedUnigram;
        List<KeyValuePair<NGram, int>> sortedBigram;
        List<KeyValuePair<NGram, int>> sortedTrigram;

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
                fileOp = new FileOperations(browseFileName.Text);
                sortedUnigram = fileOp.SortNGram(fileOp.GetUnigram());
                FillGridViews(dataGridView3, sortedUnigram);
                sortedBigram = fileOp.SortNGram(fileOp.GetBigram());
                FillGridViews(dataGridView2, sortedBigram);
                sortedTrigram = fileOp.SortNGram(fileOp.GetTrigram());
                FillGridViews(dataGridView1, sortedTrigram);
            }
        }

        private void FillGridViews(DataGridView dataGridView, List<KeyValuePair<NGram, int>> sortedGram)
        {
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "NGram";
            dataGridView.Columns[1].Name = "Frequency";

            for (int i = 0; i < 100; i++)
            {
                string[] row = new string[] { sortedGram[i].Key.ToString(), sortedGram[i].Value.ToString() };
                dataGridView.Rows.Add(row);
            }
        }
    }
}
