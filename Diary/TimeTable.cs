using System.Windows.Forms;

namespace Diary
{
    public partial class TimeTable : UserControl
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        public int Count
        {
            get
            {
                int i = 0;
                foreach (Control item in timeTableLayoutPanel.Controls)
                {
                    if (item.GetType().Equals(typeof(CheckBox)))
                    {
                        if (((CheckBox)item).Checked == true)
                            i++;
                    }
                }
                return i;
            }

        }
    }

}
