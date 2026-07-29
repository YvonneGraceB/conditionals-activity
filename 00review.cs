Practice 00.1
  For double, make a program that asks for the radius of a circle, calculates the area using the formula area = π × radius × radius, and outputs the area.

    double radius = Convert.ToDouble (Coscole.ReadLine());
    double area = Math.PI × radius;
    Console.WriteLine(&"area: {area}");

  For string, write a program that promps the user for their first and last name, combines them into a full name, and displays it.

    Console.WriteLine("STRING NAME");
    Console.Write ("Enter first name: ");
    string firstName = Console.ReadLine(; Console.Write("Enter last name: "); 
    string lastName = Console.ReadLine();
    string fullName = firstName + " " + lastName;
    Console.WriteLine("Full Name: " + fullName);

               
Practice 00.2
               1. A bank offers a savings account that earns simple interest annually. Write a C# program that will help a user calculate the simple interest they will earn based on the principal amount, the annual interest rate, and the time in years. The program should prompt the user to enter the principal amount they deposited, the annual rate of interest in percentage, and the number of years the money will be invested. It should then compute the simple interest using the formula Interest = (Principal x Rate x Time) / 100 and display the computed interest to the user.
Sample output:
Enter Principal amount: 5000
Enter Rate of interest (%): 5
Enter Time (in years): 3
Simple Interest: 750

        Console.WriteLine("SAVINGS ACCOUNT");
        Console.WriteLine("Enter amount: ");
        Console.WriteLine();
        Console.Write("Enter the principal amount deposited: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the annual interest rate (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the number of years invested: ");
        double time = Convert.ToDouble(Console.ReadLine());
        double interest = (principal * rate * time) / 100;
        Console.WriteLine();
        Console.WriteLine($"Computed Simple Interest Earned: {interest:F2}");
            
     

                                        
  
