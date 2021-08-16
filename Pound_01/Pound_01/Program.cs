using System;
/*
 * Program pozwala na dodawanie/usuwanie z bazy zwierząt oraz sprawdzanie stanu schroniska (puste, umiarkowane, przepełnione)
 * Wariat 1 - bardzo prosty:
 * - schronisko ma mieć określoną liczbę miejsc
 * - możliwość dodania/usunięcia zwierzaka do/z listy w schronisku (bez bazy danych, czy pliku tekstowego)
 * - po wpisaniu "status" wyświetli aktualną liczbę zwierząt i komunikat, co oznacza ta liczba zwierząt (puste, umiarkowane, przepełnione)
 * - logika uniemożliwiająca dodanie kolejnych zwierząt, gdy schronisko jest przepełnione
 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Little Friend Pound's database manager!");
        Console.WriteLine("Type \"add\" to add a new animal, or \"del\" to delete it from the database.");
        Console.WriteLine("To show pound's current status type \"status\". To exit the application enter \"exit\".");
        string[] pound_space = new string[5];
        int space = 0;
        bool leave = false;
        string read = string.Empty;
        while (leave != true)
        {
            read = Console.ReadLine();
            switch (read)            
            {
                case "add":
                    {
                        Console.WriteLine("What do you want to add?");
                        read = Console.ReadLine();
                        // loop searches for the first free slot in the array
                        // if there ain't any, the if condition won't allow to put a new record in the array
                        for (int i = 0; i < pound_space.Length; i++)
                        {
                            if (pound_space[i] == null)
                            {
                                pound_space[i] = read;
                                Console.WriteLine($"You have added {read} to the pound's database.");
                                space++;
                                break;
                            }
                            else if (i == pound_space.Length - 1)
                                Console.WriteLine("Pound's capacity is full.");
                        }
                        break;
                    }
                case "del":
                    {
                        Console.WriteLine("What do you want to delete?");
                        read = Console.ReadLine();
                        // loop searches for the matching string in the array
                        // if keyword don't match at the last iteration the else if condition outputs an appropriate information
                        for (int i = 0; i < pound_space.Length; i++)
                        {
                            if (pound_space[i] == read)
                            {
                                pound_space[i] = string.Empty;
                                Console.WriteLine($"You have deleted {read} from the pound's database.");
                                space--;
                                break;
                            }
                            else if (i == pound_space.Length - 1)
                                Console.WriteLine($"There is not any {read} in the database.");
                        }

                        break;
                    }
                case "status":
                    {
                        // based on "space" variable's value algorithm displays wheather the pound is full, empty
                        if (space == pound_space.Length)
                            Console.WriteLine($"Currently there are {space} animals. Pound is full and cannot take in more animals.");
                        else if (space > 0 || space < pound_space.Length)
                            Console.WriteLine($"Currently there are {space} animals in the pound's database.");
                        else
                            Console.WriteLine("Curretnly the pound is empty.");
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine("Goodbye!");
                        leave = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong command! Type \"add\", \"del\", \"status\" or \"exit\".");
                        break;
                    }

            }
        }
    }
}