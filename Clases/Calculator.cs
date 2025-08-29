// Compiler let's us use a class outside a namespace, but it is a bad practice in general
public static class StaticCalculator
{
  public static int Sum(int num1, int num2) => num1 + num2;

  public static int Rest(int num1, int num2) => num1 - num2;

  public static int Multiply(int num1, int num2) => num1 * num2;

  public static double Divide(double num1, double num2) => num1 / num2;
}

namespace Operations
{
  public class Calculator
  {
    public string Sum(int num1, int num2)
    {
      int res = num1 + num2;
      return OperationResult("suma", res);
    }

    public string Rest(int num1, int num2)
    {
      int res = num1 - num2;
      return OperationResult("resta", res);
    }

    public string Multiply(int num1, int num2)
    {
      int res = num1 * num2;
      return OperationResult("multiplicación", res);
    }

    public string Divide(double num1, double num2)
    {
      double res = num1 / num2;
      double remainder = num1 % num2;
      return OperationResult("", res, $"La division de los números {num1} y {num2} es {res} y sobra {remainder}");
    }

    private string OperationResult(string operationType, double result, string? customMessage = null)
    {
      return customMessage ?? $"El resultado de la operación {operationType} es {result}";
    }
  }
}
