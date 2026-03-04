//set operator
Console.WriteLine("This calculator can perform 4 operations: addition, subtraction, multiplication, and division.");
Console.WriteLine("What operation would you like to perform?");
string operation = Console.ReadLine();

//incorrect submission
if (!(operation == "addition" || operation == "subtraction" || operation == "multiplication" || operation == "division"))
{
    Console.WriteLine("I dont know how to do that");
    return;
}

//set numbers
Console.WriteLine("What is your first number?");
int a =  int.Parse(Console.ReadLine());

Console.WriteLine("What is your second number?");
int b = int.Parse(Console.ReadLine());

//divide by zero
if (operation == "division" && b == 0)
{
    Console.WriteLine("You cannot divide by zero");
    return;
}

//calculations
if (operation == "addition")
{
    Console.WriteLine(a + " + " + b + " = " + (a + b));
}
else if (operation == "subtraction")
{
    Console.WriteLine(a + " - " + b + " = " + (a - b));
}
else if (operation == "multiplication")
{
    Console.WriteLine(a + " * " + b + " = " + (a * b));
}
else if (operation == "division")
{
    Console.WriteLine(a + " / " + b + " = " + (a / b));
}