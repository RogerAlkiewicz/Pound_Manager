using System;
/*
 * Program pozwala na dodawanie/usuwanie z bazy zwierząt oraz sprawdzanie stanu schroniska (puste, umiarkowane, przepełnione)
 * Wariat 1,5: 
 * - wariant 1 
 * - podzielenie programu na klasy
 * - dodanie metod
 * - dodanie zabezpieczeń
 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Little Friend Pound's database manager!");
        Console.WriteLine("Type \"add\" to add a new animal, or \"del\" to delete it from the database.");
        Console.WriteLine("To show pound's current status type \"status\". To exit the application enter \"exit\".");

        Pound pound = new Pound();
        bool leave = false;
        string read;

        do
        {
            read = Console.ReadLine();
            switch (read)
            {
                case "add":
                    {
                        pound.Add();
                        break;
                    }
                case "del":
                    {
                        pound.Delete();
                        break;
                    }
                case "status":
                    {
                        pound.GetStatus();
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine("Goodbye!\n");
                        leave = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong command! Type \"add\", \"del\", \"status\" or \"exit\".");
                        break;
                    }

            }
        } while (leave == false);
    }
}