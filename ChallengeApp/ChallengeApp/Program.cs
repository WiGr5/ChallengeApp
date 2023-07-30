using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(5);
employee.AddGrade(4);
employee.AddGrade(3000);
employee.AddGrade("10");
employee.AddGrade("Adam");
employee.AddGrade(11);
employee.AddGrade(12l);

var statistic = employee.GetStatistics();
Console.WriteLine("GetStatisticsForeach");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Average: {statistic.Average:N2}");

var statistic1 = employee.GetStatisticsFor();
Console.WriteLine("GetStatisticsFor");
Console.WriteLine($"Min: {statistic1.Min}");
Console.WriteLine($"Max: {statistic1.Max}");
Console.WriteLine($"Average: {statistic1.Average:N2}");

var statistic2 = employee.GetStatisticsDoWhile();
Console.WriteLine("GetStatisticsDoWhile");
Console.WriteLine($"Min: {statistic2.Min}");
Console.WriteLine($"Max: {statistic2.Max}");
Console.WriteLine($"Average: {statistic2.Average:N2}");

var statistic3 = employee.GetStatisticsWhile();
Console.WriteLine("GetStatisticsWhile");
Console.WriteLine($"Min: {statistic3.Min}");
Console.WriteLine($"Max: {statistic3.Max}");
Console.WriteLine($"Average: {statistic3.Average:N2}");
