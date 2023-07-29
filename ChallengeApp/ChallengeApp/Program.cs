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
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Average: {statistic.Average:N2}");
