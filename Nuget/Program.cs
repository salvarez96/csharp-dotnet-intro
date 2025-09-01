using Newtonsoft.Json;

public class Person
{
  public required string Name { get; set; }
  public required int Age { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person person = new Person
    {
      Name = "Santiago",
      Age = 29
    };

    string json = JsonConvert.SerializeObject(person);
    Console.WriteLine($"Serialized JSON: {json}");

    Person deserializedPerson = JsonConvert.DeserializeObject<Person>(json)!;
    Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
  }
}
