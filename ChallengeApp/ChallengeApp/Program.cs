var name = "Ewa";
var sex = 'K'; 
var age = 33;

if (sex == 'K')
{
    if (age < 33)
    {
        Console.WriteLine("Kobieta poniżej 33 lat");
    }

    else if (age > 33)
    {
        Console.WriteLine("Kobieta powyżej 33 lat");
    }

    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }

    else
    {
        Console.WriteLine("Kobieta lat 33");
    }
}

else if (sex == 'M')
{
    if(age >= 18)
    {
        Console.WriteLine("Pelnoletni Mężczyzna");
    }

    else
    {
        Console.WriteLine("Niepelnoletni Mężczyzna");
    }
}

else
{
    Console.WriteLine("Nie jesteś Kobietą ani Mężczyzną");
}
