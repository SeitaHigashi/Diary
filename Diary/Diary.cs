using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (classTime.Text)
            {
                case "その他":
                    customTime.Enabled = true;
                    break;
                default:
                    customTime.Enabled = false;
                    break;
            }
        }

        private void newDiaryMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Diary.xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.New(saveFileDialog.FileName);
            }
        }
    }
}
