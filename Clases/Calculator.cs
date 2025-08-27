namespace Operations
{
  public class Calculator
  {
    public void Sum(int num1, int num2)
    {
      int res = num1 + num2;
      Console.WriteLine($"La suma de los números {num1} y {num2} de sum es {res}");
    }

    public void Rest(int num1, int num2)
    {
      int res = num1 - num2;
      Console.WriteLine($"La resta de los números {num1} y {num2} de rest es {res}");
    }

    public void Multiply(int num1, int num2)
    {
      int res = num1 * num2;
      Console.WriteLine($"La multiplicación de los números {num1} y {num2} de multiply es {res}");
    }

    public void Divide(int num1, int num2)
    {
      int res = num1 / num2;
      int remainder = num1 % num2;
      Console.WriteLine($"La division de los números {num1} y {num2} de divide es {res} y sobra {remainder}");
    }
  }
}
