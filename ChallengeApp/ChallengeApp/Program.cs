using ChallengeApp;

Employe employe1 = new Employe("Wioletta",      "Kowalska",  26, 0);
Employe employe2 = new Employe("Grzegoz",       "Kowalski",  34, 0);
Employe employe3 = new Employe("Adam",          "Malinowski",32, 0);
Employe employe4 = new Employe("Aleksandra",    "Rojek",     41, 0);
Employe employe5 = new Employe("Roman",         "Zielinski", 35, 0);

employe1.AddScore(2); employe1.AddScore(5); employe1.AddScore(3); employe1.AddScore(6); employe1.AddScore(1);
employe2.AddScore(8); employe2.AddScore(5); employe2.AddScore(6); employe2.AddScore(4); employe2.AddScore(2);
employe3.AddScore(2); employe3.AddScore(6); employe3.AddScore(4); employe3.AddScore(3); employe3.AddScore(5);
employe4.AddScore(5); employe4.AddScore(2); employe4.AddScore(3); employe4.AddScore(4); employe4.AddScore(3);
employe5.AddScore(3); employe5.AddScore(4); employe5.AddScore(1); employe5.AddScore(3); employe5.AddScore(2);

List<Employe> employes = new List<Employe>()
{
employe1, employe2, employe3, employe4, employe5
};

Employe employeBestScore = null;
int employeScore = 0;

foreach (Employe employe in employes)
{
    if (employe.ResultScore > employeScore)
    {
        employeBestScore = employe;
        employeScore= employe.ResultScore;
    }
}
Console.WriteLine($" Pracownik {employeBestScore.Name} {employeBestScore.Surname} w wieku {employeBestScore.Age} lat zdobył {employeScore} punków gratulujemy");