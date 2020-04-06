using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class ClassTime
    {
        public string display { get; set; }

        public int value { get; set; }

        public ClassTime(string display, int value)
        {
            this.display = display;
            this.value = value;
        }
    }
}
