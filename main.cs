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
        bool active = true;
        while (active)  //loop for code repetition
        {
            Console.WriteLine("Temperature Conversion Program");
            Console.WriteLine("");
            Console.Write("Enter Temperature Value: ");
            string num = Console.ReadLine();
            if (double.TryParse(num, out double val))
            {
                Console.WriteLine("");
                Console.WriteLine("Select The Unit Of Measurement");
                Console.WriteLine("1. Celsius");
                Console.WriteLine("2. Fahrenheit");
                Console.WriteLine("3. Kelvin Scale");
                Console.Write("Enter number of unit: ");
                string unit = Console.ReadLine();
                Console.WriteLine("");

                //COde to call upon cpnversion calculations and displaying
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
            else
            {
                Console.WriteLine("Invalid Value Entered.");
            }

            //Query to repeat program or exit
            Console.WriteLine("Would You Like To Go Again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string opt = Console.ReadLine();

            if (opt == "1")
            {
                Console.Clear();
            }
            else if (opt == "2")
            {
                active = false;
            }
            else
            {
                active = false;
                Console.WriteLine("Incorrect Value Entered! Program Will Now Be Terminated.");
            }


        }
    }

    static void toCelsius(double fVal, string fUnit)
    { //Conversion to celsius
        double result;
        if (fUnit == "2") //from Fahrenheit
        {
            result = (fVal - 32) * 5.0 / 9.0;
            Console.WriteLine($"Celsius: {result:F2}\u00B0C");
        }
        else if (fUnit == "3") //from Kelvin
        {
            result = fVal - 273.15;
            Console.WriteLine($"Celsius: {result:F2}\u00B0C");
        }
    }

    static void toFahrenheit(double fVal, string fUnit)
    { //Conversion to Fahrenheit
        double result;
        if (fUnit == "1") //from Celsius
        {
            result = 9.0 / 5.0 * fVal + 32;
            Console.WriteLine($"Fahrenheit: {result:F2}\u00B0F");
        }
        else if (fUnit == "3") //from Kelvin
        {
            result = 9.0 / 5.0 * (fVal - 273.15) + 32;
            Console.WriteLine($"Fahrenheit: {result:F2}\u00B0F");
        }
    }

    static void toKelvin(double fVal, string fUnit)
    { //Conversion to Kelvin
        double result;
        if (fUnit == "1") //from Celsius
        {
            result = fVal + 273.15;
            Console.WriteLine($"Kelvin Scale: {result:F2}\u00B0K");
        }
        else if (fUnit == "2") //from Fahrenheit
        {
            result = 5.0 / 9.0 * (fVal - 32) + 273.15;
            Console.WriteLine($"Kelvin Scale: {result:F2}\u00B0K");
        }
    }
}