namespace ChallengeApp
{
    public class Employe
    {
        List<int> score = new List<int>();
        public Employe(string name, string surname, int age, int score)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }

        public int ResultScore
        {
            get
            {
                return this.score.Sum();
            }
        }

    }
}
