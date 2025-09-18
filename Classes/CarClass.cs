namespace Classes
{
    class Car
    {
        string Brand;
        string Color;
        int MaxSpeed;
        int HorsePower;
        public enum FuelType { Petrol, Diesel, Electric, Hybrid }
        FuelType fuel;

        // Constructor
        public Car(string brand, string color, int maxSpeed, int horsePower, FuelType fuel)
        {
            Brand = brand;
            Color = color;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            this.fuel = fuel;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Color: {Color}, MaxSpeed: {MaxSpeed}, HorsePower: {HorsePower}, FuelType: {fuel}");
        }
        public void Drive()
        {
            Console.WriteLine($"The {Brand} car is driving at max speed of {MaxSpeed} km/h.");
        }
        public void Honk()
        {
            Console.WriteLine("Beep Beep!");
        }
        public void Fuel()
        {
            Console.WriteLine($"The car runs on {fuel}.");
        }

        public bool IsFasterThan(Car otherCar)
        {
            return this.MaxSpeed > otherCar.MaxSpeed;
        }
    }
}
