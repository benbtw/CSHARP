using System;

class UnitConverter
{
    public static void Main(String[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Unit Converter");
            Console.WriteLine("1. Miles to Kilometers");
            Console.WriteLine("2. Pounds to Kilograms");
            Console.WriteLine("3. Fahrenheit to Celcius");
            String input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MilesToKilo();
                    break;
                case "2":
                    PoundsToKilograms();
                    break;
                case "3":
                    FahrenheitToCelcius();
                    break;
                default: 
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    public static void MilesToKilo()
    {
        Console.Clear();
        Console.WriteLine("Enter the number of miles: ");
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.609344;
        Console.Clear();
        Console.WriteLine("{0} miles is equal to {1} kilometers", miles, kilometers);
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
    }

    public static void PoundsToKilograms()
    {
        Console.Clear();
        Console.WriteLine("Enter the number of pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.45359237;
        Console.Clear();
        Console.WriteLine("{0} pounds is equal to {1} kilograms", pounds, kilograms);
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
    }

    public static void FahrenheitToCelcius()
    {
        Console.Clear();
        Console.WriteLine("Enter the temperature in fahrenheit: ");
        double f = double.Parse(Console.ReadLine());
        double c = (f - 32) * 5 / 9;
        Console.Clear();
        Console.WriteLine("{0} degrees fahrenheit is equal to {1} degrees celcius", f, c);
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
    }

}