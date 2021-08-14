using System;
/*
 * Program pozwala na dodawanie/usuwanie z bazy zwierząt oraz sprawdzanie stanu schroniska (puste, umiarkowane, przepełnione)
 * Wariat I - bardzo prosty:
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
        int room = 0;
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
                        pound_space[room] = read;
                        Console.WriteLine($"You have added {read} to the pound's database.");
                        room++;
                        break;
                    }
                case "del":
                    {
                        Console.WriteLine("What do you want to delete?");
                        read = Console.ReadLine();
                        for (int i = 0; i < pound_space.Length; i++)
                        {
                            if (pound_space[i] == read)
                            {
                                pound_space[i] = string.Empty;
                                Console.WriteLine($"You have deleted {read} from the pound's database.");
                                room--;
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"There isn't any {read} in the database. ");
                                break;
                            }
                        }
                        break;
                    }
                case "status":
                    {
                        Console.WriteLine($"Currently there are {room} animals in the pound's database."/*dodaj info co oznacza ta liczba*/);
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