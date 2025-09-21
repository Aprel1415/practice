using practice;

Console.WriteLine("Please, input your name here: ");
string? name = Console.ReadLine();
Console.WriteLine("Please, input your age here: ");
string? ageInt = Console.ReadLine();
int.TryParse(ageInt, out int age);
Person artemy = new Person(name ?? "Unknown", age);
Console.WriteLine(artemy);