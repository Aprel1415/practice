string password = "213ab321";
string clientsName = "Artemy";
Console.WriteLine("Hello, sir! Please, input your password here:");
int maxAttempts = 3;
int firstMistake = 2;
for (int attempt = 0; attempt < maxAttempts; attempt++)
{
    string passwordNV = Console.ReadLine();
    if (passwordNV == password)
    {
        Console.WriteLine($"Welcome back, {clientsName}!");
        break;
    }
    else
    {
        int triesLeft = firstMistake - attempt;
        Console.WriteLine($"Error! Try again! {triesLeft} tries left!");
        if (attempt == maxAttempts -1)
        {
            Console.WriteLine("Access denied! No more attempts.");
        }
    }
}