using ChallengeApp;

var supervisor = new Supervisor();
//var employee = new Employee("Adam","Adam");
Console.WriteLine("Welkome in program statistic Supervisior");
Console.WriteLine("=====================================");
//Console.WriteLine("Wprowadz ocene wartościową lub literową ");
//Console.WriteLine("Ocena wartosciowa: 0 - 100");
//Console.WriteLine("Ocena liteowa: A-100, B-80, C-60, D-40, E-20, F-0.");
Console.WriteLine("Wprowadz ocenę 1 - 6 i +/-  ");

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("Podaj ocene pracownika");
    Console.WriteLine("w Celu wyjscia z dodawania ocen wciścnij: Q ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Catch Exception: {ex.Message}");
    }

}
var statistic = supervisor.GetStatistics();
Console.WriteLine($"Najniższ ocena pracownika: {statistic.Min}");
Console.WriteLine($"Najwyższa ocena pracownika: {statistic.Max}");
Console.WriteLine($"Pracownik otrzymał srednią ilosc {statistic.Average:N2} punktów i otrzymuje ocene: {statistic.AverageLetter}");