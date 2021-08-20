using System;
public class Pound
{
    const int capacity = 10;
    int space;
    public Animal[] database;


    public Pound()
    {
        database = new Animal[capacity];
        space = 0;
    }


    public int GetCapacity()
    {
        return capacity;
    }


    public int GetSpace()
    {
        return space;
    }


    public void GetStatus()
    { 

        if (space == capacity)
            Console.WriteLine($"Currently there are {space} animals. Pound is full and cannot take in more animals.");
        else if (space == 0)
            Console.WriteLine("Curretnly the pound is empty.");
        else
            Console.WriteLine($"Currently there are {space} animals in the pound's database.");
    }


    public void Add()
    {
        Console.WriteLine("What do you want to add?");
        string pet_name = Console.ReadLine();
        try
        {
            database[Find_Space()] = new Animal(pet_name);
            Console.WriteLine($"You have added new pet to the pound's database.");
            space++;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Pound's capacity is full.");
        }
    }


    int Find_Space()
    {
        for (int slot = 0; slot < database.Length; slot++)
        {
            if (database[slot] == null)
                return slot;
        }
        return -1;
    }


    public void Delete()
    {
        Console.WriteLine("What do you want to delete?");
        string pet_name = Console.ReadLine();
        try
        {
            database[Find_Pet(pet_name)] = null;
            Console.WriteLine($"You have deleted {pet_name} from the pound's database.");
            space--;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine($"There is not any {pet_name} in the database.");
        }
    }


    int Find_Pet(string pet_name)
    {
        for (int slot = 0; slot < database.Length; slot++)
        {
            try
            {
                if (database[slot].name == pet_name)
                    return slot;
            }
            catch (NullReferenceException)
            {
                continue;
            }
        }
        return -1;
    }
}