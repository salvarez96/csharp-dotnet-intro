Console.WriteLine("Hello, World!");

byte edad = 0;

Console.Write("Introduce tu edad");
byte.TryParse(Console.ReadLine(), out edad);

if (edad >= 18)
  Console.WriteLine("Eres mayor de edad");
else if (edad == 18)
  Console.WriteLine("Tienes 18 años");
else
  Console.WriteLine("Eres menor de edad");
