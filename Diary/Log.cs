using System;

namespace Diary
{
    class Log
    {

        public DateTime date;

        public int classTime;

        public string performance;

        public string task;

        public string plan;

        public Log(DateTime date, int classTime, string performance, string task, string plan)
        {
            this.date = date;
            this.classTime = classTime;
            this.performance = performance;
            this.task = task;
            this.plan = plan;
        }

        public Log()
        {
            date = new DateTime();
            classTime = 0;
            performance = "";
            task = "";
            plan = "";
        }

    }
}
