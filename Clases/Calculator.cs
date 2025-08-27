namespace Operations
{
  public class Calculator
  {
    public void Sum(int num1, int num2)
    {
      int res = num1 + num2;
      OperationResult("suma", res);
    }

    public void Rest(int num1, int num2)
    {
      int res = num1 - num2;
      OperationResult("resta", res);
    }

    public void Multiply(int num1, int num2)
    {
      int res = num1 * num2;
      OperationResult("multiplicación", res);
    }

    public void Divide(int num1, int num2)
    {
      int res = num1 / num2;
      int remainder = num1 % num2;
      OperationResult("", res, $"La division de los números {num1} y {num2} es {res} y sobra {remainder}");
    }

    private string OperationResult(string operationType, int result, string? customMessage = null)
    {
      return customMessage ?? $"El resultado de la operación {operationType} es {result}";
    }
  }
}
