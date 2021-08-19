using System;
public class Animal
{
    public string name;
    public Animal(string read)
    {
        if (read == string.Empty)
            name = "pet";
        else 
            name = read;
    }
}