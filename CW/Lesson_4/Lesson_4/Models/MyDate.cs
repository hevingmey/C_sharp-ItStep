namespace Lesson_4.Models;

public struct MyDate

    
    {
        public int Year;
        public int Month;
        public int Day;
        public MyDate(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public override string ToString()
        {
            return $"{this.Year}-{this.Month}-{this.Day}";
        }

    }
