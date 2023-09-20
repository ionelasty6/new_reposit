using System;

class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    // Властивість для поля index
    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    // Властивість для поля country
    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    // Властивість для поля city
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    // Властивість для поля street
    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    // Властивість для поля house
    public string House
    {
        get { return house; }
        set { house = value; }
    }

    // Властивість для поля apartment
    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    public void PrintAddress()
    {
        Console.WriteLine("Поштова адреса:");
        Console.WriteLine("Індекс: " + Index);
        Console.WriteLine("Країна: " + Country);
        Console.WriteLine("Місто: " + City);
        Console.WriteLine("Вулиця: " + Street);
        Console.WriteLine("Будинок: " + House);
        Console.WriteLine("Квартира: " + Apartment);
    }
}

class Program
{
    static void Main()
    {
        // Створення екземпляру класу Address
        Address address = new Address();

        // Заповнення полів поштової адреси
        address.Index = "12345";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Вулиця Хрещатик";
        address.House = "1";
        address.Apartment = "10";

        // Виведення інформації про адресу
        address.PrintAddress();

        Console.ReadLine();
    }
}
