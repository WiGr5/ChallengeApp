namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
               return this.Sum / this.Count;
                //return this.Count == 0 ? 0 : this.Sum / this.Count; // przypadku wyjsca bez podawania zadnej wartosci srednia wynosi 0.00 a nie NaN jak to powyzej ma miejsce
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var avr when avr == 100:
                  return 'A';
                    case var avr when avr >= 80:
                  return 'B';
                    case var avr when avr >= 60:
                  return 'C';
                    case var avr when avr >= 40:
                 return 'D';
                    case var avr when avr >= 20:
                  return 'E';
                    default:
                  return 'F';
                }
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max =Math.Max(this.Max, grade);
        }
    }
}
