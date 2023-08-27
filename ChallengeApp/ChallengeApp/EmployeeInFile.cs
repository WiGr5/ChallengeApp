namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        private List<float> grades = new List<float>();


        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrade(int grade)
        {
            float gradeint = grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(gradeint);
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.Write(grade);
                }
            }
            else
            {
                throw new Exception("Poza zakresem 0-100");
            }
                   }

        public override void AddGrade(double grade)
        {
            double gradedouble=(double)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(gradedouble);
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
                        writer.Write(100);
                         break;
                    case 'B':
                    case 'b':
                        writer.Write(80);
                        break;
                    case 'C':
                    case 'c':
                        writer.Write(60);
                        break;
                    case 'D':
                    case 'd':
                        writer.Write(40);
                        break;
                    case 'E':
                    case 'e':
                        writer.Write(20);
                        break;
                    case 'F':
                    case 'f':
                        writer.Write(0);
                        break;
                    case 'Q':
                    case 'q':
                        break;
                    default:
                        writer.Write(0);

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
            var statistic =new Statistics();
            statistic.Max= float.MaxValue;
            statistic.Min= float.MinValue;
            statistic.Average = 0;

            if (File.Exists(fileName))
            {
               // var result = new Statistics();
                using (var reader = File.OpenText(fileName))

                {
                    
                    var line = reader.ReadLine();
                    var lineNum = 0;
                    while (line != null)
                    {
                        lineNum++;
                        if
                        {
                            var number = float.Parse(line);
                            // number
                        }
                    }
                }
            }


            return statistics;

        }
    }
}
