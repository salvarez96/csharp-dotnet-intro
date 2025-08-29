using Operations;

Calculator calculator = new();
Console.WriteLine(calculator.Sum(1, 2));
Console.WriteLine(calculator.Rest(1, 2));
Console.WriteLine(calculator.Multiply(1, 2));
Console.WriteLine(calculator.Divide(1, 2));

Console.WriteLine($"Using static calculator to sum: {StaticCalculator.Sum(1, 2)}");
Console.WriteLine($"Using static calculator to rest: {StaticCalculator.Rest(1, 2)}");
Console.WriteLine($"Using static calculator to multiply: {StaticCalculator.Multiply(1, 2)}");
Console.WriteLine($"Using static calculator to divide: {StaticCalculator.Divide(1, 2)}");
