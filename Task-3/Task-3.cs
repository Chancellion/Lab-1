using System;

public class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }
    public double Salary { get; private set; }
    public double Tax { get; private set; }
    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }
    public void CalculateSalary()
    {
        double baseSalary = 3000; // Стандартний оклад
        double positionMultiplier = Position switch
        // Cписок усіх позицій, шо мають підвищенний оклад (окрім останнього)
        {
            "Менеджер" => 1.5,
            "Розробник" => 1.3,
            "Інтерн" => 0.7,
            "Прибиральник" => 0.7,
            "Дизайнер" => 1.2,
            "Тестувальник" => 1.0,
            "Директор" => 2.0,
            _ => 1.0
        };
        double experienceMultiplier = 1 + (Experience * 0.05); // 5% за кожен рік стажу

        Salary = baseSalary * positionMultiplier * experienceMultiplier;
    }

    public void CalculateTax()
    {
        // Под. збір, 20% від окладу)
        Tax = Salary * 0.2;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        Console.Write("Введiть прiзвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Введiть iм'я: ");
        string firstName = Console.ReadLine();

        Console.Write("Введiть посаду: ");
        string position = Console.ReadLine();

        Console.Write("Введiть стаж (у роках): ");
        int experience = int.Parse(Console.ReadLine());

        Employee employee = new Employee(lastName, firstName)
        {
            Position = position,
            Experience = experience
        };
        employee.CalculateSalary();
        employee.CalculateTax();

        Console.WriteLine($"\nIнформацiя про спiвробiтника:");
        Console.WriteLine($"Прiзвище: {employee.LastName}");
        Console.WriteLine($"Iм'я: {employee.FirstName}");
        Console.WriteLine($"Посада: {employee.Position}");
        Console.WriteLine($"Оклад: {employee.Salary}");
        Console.WriteLine($"Податковий збiр: {employee.Tax}");
    }
}
