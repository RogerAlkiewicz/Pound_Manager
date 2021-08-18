using System;
public class Animal
{
    string pet_name;
    Animal(string name)
    {
        if (name == null)
            pet_name = "pet";
        else 
            pet_name = name;
    }
}