using ChallengeApp;

var employee = new EmployeeInFile("x", "y");
//var employee = new EmployeeInMemory("x", "y");
Console.WriteLine("Welkome in program statistic emploers");
Console.WriteLine("=====================================");
Console.WriteLine("Wprowadz ocene wartościową lub literową\n");
Console.WriteLine("Ocena wartosciowa: 0 - 100");
Console.WriteLine("Ocena liteowa: A-100, B-80, C-60, D-40, E-20, F-0.");

employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocene");
}

while (true)
{
    Console.WriteLine("\n Podaj ocene pracownika");
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
    catch (Exception ex)
    {
        Console.WriteLine($"Catch Exception: {ex.Message}");
    }
}

var statistic = employee.GetStatistics();
Console.WriteLine($"Najniższa ocena pracownika: {statistic.Min}");
Console.WriteLine($"Najwyższa ocena pracownika: {statistic.Max}");
Console.WriteLine($"Ilośc ocen: {statistic.Count}");
Console.WriteLine($"Suma ocen: {statistic.Sum}\n");
Console.WriteLine($"Średnia ilość punktów pracownika wynosi: {statistic.Average:N2} \nPracownik Otrzymuje ocene: {statistic.AverageLetter}");