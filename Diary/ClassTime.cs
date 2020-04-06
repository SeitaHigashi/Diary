namespace Diary
{
    class ClassTime
    {
        public string display { get; set; }

        public int value { get; set; }

        public bool custom { get; set; }

        public ClassTime(string display, int value, bool custom)
        {
            this.display = display;
            this.value = value;
            this.custom = custom;
        }
    }
}
