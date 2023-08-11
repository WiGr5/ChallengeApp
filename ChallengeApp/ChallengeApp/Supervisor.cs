

namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

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

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {


            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "5+":
                case "+5":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "5-":
                case "-5":
                    this.grades.Add(75);
                    break;
                case "4+":
                case "+4":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "4-":
                case "-4":
                    this.grades.Add(55);
                    break;
                case "3+":
                case "+3":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "3-":
                case "-3":
                    this.grades.Add(35);
                    break;
                case "2+":
                case "+2":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "2-":
                case "-2":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Zła wartość znaku xxxxx");
            }

        }



        public Statistics GetStatistics()
        {
            var statistic = new Statistics();
            // if (this.grades == null!)
            //{
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
                    statistic.AverageLetter = '6'; break;
                case var a when a >= 80:
                    statistic.AverageLetter = '5'; break;
                case var a when a >= 60:
                    statistic.AverageLetter = '4'; break;
                case var a when a >= 40:
                    statistic.AverageLetter = '3'; break;
                case var a when a >= 20:
                    statistic.AverageLetter = '2'; break;
                default:
                    statistic.AverageLetter = '1'; break;

            }
            //}
            return statistic;
        }
    }
}
