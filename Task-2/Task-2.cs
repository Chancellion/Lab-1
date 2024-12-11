using System;

public class Converter
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

    public double ConvertFromUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount / usdRate;
            case "EUR":
                return amount / eurRate;
            case "PLN":
                return amount / plnRate;
            default:
                throw new ArgumentException("Лажа");
        }
    }

    public double ConvertToUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount * usdRate;
            case "EUR":
                return amount * eurRate;
            case "PLN":
                return amount * plnRate;
            default:
                throw new ArgumentException("Лажа");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        Console.WriteLine("Введiть курси обмiну для USD, EUR та PLN:");
        double usdRate = Convert.ToDouble(Console.ReadLine());
        double eurRate = Convert.ToDouble(Console.ReadLine());
        double plnRate = Convert.ToDouble(Console.ReadLine());

        Converter converter = new Converter(usdRate, eurRate, plnRate);

        Console.WriteLine("Введiть тип конвертацiї (1: гривня в iноземну валюту, 2: iноземна валюта в гривню):");
        int conversionType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Кiлькiсть:");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("А яка валюта? (USD, EUR, PLN):");
        string currency = Console.ReadLine();

        double result;
        if (conversionType == 1)
        {
            result = converter.ConvertFromUAH(amount, currency);
        }
        else if (conversionType == 2)
        {
            result = converter.ConvertToUAH(amount, currency);
        }
        else
        {
            throw new ArgumentException("Лажа, а не данi");
        }
        Console.WriteLine($"Конвертовано: {result}");
    }
}
