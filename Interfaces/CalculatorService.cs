using IOperations;

namespace Operations
{
  public class CalculatorService : ICalculatorService
  {
    public double Add(double x, double y) => x + y;
    public double Subtract(double x, double y)
    {
      Console.Write("Subtraction: ");
      return x - y;
    }
    public double Multiply(double x, double y)
    {
      double result = x * y;
      return result;
    }
    public double Divide(double x, double y)
    {
      if (y == 0)
      {
        Console.WriteLine($"Error when dividing: {new DivideByZeroException().Message}");
        return 0;
      }
      return x / y;
    }
  }
}
