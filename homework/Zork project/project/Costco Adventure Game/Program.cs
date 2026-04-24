string firstLine;
bool isCorrectFilePath = false;
while (!isCorrectFilePath) {
    Console.WriteLine("What is the file path");
    string filePath = Console.ReadLine(); 
    try
    {
        StreamReader reader = new StreamReader(filePath);
        isCorrectFilePath = true;

        //string firstLine; or reader.Close()??
    }
    catch
    {
        Console.WriteLine("Thats not right");
    }
}
void print(string msg)
{
    for (int i = 0; i < msg.Length; i++)
    {
        Console.Write(msg[i]);
        Thread.Sleep(30);
    }
    Console.WriteLine();
}
string simplify(string s)
{
    s = s.Replace(" ", "");
    s = s.ToUpper();
    return s;
}
print("Type \"STOP\" at anytime to end the game");
print("Welcome to Costco!");
print("After finding a parking spot, you make your way towards " +
      "the snack bar and the front of the store.");

string response = "";
while (true)
{
    response = simplify(Console.ReadLine());
    if (response == "STOP")
    {
        break;
    }
    else if (response.Contains("SNACK") || response.Contains("BAR") ||
        response.Contains("EAT") || response.Contains("HUNGRY"))
    {
        snackBar();
    }

    else if (response.Contains("STORE") || response.Contains("INSIDE")
                                   || response.Contains("SHOP"))
    {
        goInside();
    }
    else
    {
        print("I don't know what you mean");
    }
}

void snackBar()
{
    while (true)
    {
        print("You go to the snack bar. You're deciding between " +
              "a slice of pizza or a hot dog");
        response = simplify(Console.ReadLine());
        if (response == "STOP")
        {
            break;
        }
        else if (response.Contains("SLICE") || response.Contains("PIZZA"))
        {
            pizza();
        }
        else if (response.Contains("DOG"))
        {
            hotDog();
        }
        else
        {
            print("I don't know what you mean");
        }
    }
}

void goInside()
{
    print("You walk Inside. Do you head for the Freezer Section or the Snack Section?");
    while (true)
    {
        print("You go to the snack bar. You're deciding between " +
              "a slice of pizza or a hot dog");
        response = simplify(Console.ReadLine());
        if (response == "STOP")
        {
            break;
        }
        else if (response.Contains("FREEZE"))
        {
            freezerSection();
        }
        else if (response.Contains("SNACK"))
        {
            snackSection();
        }
        else
        {
            print("I don't know what you mean");
        }
    }
}

void pizza()
{
    print("You buy a slice and recieve your pizza, but when you eat it, you spill sauce on your shirt");
    while (true)
    {
        response = simplify(Console.ReadLine());
        if (response == "STOP")
        {
            break;
        }
        else if (response.Contains("NEWSHIRT") || response.Contains("OTHERSHIRT"))
        {
            newShirt();
        }
        else if (response.Contains("CLEAN") || response.Contains("STAINREMOVER"))
        {
            stainRemover();
        }
        {}
    }        
}

void hotDog()
{
    print("hotdog");
}

void freezerSection()
{
    print("freezer section");
}

void snackSection()
{
    print("snack section");
}

void newShirt()
{
    print("new shirt");
}

void stainRemover()
{
    print("stain remover");
}



