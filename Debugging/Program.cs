List<string> names = new();

names.Add("Santiago");
names.Add("Felipe");
names.Add("Carlos");

List<string> surnames = new();

surnames.Add("Alvarez");
surnames.Add("Gomez");
surnames.Add("Perez");

names.ForEach(name =>
{
  surnames.ForEach(surname =>
  {
    Console.WriteLine($"{name} {surname}");
  });
});
