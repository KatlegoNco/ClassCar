using System;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsRunning { get; private set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        IsRunning = false;
    }

    public void Start()
    {
        if (!IsRunning)
        {
            IsRunning = true;
            Console.WriteLine($"The {Year} {Make} {Model} is now running.");
        }
        else
        {
            Console.WriteLine($"The {Year} {Make} {Model} is already running.");
        }
    }

    public void Honk()
    {
        if (IsRunning)
        {
            Console.WriteLine("Beep beep!");
        }
        else
        {
            Console.WriteLine("The car is not running, so it cannot honk.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the make of the car: ");
        string make = Console.ReadLine();

        Console.Write("Enter the model of the car: ");
        string model = Console.ReadLine();

        Console.Write("Enter the year of the car: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Car myCar = new Car(make, model, year);

        Console.WriteLine("Do you want to start th" +
            "[..e car? (yes/no): ");
        string startResponse = Console.ReadLine().ToLower();

        if (startResponse == "yes")
        {
            myCar.Start();
        }

        Console.WriteLine("Do you want to honk the horn? (yes/no): ");
        string honkResponse = Console.ReadLine().ToLower();

        if (honkResponse == "yes")
        {
            myCar.Honk();
        }
    }
}
