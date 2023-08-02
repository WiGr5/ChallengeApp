using System.ComponentModel.Design;
using System.Data;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee()
        {

        }

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
                throw new Exception("Poza zakresem 0-100");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charresult))
            {
                this.AddGrade(charresult);
            }
            //else if (true)
            else
            {
                throw new Exception("Zła wartość oceny");
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
        public void AddGrade(char grade)

<<<<<<< HEAD
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                case 'F':
                case 'f':
                    this.grades.Add(0);
                    break;
                case 'Q':
                case 'q':
                    break;
                default:
                    throw new Exception("Zła wartość znaku");
            }
        }
        public Statistics GetStatistics()
=======
            public Statistics GetStatistics()
>>>>>>> parent of 405dff7 (GetStatistics Foreach For DoWhile Wchile)
        {

            var statistic = new Statistics();
<<<<<<< HEAD
            if (this.grades == null!)
=======

            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
>>>>>>> parent of 405dff7 (GetStatistics Foreach For DoWhile Wchile)
            {
                statistic.Max = float.MinValue;
                statistic.Min = float.MaxValue;



                foreach (var grade in this.grades)
                {
                    statistic.Max = Math.Max(statistic.Max, grade);
                    statistic.Min = Math.Min(statistic.Min, grade);
                    statistic.Average += grade;
                }

                statistic.Average /= this.grades.Count;

                switch (statistic.Average)
                {
                    case var a when a == 100:
                        statistic.AverageLetter = 'A'; break;
                    case var a when a >= 80:
                        statistic.AverageLetter = 'B'; break;
                    case var a when a >= 60:
                        statistic.AverageLetter = 'C'; break;
                    case var a when a >= 40:
                        statistic.AverageLetter = 'D'; break;
                    case var a when a >= 20:
                        statistic.AverageLetter = 'E'; break;
                    default:
                        statistic.AverageLetter = 'F'; break;

                }
            }
<<<<<<< HEAD
=======

            statistic.Average /= this.grades.Count;
>>>>>>> parent of 405dff7 (GetStatistics Foreach For DoWhile Wchile)
            return statistic;
        }
    }
}

