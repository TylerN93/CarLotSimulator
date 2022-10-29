using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO


            var lot = new CarLot();

            


            var Tahoe = new Car();

            Tahoe.Year = 2015;
            Tahoe.Make = "Chevrolet";
            Tahoe.Model = "Tahoe";
            Tahoe.EngineNoise = "Vroom";
            Tahoe.HonkNoise = "Honk";
            Tahoe.IsDriveable = true;

            //Tahoe.MakeEngineNoise();
            //Tahoe.MakeHonkNoise();

            lot.Cars.Add(Tahoe);

            var Truck = new Car()
            {
                Year = 2020,
                Make = "Ford",
                Model = "F150",
                EngineNoise = "Woosh",
                HonkNoise = "Beep",
                IsDriveable = true
            };

            lot.Cars.Add(Truck);

            //Truck.MakeEngineNoise();
            //Truck.MakeHonkNoise();


            var Jeep = new Car(2021, "Jeep", "Cherokee", "Vroom", "Beep", true);

            lot.Cars.Add(Jeep);

            //Jeep.MakeEngineNoise();
            //Jeep.MakeHonkNoise();


            Console.WriteLine($"Number of cars created { CarLot.numberOfCars}");
            Console.WriteLine();

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
