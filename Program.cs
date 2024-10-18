do
{
    Console.WriteLine("Enter the first number: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number (or zero if not needed): ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Select an operation:");
    Console.WriteLine("1. Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Exponentation (first number ^ second number)\n6.Square Root of first number\n7.Absolute value of first number");
    Console.WriteLine("Enter your choice (1-7): ");
    int choice = int.Parse(Console.ReadLine());
    int result = 0;
    switch (choice)
    {
        case 1:
            result = a + b;
            break;
        case 2:
            result = a - b;
            break;
        case 3:
            result = a * b;
            break;
        case 4:
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                break;
            }
            result = a / b;
            break;
        case 5:
            result = (int) Math.Pow(a, b);
            break;
        case 6:
            result = (int)Math.Sqrt(a);
            break;
        case 7:
            result = Math.Abs(a);
            break;
    }
    Console.WriteLine($"Result: {result}");
    Console.WriteLine("Do you want to perform another calculation? (yes/no)");
    string cont = Console.ReadLine();
    if(cont == "no")
    {
        break;
    };
} while (true);