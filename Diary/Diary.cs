using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Diary
{
    public partial class Diary : Form
    {
        private string destination = ConfigurationManager.AppSettings["destination"];

        public Diary()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            todaysPlans.Text = Excel.LoadPlans(destination);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void classTime_SelectedIndexChanged(object sender, EventArgs e)
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
                destination = saveFileDialog.FileName;
                Excel.New(destination);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["destination"].Value = destination;
                config.Save();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var log = new Log();
            log.date = date.Value;
            log.classTime = 0;
            log.performance = performanceLabel.Text;
            log.task = taskLabel.Text;
            log.plan = tomorrowsPlan.Text;
            Excel.Save(destination, log);
        }
    }
}
