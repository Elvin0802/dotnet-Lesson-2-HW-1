
using System.Security.Cryptography;

sbyte option = 1;


while (true)
{
    Console.Clear();

    #region First Menu 
    if (option == 1) Console.ForegroundColor = ConsoleColor.Yellow;
    else Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n\t\tStart Calculating");

    if (option == 0) Console.ForegroundColor = ConsoleColor.Yellow;
    else Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n\t\tExit");
    #endregion

    // Get KB Key
    ConsoleKeyInfo c_key = Console.ReadKey(true);

    #region Check First KB Key 
    if (c_key.Key == ConsoleKey.UpArrow || c_key.Key == ConsoleKey.W)
    {
        option++; if (option > 1) option = 0;
    }
    else if (c_key.Key == ConsoleKey.DownArrow || c_key.Key == ConsoleKey.S)
    {
        option--; if (option < 0) option = 1;
    }
    else if (c_key.Key == ConsoleKey.RightArrow || c_key.Key == ConsoleKey.D)
    {
        option++; if (option > 1) option = 0;
    }
    else if (c_key.Key == ConsoleKey.LeftArrow || c_key.Key == ConsoleKey.A)
    {
        option--; if (option < 0) option = 1;
    }
    #endregion

    #region Check First Enter Key 
    if (c_key.Key == ConsoleKey.Enter)
    {
        if (option == 1)
        {
            sbyte option2 = 0;

            while (true)
            {
                Console.Clear();

                #region Second Menu 

                if (option2 == 0) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tBack To Menu.");

                if (option2 == 1) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tOperator:  n1 + n2");

                if (option2 == 2) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tOperator:  n1 - n2");

                if (option2 == 3) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tOperator:  n1 * n2");

                if (option2 == 4) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tOperator:  n1 / n2");

                if (option2 == 5) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tOperator:  n1 ^ n2");

                #endregion

                // Get KB Key
                ConsoleKeyInfo c2_key = Console.ReadKey(true);

                #region Check Second KB Key 

                if (c2_key.Key == ConsoleKey.UpArrow || c2_key.Key == ConsoleKey.W)
                {
                    option2--; if (option2 < 0) option2 = 5;
                }
                else if (c2_key.Key == ConsoleKey.DownArrow || c2_key.Key == ConsoleKey.S)
                {
                    option2++; if (option2 > 5) option2 = 0;
                }
                else if (c2_key.Key == ConsoleKey.RightArrow || c2_key.Key == ConsoleKey.D)
                {
                    option2--; if (option2 < 0) option2 = 5;
                }
                else if (c2_key.Key == ConsoleKey.LeftArrow || c2_key.Key == ConsoleKey.A)
                {
                    option2++; if (option2 > 5) option2 = 0;
                }

                #endregion

                #region Check Second Enter Key 

                if (c2_key.Key == ConsoleKey.Enter)
                {
                    Console.Write("\n\n\n");
                    double num1 = 0.0, num2 = 0.0, result = 0.0;

                    if (option2 == 1)
                    {
                        Console.WriteLine("\n\tEnter the 1st number : ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("\n\tEnter the 2nd number : ");
                        double.TryParse(Console.ReadLine(), out num2);

                        result = num1+num2;

                        Console.WriteLine($"\n{num1} + {num2} = {result} ..");
                    }
                    else if (option2 == 2)
                    {
                        Console.WriteLine("\n\tEnter the 1st number : ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("\n\tEnter the 2nd number : ");
                        double.TryParse(Console.ReadLine(), out num2);

                        result = num1-num2;

                        Console.WriteLine($"\n{num1} - {num2} = {result} ..");
                    }
                    else if (option2 == 3)
                    {
                        Console.WriteLine("\n\tEnter the 1st number : ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("\n\tEnter the 2nd number : ");
                        double.TryParse(Console.ReadLine(), out num2);

                        result = num1*num2;

                        Console.WriteLine($"\n{num1} * {num2} = {result} ..");
                    }
                    else if (option2 == 4)
                    {
                        Console.WriteLine("\n\tEnter the 1st number : ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("\n\tEnter the 2nd number : ");
                        double.TryParse(Console.ReadLine(), out num2);

                        if (num1 == 0.0 || num2 == 0.0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Can not Divide by Zero !!!");
                            Thread.Sleep(1200);
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }

                        result = num1/num2;

                        Console.WriteLine($"\n{num1} / {num2} = {result} ..");
                    }
                    else if (option2 == 5)
                    {
                        Console.WriteLine("\n\tEnter the 1st number : ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("\n\tEnter the 2nd number : ");
                        double.TryParse(Console.ReadLine(), out num2);

                        result = 1.0;

                        for (double i = 0.0; i < num2; i++)
                            result*= num1;

                        Console.WriteLine($"\n{num1} ^ {num2} = {result} ..");
                    }
                    else if (option2 == 0)
                    {
                        Thread.Sleep(700);
                        break;
                    }
                }
                #endregion
            }
        }
        else if (option == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tBYE BYE !\n\n");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        }
    }
    #endregion
}
