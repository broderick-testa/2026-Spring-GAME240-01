Console.WriteLine("This calculator can perform 5 operations: " +
                  "addition (+), subtraction (-), multiplication (*), " +
                  "and division(/).");
string userInput = "";

while (userInput != "quit")
{
    Console.WriteLine("Please type a mathematical expression, or " +
                      "type \"quit\" to shut down the calculator.\n\n");
    userInput = Console.ReadLine();
    
    bool isValid = true;
    foreach (char c in userInput)
    {
        if (c == '+' || c == '-' || c == '*' || c == '/')
        {
            isValid = false;
        } 
    }

    if (!isValid)
    {
        Console.WriteLine("Invalid input");
        break;
    }
    else
    {

        userInput = userInput.Trim();
        string firstNum = "";
        string symbol = "";
        string secondNum = "";

        for (int i = 0; i < userInput.Length; i++)
        {
            if (userInput[i] == '+' || userInput[i] == '-' ||
                userInput[i] == '*' || userInput[i] == '/' ||
                userInput[i] == ' ')
            {
                firstNum = userInput.Substring(0, i);
                secondNum = userInput.Substring(i, userInput.Length - i);
                break;
            }
        }

        for (int i = secondNum.Length - 1; i >= 0; i--)
        {
            if (secondNum[i] == '+' || secondNum[i] == '-' ||
                secondNum[i] == '*' || secondNum[i] == '/' ||
                secondNum[i] == ' ')
            {
                secondNum = secondNum.Substring(i + 1, secondNum.Length - i - 1);
                break;
            }
        }

        for (int i = 0; i < userInput.Length; i++)
        {
            if (userInput[i] == '+' || userInput[i] == '-' || userInput[i] == '*' || userInput[i] == '/')
            {
                symbol = userInput.Substring(i, 1);
            }
        }

        //Console.WriteLine("\'" + firstNum + "\'" + " and " + "\'" + secondNum + "\'");
        //Console.WriteLine("operator \'" + symbol + "\'");

        double fN = int.Parse(firstNum) * 1.0;
        double sN = int.Parse(secondNum) * 1.0;

        if (symbol == "+")
        {
            Console.WriteLine(fN + " + " + sN + " = " + (fN + sN));
        }

        else if (symbol == "-")
        {
            Console.WriteLine(fN + " - " + sN + " = " + (fN - sN));
        }

        else if (symbol == "*")
        {
            Console.WriteLine(fN + " * " + sN + " = " + (fN * sN));
        }
        else if (symbol == "/")
        {
            Console.WriteLine(fN + " / " + sN + " = " + (fN / sN));
        }
        else
        {
            Console.WriteLine("Sorry! I dont know how to do that");
        }
    }
}