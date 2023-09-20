using System;

// Клас Address
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

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

// Клас Converter
class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usdRate;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eurRate;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / plnRate;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * usdRate;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * eurRate;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * plnRate;
    }
}

// Клас Employee
class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPositionAndExperience(string position, int experience)
    {
        this.position = position;
        this.experience = experience;
    }

    public double CalculateSalary()
    {
        // Припустимо, що оклад залежить від посади та стажу
        double baseSalary = 50000; // Базовий оклад
        double positionBonus = 0;

        if (position == "Менеджер")
            positionBonus = 10000;
        else if (position == "Розробник")
            positionBonus = 15000;
        else if (position == "Тестувальник")
            positionBonus = 12000;

        // Додатковий бонус за стаж
        double experienceBonus = experience * 1000;

        double salary = baseSalary + positionBonus + experienceBonus;
        return salary;
    }

    public double CalculateTax()
    {
        // Податковий збір (припустимо, 18%)
        double salary = CalculateSalary();
        return 0.18 * salary;
    }

    public void PrintEmployeeInfo()
    {
        Console.WriteLine("Ім'я: " + firstName);
        Console.WriteLine("Прізвище: " + lastName);
        Console.WriteLine("Посада: " + position);
        Console.WriteLine("Оклад: " + CalculateSalary());
        Console.WriteLine("Податковий збір: " + CalculateTax());
    }
}

// Клас User
class User
{
    public string Login { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        RegistrationDate = DateTime.Now;
    }

    public void PrintUserInfo()
    {
        Console.WriteLine("Логін: " + Login);
        Console.WriteLine("Ім'я: " + FirstName);
        Console.WriteLine("Прізвище: " + LastName);
        Console.WriteLine("Вік: " + Age);
        Console.WriteLine("Дата реєстрації: " + RegistrationDate.ToString("dd.MM.yyyy HH:mm:ss"));
    }
}

class Program
{
    static void Main()
    {
        // Створення екземпляру класу Address
        Address address = new Address();
        address.Index = "12345";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Вулиця Хрещатик";
        address.House = "1";
        address.Apartment = "10";

        // Виведення інформації про адресу
        address.PrintAddress();

        // Створення екземпляру класу Converter з курсами валют
        Converter converter = new Converter(36.5, 39.5, 8.5);

        // Конвертація гривні в USD та назад
        double uahAmount = 1000.0;
        double usdAmount = converter.ConvertToUSD(uahAmount);
        double uahConverted = converter.ConvertFromUSD(usdAmount);
        Console.WriteLine($"{uahAmount} UAH = {usdAmount} USD");
        Console.WriteLine($"{usdAmount} USD = {uahConverted} UAH");

        // Створення екземпляру класу Employee
        Employee employee = new Employee("Петров", "Іван");
        employee.SetPositionAndExperience("Розробник", 5);

        // Виведення інформації про співробітника
        employee.PrintEmployeeInfo();

        // Створення екземпляру класу User
        User user = new User("user123", "Юрій", "Ковальов");
        user.Age = 30;

        // Виведення інформації про користувача
        user.PrintUserInfo();

        Console.ReadLine();
    }
}
