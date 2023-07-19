using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(5);
employee.AddGrade(4);
employee.AddGrade(3);
employee.AddGrade(6);

var statistic = employee.GetStatistics();
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Average: {statistic.Average:N2}");
