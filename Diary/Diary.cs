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
            InitializeClassTimeComboBox();
            OpenDiary();
        }

        private void InitializeClassTimeComboBox()
        {
            List<ClassTime> src = new List<ClassTime>();
            src.Add(new ClassTime("通常授業", 90));
            src.Add(new ClassTime("80分授業", 80));
            src.Add(new ClassTime("その他", 0));
            classTime.DataSource = src;
            classTime.DisplayMember = "display";
            classTime.ValueMember = "value";
        }

        private void Initialize()
        {
            todaysPlans.Text = "";
            performance.Text = "";
            task.Text = "";
            tomorrowsPlan.Text = "";
        }

        private string SetDestination(string destination)
        {
            this.destination = destination;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["destination"].Value = destination;
            config.Save();
            return this.destination;
        }

        private void OpenDiary()
        {
            Initialize();
            todaysPlans.Text = Excel.LoadPlans(destination);
        }

        private void Save()
        {
            var log = new Log();
            log.date = date.Value;
            log.classTime = 0;
            log.performance = performance.Text;
            log.task = task.Text;
            log.plan = tomorrowsPlan.Text;
            Excel.Save(destination, log);
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
                    customTime.Value = 0;
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
                SetDestination(destination);
                Excel.New(destination);
                OpenDiary();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openDiaryMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files(*.*)|*.*";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetDestination(openFileDialog.FileName);
                    OpenDiary();
                }
            }
        }
    }
}
