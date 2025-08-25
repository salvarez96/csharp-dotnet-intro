string name1 = "Santiago";
string name2 = "Felipe";
string name3 = "Carlos";

string[] names = new string[4];

names[0] = name1;
names[1] = name2;
names[2] = name3;
names[3] = "Andres";

Console.WriteLine("Names array with normal foreach loop:");

void printName(string name)
{
  if (name == names[^1])
  {
    Console.Write($"{name};");
    Console.WriteLine();
  }
  else
  {
    Console.Write($"{name}, ");
  }
}

foreach (string name in names)
{
  printName(name);
}


Console.WriteLine("Names array with Linq foreach loop:");

names.ToList().ForEach(name => printName(name));

List<string> namesList = new List<string>();

namesList.Add(name1);
namesList.Add(name2);
namesList.Add(name3);
namesList.Add("Andres");

Console.WriteLine("Names list with Linq foreach loop:");
namesList.ForEach(name => printName(name));
