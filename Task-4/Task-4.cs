using System;

public class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime SurveyDate { get; }
    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        SurveyDate = DateTime.Now;
    }
    public void DisplayInfo()
    {

        Console.WriteLine($"Логiн: {Login}");
        Console.WriteLine($"Iм'я: {FirstName}");
        Console.WriteLine($"Прiзвище: {LastName}");
        Console.WriteLine($"Вiк: {Age}");
        Console.WriteLine($"Дата: {SurveyDate}");
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        Console.Write("Введiть логiн: ");
        string login = Console.ReadLine();
        Console.Write("Введiть iм'я: ");
        string firstName = Console.ReadLine();
        Console.Write("Введiть прiзвище: ");
        string lastName = Console.ReadLine();
        Console.Write("Введiть вiк: ");
        int age = int.Parse(Console.ReadLine());
        User user = new User(login, firstName, lastName, age);
        user.DisplayInfo();
    }
}
