int counter = 10;

for (int i = 0; i < counter; i++)
{
  Console.WriteLine($"Contador for: {i}");
}

while (counter > 0)
{
  Console.WriteLine($"Contador while: {counter}");
  counter--;
}

do
{
  counter++;
  Console.WriteLine($"Contador do-while: {counter}");
} while (counter < 10);
