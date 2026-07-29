Console.Write("Enter your grade:");
int number = int.Parse(Console.ReadLine());

string result = (number >= 50) ? "Passed": "Failed"
Console.WriteLine(result);
