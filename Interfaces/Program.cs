using Operations;

CalculatorService calculatorService = new();
Console.WriteLine($"Addition: {calculatorService.Add(2, 3)}");
double substractResult = calculatorService.Subtract(2, 3);
Console.WriteLine(substractResult);
Console.WriteLine($"Multiplication: {calculatorService.Multiply(2, 3)}");
Console.WriteLine($"Division: {calculatorService.Divide(2, 0)}");
