namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(int grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());  
                }
            }
            else
            {
                throw new Exception("Poza zakresem 0-100");
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
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
            if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
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

            var statistic = new Statistics();
            foreach (var grade in this.grades)
            {
                statistic.AddGrade(grade);
            }
            return statistic;
        }
    }
}

