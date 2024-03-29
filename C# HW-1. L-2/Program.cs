﻿sbyte option = 1;
bool isC = true;

// Main While
while (isC)
{
    Console.Clear();

    #region First Menu 

    switch (option)
    {
        case 1: Console.ForegroundColor = ConsoleColor.Yellow; break;
        default: Console.ForegroundColor = ConsoleColor.White; break;
    }
    Console.WriteLine("\n\t\tStart Calculating");

    switch (option)
    {
        case 0: Console.ForegroundColor = ConsoleColor.Yellow; break;
        default: Console.ForegroundColor = ConsoleColor.White; break;
    }
    Console.WriteLine("\n\t\tExit");

    #endregion

    // Get KB Key
    ConsoleKeyInfo c_key = Console.ReadKey(true);

    #region Check First KB Key 

    switch (c_key.Key)
    {
        case ConsoleKey.UpArrow:
        case ConsoleKey.W:
            option++;
            if (option > 1) option = 0;
            break;
        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            option--;
            if (option < 0) option = 1;
            break;
        case ConsoleKey.RightArrow:
        case ConsoleKey.D:
            option++;
            if (option > 1) option = 0;
            break;
        case ConsoleKey.LeftArrow:
        case ConsoleKey.A:
            option--;
            if (option < 0) option = 1;
            break;
        case ConsoleKey.Enter:
            sbyte option2 = 0;

            switch (option)
            {
                case 1:
                    bool _isC = true;

                    while (_isC)
                    {
                        Console.Clear();

                        #region Second Menu 

                        switch (option2)
                        {
                            case 0: Console.ForegroundColor = ConsoleColor.Magenta; break;
                            default: Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\n\t\tBack To Menu.");
                        switch (option2)
                        {
                            case 1: Console.ForegroundColor = ConsoleColor.Magenta; break;
                            default: Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\n\t\tOperator:  n1 + n2");

                        switch (option2)
                        {
                            case 2: Console.ForegroundColor = ConsoleColor.Magenta; break;
                            default: Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\n\t\tOperator:  n1 - n2");

                        switch (option2)
                        {
                            case 3: Console.ForegroundColor = ConsoleColor.Magenta; break;
                            default: Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\n\t\tOperator:  n1 * n2");

                        switch (option2)
                        {
                            case 4: Console.ForegroundColor = ConsoleColor.Magenta; break;
                            default: Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\n\t\tOperator:  n1 / n2");

                        switch (option2)
                        {
                            case 5: Console.ForegroundColor = ConsoleColor.Magenta; break;
                            default: Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\n\t\tOperator:  n1 ^ n2");

                        #endregion

                        // Get KB Key
                        ConsoleKeyInfo c2_key = Console.ReadKey(true);

                        #region Check Second KB Key 

                        switch (c2_key.Key)
                        {
                            case ConsoleKey.UpArrow:
                            case ConsoleKey.W:
                                option2--;
                                if (option2 < 0) option2 = 5;
                                break;
                            case ConsoleKey.DownArrow:
                            case ConsoleKey.S:
                                option2++;
                                if (option2 > 5) option2 = 0;
                                break;
                            case ConsoleKey.RightArrow:
                            case ConsoleKey.D:
                                option2--;
                                if (option2 < 0) option2 = 5;
                                break;
                            case ConsoleKey.LeftArrow:
                            case ConsoleKey.A:
                                option2++;
                                if (option2 > 5) option2 = 0;
                                break;
                            case ConsoleKey.Enter:
                                if (option2 == 0)
                                { Thread.Sleep(700); _isC = false;  break; }

                                // Variables
                                double num1 = 0.0, num2 = 0.0, result = 0.0;
                                char oper = '=';

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("\n\n\t\tEnter the First Number : ");
                                double.TryParse(Console.ReadLine(), out num1);

                                Console.Write("\n\t\tEnter the Second Number : ");
                                double.TryParse(Console.ReadLine(), out num2);

                                switch (option2)
                                {
                                    case 1:
                                        result = num1 + num2;
                                        oper = '+';
                                        break;
                                    case 2:
                                        result = num1 - num2;
                                        oper = '-';
                                        break;
                                    case 3:
                                        result = num1 * num2;
                                        oper = '*';
                                        break;
                                    case 4:
                                        if (num1 == 0.0 || num2 == 0.0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n\n\t\tCan not Divide by Zero !!!");
                                            Thread.Sleep(1800);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            continue;
                                        }

                                        result = num1 / num2;
                                        oper = '/';
                                        break;
                                    case 5:
                                        result = 1.0;

                                        for (double i = 0.0; i < num2; i++)
                                            result *= num1;

                                        oper = '^';
                                        break;

                                }

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\n\n\t\tResult :  {num1} {oper} {num2} = {result}\t");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\n\n\tPress any key to continue...");
                                Console.ReadKey();

                                break;
                        }

                        #endregion

                    }

                    break;
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\tBYE BYE !\n\n");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    isC = false;
                    break;
            }
            break;
    }
    #endregion
}