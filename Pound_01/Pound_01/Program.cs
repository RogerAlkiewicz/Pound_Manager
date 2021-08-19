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
                        Console.WriteLine("What do you want to add?");
                        read = Console.ReadLine();
                        pound.Add(read);
                        break;
                    }
                case "del":
                    {
                        Console.WriteLine("What do you want to delete?");
                        read = Console.ReadLine();
                        pound.Del(read);
                        break;
                    }
                case "status":
                    {
                        // based on "capacity" field value algorithm displays database's current status
                        if (pound.GetSpace() == pound.database.Length)
                            Console.WriteLine($"Currently there are {pound.GetSpace()} animals. Pound is full and cannot take in more animals.");
                        else if (pound.GetSpace() == 0)
                            Console.WriteLine("Curretnly the pound is empty.");
                        else
                            Console.WriteLine($"Currently there are {pound.GetSpace()} animals in the pound's database.");
                        break;
                    }
                case "list":
                    {
                        // wyświetla listę wszystkich zwierząt w schronisku
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine("\nGoodbye!");
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