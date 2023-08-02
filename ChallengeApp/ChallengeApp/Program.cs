using ChallengeApp;

var employee = new Employee();
Console.WriteLine("Welkome in program statistic emploers");
Console.WriteLine("=====================================");
Console.WriteLine("Wprowadz ocene wartościową lub literową ");
Console.WriteLine("Ocena wartosciowa: 0 - 100");
Console.WriteLine("Ocena liteowa: A-100, B-80, C-60, D-40, E-20, F-0.");

<<<<<<< HEAD
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
        employee.AddGrade(input);
    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Catch Exception: {ex.Message}");
    }

}
var statistic = employee.GetStatistics();
Console.WriteLine($"Najniższ ocena pracownika: {statistic.Min}");
Console.WriteLine($"Najwyższa ocena pracownika: {statistic.Max}");
Console.WriteLine($"Pracownik otrzymał srednią ilosc {statistic.Average:N2} punktów i otrzymuje ocene: {statistic.AverageLetter}");
=======

var statistic = employee.GetStatistics();
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Average: {statistic.Average:N2}");
>>>>>>> parent of 405dff7 (GetStatistics Foreach For DoWhile Wchile)
