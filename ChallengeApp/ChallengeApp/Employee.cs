using System.ComponentModel.Design;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Grdes is over values 0-100");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(int grade)
        {
            float result = grade;
            this.AddGrade(result);
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public Statistics GetStatistics()
        {
            var statistic = new Statistics();

            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticsForeach()
        {
            var statistic = new Statistics();

            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticsFor()
        {
            var statistic = new Statistics();

            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            Console.WriteLine(this.grades.Count.ToString());
            for (int i = 0; i < this.grades.Count; i++)
            {
                float grade = this.grades[i];
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticsDoWhile()
        {
            int i = this.grades.Count - 1;
            var statistic = new Statistics();
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            do
            {
                
                float grade = this.grades[i];
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
                i--;
            }
            while (i > -1);
            
            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticsWhile()
        {
            int i = this.grades.Count;
            var statistic = new Statistics();
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            i--;
            while(i > -1)
            {
                float grade = this.grades[i];
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
                i--;
            }
            
            statistic.Average /= this.grades.Count;
            return statistic;
        }
    }
}
