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
    public int GetSpace()
    {
        return space;
    }
    int Find_Pet(string pet_name)
    // method checks if there is a matching string in the database array and returns [value] for the object that holds wanted string
    // returns -1 if it fails to be handled by IndexOutOfRangeException in Del()
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
    int Find_Space()
    {
        for (int slot = 0; slot < database.Length; slot++)
        {
            if (database[slot] == null)
                return slot;
        }
        return -1;
    }
    public void Add(string pet_name)
    {
        try
        {
            database[Find_Space()] = new Animal(pet_name);
            space++;
            Console.WriteLine($"You have added new pet to the pound's database.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Pound's capacity is full.");
        }
    }
    public void Del(string pet_name)
    {
        try
        {
            database[Find_Pet(pet_name)] = null;
            space--;
            Console.WriteLine($"You have deleted {pet_name} from the pound's database.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine($"There is not any {pet_name} in the database.");
        }
    }

}