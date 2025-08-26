Console.WriteLine("Hello, World!");
Console.Write("Introduce el primer número: ");
int num1;
int.TryParse(Console.ReadLine(), out num1);

Console.Write("Introduce el segundo número: ");
int num2;
int.TryParse(Console.ReadLine(), out num2);


// void method:
static void sum(int num1, int num2)
{
  int res = num1 + num2;
  Console.WriteLine($"La suma de los números {num1} y {num2} de void sum es {res}");
}

sum(num1, num2);

// return method:
static int refSum(int num1, int num2)
{
  int res = num1 + num2;
  return res;
}

Console.WriteLine($"La suma de los números {num1} y {num2} de refSum es {refSum(10, 20)}");

// out method:
static void outSum(int num1, int num2, out int res)
{
  res = num1 + num2;
}

outSum(num1, num2, out int result);
Console.WriteLine($"La suma de los números {num1} y {num2} de outSum es {result}");

// ref method:
static void res(int num1, int num2, ref int res)
{
  res = num1 - num2;
}

res(num1, num2, ref result);
Console.WriteLine($"La resta de los números {num1} y {num2} de res es {result}");

// tuples method
static (float divisionResult, float remainder) divide(float divident, float divisor)
{
  if (divisor == 0)
  {
    Console.WriteLine("No se puede dividir por 0");
    return (0, 0);
  }
  float divisionResult = divident / divisor;
  float remainder = divident % divisor;

  return (divisionResult, remainder);
}

(float divisionResult, float remainder) = divide(num1, num2);
Console.WriteLine($"La division de los números {num1} y {num2} de divide es {divisionResult} y sobra {remainder}");

// params method
static int sumParams(params int[] numbers)
{
  int sum = 0;
  foreach (int num in numbers)
  {
    sum += num;
  }
  return sum;
}

int sumParamsResult = sumParams(1, 2, 3, 4, 5);

Console.WriteLine($"La suma de los números 1, 2, 3, 4, 5 de sumParams es {sumParamsResult}");
