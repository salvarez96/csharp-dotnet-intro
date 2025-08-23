string? nombre;
string? apellido;
byte edad;

Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine() ?? "";

Console.Write("Ingrese su apellido: ");
apellido = Console.ReadLine() ?? "";

Console.Write("Ingrese su edad: ");
byte.TryParse(Console.ReadLine(), out edad);

Console.WriteLine($"Mi nombre es {nombre} {apellido} y tengo {edad} años");
