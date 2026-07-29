Console.Write("Enter your grade:");
int grade = int.Parse(Console.ReadLine());

string result = (grade >= 50) ? "Passed": "Failed"
Console.WriteLine(result);
