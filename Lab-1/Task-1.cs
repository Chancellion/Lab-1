using System;

public class Address
{
    public int Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }
}

public class Program
{
    public static void Main()
    {
        Address address = new Address
        {
            Index = 51500,
            Country = "Україна",
            City = "Полтава",
            Street = "Вул. Iменi Пса Патрона",
            House = "31а",
            Apartment = "315"
        };

        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        Console.WriteLine($"Iндекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Мiсто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");
    }
}
