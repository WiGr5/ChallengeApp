using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
   
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrade(int grade)
        {
           // float gradeint = grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {

                    writer.WriteLine(grade);

                }
                else
                {
                    throw new Exception("Poza zakresem 0-100");
                }
            }
        }

        public override void AddGrade(double grade)
        {
            //double gradedouble = (double)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {


                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.WriteLine(100);
                        break;
                    case 'B':
                    case 'b':
                        writer.WriteLine(80);
                        break;
                    case 'C':
                    case 'c':
                        writer.WriteLine(60);
                        break;
                    case 'D':
                    case 'd':
                        writer.WriteLine(40);
                        break;
                    case 'E':
                    case 'e':
                        writer.WriteLine(20);
                        break;
                    case 'F':
                    case 'f':
                        writer.WriteLine(0);
                        break;
                    case 'Q':
                    case 'q':
                        break;
                    default:
                        writer.WriteLine(0);

                        throw new Exception("Zła wartość znaku");
                }
            }
        }

        public override void AddGrade(string grade)
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

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var resulut = this.CoutStatistic(gradesFromFile);
            return resulut;
        }
        #region readFileGradesToList
        private List<float> ReadGradesFromFile()
        {
                var grades = new List<float>();
                if (File.Exists(fileName))
            { 
                    using (var reader = File.OpenText(fileName))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            {
                                var number = float.Parse(line);
                                grades.Add(number);
                                line = reader.ReadLine();
                            }
                        }
                    }
                }
                return grades; 
        }
        #endregion

        public Statistics CoutStatistic(List<float>grades)
        {

            var statistic = new Statistics();


           // if (grades == null!)
            {
                statistic.Max = float.MinValue;
                statistic.Min = float.MaxValue;



                foreach (var grade in grades)
                {
                    statistic.Max = Math.Max(statistic.Max, grade);
                    statistic.Min = Math.Min(statistic.Min, grade);
                    statistic.Average += grade;
                }

                statistic.Average /= grades.Count;

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
            return statistic;
        }
    }
}


