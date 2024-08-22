using System;
//C to F: ((9/5)*C) + 32
//F to C: (5/9) * (F-32)

//C to K: C + 273.15
//K to C: K - 273.15

//F to K: (5/9) * (F-32) + 273.15
//K to F: (9/5) * (K-273.15) + 32 

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Conversion Program");
        Console.WriteLine("");
        Console.Write("Enter Temperature Value: ");
        double val = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Select The Unit Of Measurement");
        Console.WriteLine("1. Celsius");
        Console.WriteLine("2. Fahrenheit");
        Console.WriteLine("3. Kelvin Scale");
        Console.Write("Enter number of unit: ");
        string unit = Console.ReadLine();
        Console.WriteLine("");

        switch (unit)
        {
            case "1":
                Console.WriteLine($"Celsius: {val:F2}\u00B0C");
                toFahrenheit(val, unit);
                toKelvin(val, unit);
                break;
            case "2":
                Console.WriteLine($"Fahrenheit: {val:F2}\u00B0F");
                toCelsius(val, unit);
                toKelvin(val, unit);
                break;
            case "3":
                Console.WriteLine($"Kelvin Scale: {val:F2}\u00B0K");
                toFahrenheit(val, unit);
                toCelsius(val, unit);
                break;
            default:
                Console.WriteLine("Wrong Value Entered");
                break;
        }
    }

    static void toCelsius(double fVal, string fUnit)
    {
        double result;
        if (fUnit == "2")  //fix calculation
        {
            result = (5 / 9) * (fVal - 32);
            Console.WriteLine($"Celsius: {result:F2}\u00B0C");
        }
        else if (fUnit == "3")
        {
            result = fVal - 273.15;
            Console.WriteLine($"Celsius: {result:F2}\u00B0C");
        }

    }

    static void toFahrenheit(double fVal, string fUnit) //fix calculations
    {
        double result;
        if (fUnit == "1")
        {
            result = (9 / 5 * fVal) + 32;
            Console.WriteLine($"Fahrenheit: {result:F2}\u00B0F");
        }
        else if (fUnit == "3")
        {
            result = (9 / 5) * (fVal - 273.15) + 32;
            Console.WriteLine($"Fahrenheit: {result:F2}\u00B0F");
        }
    }

    static void toKelvin(double fVal, string fUnit)
    {
        double result;
        if (fUnit == "1")
        {
            result = fVal + 273.15;
            Console.WriteLine($"Kelvin Scale: {result:F2}\u00B0K");
        }
        else if (fUnit == "2") //fix calculation
        {
            result = (5 / 9) * (fVal - 32) + 273.15;
            Console.WriteLine($"Kelvin Scale: {result:F2}\u00B0K");
        }
    }
}