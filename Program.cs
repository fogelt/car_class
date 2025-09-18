using System;

class Program
{
    static void Main(string[] args)
    {
        Classes.Car car1 = new Classes.Car("BMW", "Red", 250, 300, Classes.Car.FuelType.Petrol);
        Classes.Car car2 = new Classes.Car("Tesla", "Black", 320, 500, Classes.Car.FuelType.Electric);

        car1.ShowInfo();
        car1.Drive();
        car1.Honk();
        car1.Fuel();

        car2.ShowInfo();
        car2.Drive();
        car2.Honk();
        car2.Fuel();

        if (car1.IsFasterThan(car2))
        {
            Console.WriteLine("Car 1 is faster than Car 2.");
        }
        else
        {
            Console.WriteLine("Car 1 is not faster than Car 2.");
        }
    }
}
