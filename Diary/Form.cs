using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Diary
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string destination = ConfigurationManager.AppSettings["destination"];

        public Form()
        {
            InitializeComponent();
            InitializeClassTimeComboBox();
            OpenDiary();
        }

        private void InitializeClassTimeComboBox()
        {
            List<ClassTime> src = new List<ClassTime>();
            src.Add(new ClassTime("通常授業", 90, false));
            src.Add(new ClassTime("80分授業", 80, false));
            src.Add(new ClassTime("通常授業+カスタム時間", 90, true));
            src.Add(new ClassTime("80分授業+カスタム時間", 80, true));
            src.Add(new ClassTime("その他", 0, true));
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
            int time = ((ClassTime)classTime.SelectedItem).value;
            int customtime = (((ClassTime)classTime.SelectedItem).custom) ? (int)customTime.Value : 0;
            var log = new Log();
            log.date = date.Value;
            log.classTime = time + customtime;
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
            customTime.Enabled = ((ClassTime)classTime.SelectedItem).custom;
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
            MessageBox.Show("保存が完了しました", "Diary");
        }

        private void openDiaryMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files(*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetDestination(openFileDialog.FileName);
                    OpenDiary();
                }
            }
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(timeTable.Count);
        }
    }
}
