//loop 1
int i = 1;
while (i <= 5)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();

//loop 2
i = 100;
while (i <= 150)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();

//loop 3
i = 0;
while (i <= 100)
{
    Console.Write(i + " ");
    i += 2;
}
Console.WriteLine();

//loop 4
i = 20;
while (i >= -20)
{
    Console.Write(i + " ");
    i--;
}
Console.WriteLine();

//loop 5
i = 1;
while (i <= 100)
{
    Console.Write(i + " ");
    i += 3;
}
Console.WriteLine();

//loop 6
i = 1;
while (i <= 1024)
{
    Console.Write(i + " ");
    i *= 2;
}
Console.WriteLine();

//loop 7
string answer = "No";
while (answer != "Yes")
{
    Console.WriteLine("Do you want the loop to stop?");
    answer = Console.ReadLine();
}

//loop 8
bool b = true;
i = 10;
while (i >= 1)
{
    Console.Write(b);
    if (b)
    {
        b = false;
    }
    else
    {
        b = true;
    }
    i--;
}

//loop 9
i = 1;
while (i <= 20)
{
    Console.Write(i);
    if (i % 2 == 0)
    {
        Console.WriteLine(" is even");
    }
    else
    {
        Console.WriteLine(" is odd");
    }
    i++;
}

//loop 10
i = 0;
string[] arr = new string[5];
arr = ["once", "upon", "a", "midnight", "dreary"];
while (i <= 4)
{
    Console.Write(arr[i] + " ");
    i++;
}
Console.WriteLine();