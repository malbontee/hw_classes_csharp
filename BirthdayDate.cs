namespace hw_classes_csharp
{
    public class BirthdayDate
    {
        private int day;
        private int month;
        private int year;

        public BirthdayDate()
            : this(1, 1, 2000) { }

        public BirthdayDate(int day, int month, int year)
        {
            SetBirthdayDate(day, month, year);
        }
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value <= 31)
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid value for day!");
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid value for month!");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0 && value <= 2021)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid value for year!");
            }
        }
        public void SetBirthdayDate(int day, int month, int year)
        {
            if (day > 0 && day <= 31)
                this.day = day;
            else
                throw new ArgumentOutOfRangeException("Invalid value for day!");
            if (month > 0 && month <= 12)
                this.month = month;
            else
                throw new ArgumentOutOfRangeException("Invalid value for month!");
            if (year > 0 && year <= 2021)
                this.year = year;
            else
                throw new ArgumentOutOfRangeException("Invalid value for year!");
        }
        public (int day, int month, int year) GetBirthdayDate()
        {
            return (day, month, year);
        }
    }
}
    
