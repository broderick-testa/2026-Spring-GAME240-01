class Costco
{
    enum Room
    {
        Entrance,
        Technology,
        Clothing,
        Freezer,
        Chicken,
        Bakery,
        Checkout,
        Exit,
        SnackBar
    }

    static Room currentRoom = Room.Entrance;

    static bool hasPizza = false;
    static bool hasChicken = false;
    static bool hasBagels = false;
    static bool checkedOut = false;

    static string input = "";

    // TYPEWRITER EFFECT
    static void type(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        type("Welcome to Costco Adventure!");

        type("You have 5 commands: " + '\"' + "Move" + '\"' +
             ", " + '\"' + "Take" + '\"' +
             ", " + '\"' + "Use" + '\"' +
             ", " + '\"' + "Check Inventory" + '\"' +
             ", and " + '\"' + "Read Shopping List" + '\"');

        while (currentRoom != Room.Exit)
        {
            if (currentRoom == Room.Entrance)
                type("\nYou are at the Entrance.");

            else if (currentRoom == Room.Freezer)
                type("\nYou are in the Walk-in Freezer.");

            else if (currentRoom == Room.SnackBar)
                type("\nYou are at the Snack Bar.");

            else if (currentRoom == Room.Chicken)
                type("\nYou are in the Rotisserie Chicken Section.");

            else if (currentRoom == Room.Technology)
                type("\nYou are in the Technology Section.");

            else if (currentRoom == Room.Clothing)
                type("\nYou are in the Clothing Section.");

            else if (currentRoom == Room.Bakery)
                type("\nYou are in the Bakery.");

            else if (currentRoom == Room.Checkout)
                type("\nYou are at Checkout.");
            Console.Write("> ");

            input = Console.ReadLine().ToUpper();

            // ASK FOR DIRECTION
            if (input.Contains("MOVE"))
            {
                while (!(input.Contains("NORTH") ^
                         input.Contains("SOUTH") ^
                         input.Contains("EAST") ^
                         input.Contains("WEST")))
                {
                    type("Which direction? North, South, East, or West?");
                    type("> ");
                    input = input + Console.ReadLine().ToUpper();
                }
            }

            // ===== GENERAL COMMANDS =====

            if (input.Contains("READ") || input.Contains("LIST"))
            {
                type("Shopping List:");
                type("- Frozen Pizza");
                type("- Rotisserie Chicken");
                type("- Bagels");
                continue;
            }

            if (input.Contains("INVENTORY"))
            {
                type("Inventory:");
                type("- Wallet");
                type("- Shopping List");
                if (hasPizza) type("- Frozen Pizza");
                if (hasChicken) type("- Chicken");
                if (hasBagels) type("- Bagels");

                continue;
            }

            switch (currentRoom)
            {
                // ================= ENTRANCE =================
                case Room.Entrance:

                    if (input.Contains("MOVE") && input.Contains("NORTH"))
                        currentRoom = Room.Technology;

                    else if (input.Contains("MOVE") && input.Contains("WEST"))
                        currentRoom = Room.SnackBar;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= SNACK BAR =================
                case Room.SnackBar:

                    if (input.Contains("MOVE") && input.Contains("EAST"))
                        currentRoom = Room.Entrance;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= TECHNOLOGY =================
                case Room.Technology:

                    if (input.Contains("MOVE") && input.Contains("NORTH"))
                        currentRoom = Room.Chicken;

                    else if (input.Contains("MOVE") && input.Contains("WEST"))
                        currentRoom = Room.Clothing;

                    else if (input.Contains("MOVE") && input.Contains("EAST"))
                        currentRoom = Room.Checkout;

                    else if (input.Contains("MOVE") && input.Contains("SOUTH"))
                        currentRoom = Room.Entrance;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= CLOTHING =================
                case Room.Clothing:

                    if (input.Contains("MOVE") && input.Contains("NORTH"))
                        currentRoom = Room.Freezer;

                    else if (input.Contains("MOVE") && input.Contains("EAST"))
                        currentRoom = Room.Technology;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= FREEZER =================
                case Room.Freezer:

                    if (input.Contains("TAKE"))
                    {
                        while (!(input.Contains("PIZZA")))
                        {
                            input = "TAKE";
                            type("What would you like to take?");
                            Console.Write("> ");
                            input = input + Console.ReadLine().ToUpper();
                        }
                        if (!hasPizza)
                        {
                            hasPizza = true;
                            type("You took frozen pizza.");
                        }
                        else
                        {
                            type("There's nothing for you to take here.");
                        }
                    }

                    else if (input.Contains("MOVE") && input.Contains("EAST"))
                        currentRoom = Room.Chicken;

                    else if (input.Contains("MOVE") && input.Contains("SOUTH"))
                        currentRoom = Room.Clothing;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= CHICKEN =================
                case Room.Chicken:

                    if (input.Contains("TAKE"))
                    {
                        while (!(input.Contains("CHICKEN")))
                        {
                            input = "TAKE";
                            type("What would you like to take?");
                            Console.Write("> ");
                            input = input + Console.ReadLine().ToUpper();
                        }
                        if (!hasChicken)
                        {
                            hasChicken = true;
                            type("You took rotisserie chicken.");
                        }
                        else
                        {
                            type("There's nothing for you to take here.");
                        }
                    }

                    else if (input.Contains("MOVE") && input.Contains("EAST"))
                        currentRoom = Room.Bakery;

                    else if (input.Contains("MOVE") && input.Contains("SOUTH"))
                        currentRoom = Room.Technology;

                    else if (input.Contains("MOVE") && input.Contains("WEST"))
                        currentRoom = Room.Freezer;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= BAKERY =================
                case Room.Bakery:

                    if (input.Contains("TAKE"))
                    {
                        while (!(input.Contains("BAGEL")))
                        {
                            input = "TAKE";
                            type("What would you like to take?");
                            Console.Write("> ");
                            input = input + Console.ReadLine().ToUpper();
                        }
                        if (!hasBagels)
                        {
                            hasBagels = true;
                            type("You took bagels.");
                        }
                        else
                        {
                            type("There's nothing for you to take here.");
                        }
                    }

                    else if (input.Contains("MOVE") && input.Contains("SOUTH"))
                        currentRoom = Room.Checkout;

                    else if (input.Contains("MOVE") && input.Contains("WEST"))
                        currentRoom = Room.Chicken;

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;

                // ================= CHECKOUT =================
                case Room.Checkout:

                    if (input.Contains("USE"))
                    {
                        while (!(input.Contains("WALLET")))
                        {
                            input = "USE";
                            type("What would you like to use?");
                            Console.Write("> ");
                            input = input + Console.ReadLine().ToUpper();
                        }
                        if (hasPizza && hasChicken && hasBagels)
                        {
                            checkedOut = true;
                            type("You bought your items!");
                        }
                        else
                        {
                            type("You still need all 3 items.");
                        }
                    }

                    else if (input.Contains("MOVE") && input.Contains("NORTH"))
                        currentRoom = Room.Bakery;

                    else if (input.Contains("MOVE") && input.Contains("SOUTH"))
                    {
                        if (checkedOut)
                            currentRoom = Room.Exit;
                        else
                            type("You must checkout first.");
                    }

                    else if (input.Contains("MOVE"))
                        type("There's nothing in that direction.");

                    else if (input.Contains("TAKE"))
                        type("There's nothing for you to take here.");

                    else if (input.Contains("USE"))
                        type("There's nothing for you to use here.");

                    break;
            }
        }

        type("You are at the exit." + '\n' + "Congratulations! You completed Costco Adventure!");
    }
}