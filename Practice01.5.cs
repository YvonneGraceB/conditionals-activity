Console.Write("Enter the radius: ");
double radius = double.Parse(Console.ReadLine());
Console.Write("Choose (A=Area, P=Perimeter, X=Exit): ");
char choice = char.ToUpper(Console.ReadLine()[0]);
switch (option)
{
     case 'A':
         double area = Math.PI * radius * radius;
         Console.WriteLine("Area: " + area);
         break;
     case 'P':
         double perimeter = 2 * Math.PI * radius;
         Console.WriteLine("Perimeter: " + perimeter);
         break;
     case 'X':
         Console.WriteLine("Exit");
         break;
}
