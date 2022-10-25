using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO


            var lot = new CarLot();

            

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var Tahoe = new Car();

            Tahoe.Year = 2015;
            Tahoe.Make = "Chevrolet";
            Tahoe.Model = "Tahoe";
            Tahoe.EngineNoise = "Vroom";
            Tahoe.HonkNoise = "Honk";
            Tahoe.IsDriveable = true;

            Tahoe.MakeEngineNoise();
            Tahoe.MakeHonkNoise();

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

            Truck.MakeEngineNoise();
            Truck.MakeHonkNoise();


            var Jeep = new Car(2021, "Jeep", "Cherokee", "Vroom", "Beep", true);

            lot.Cars.Add(Jeep);

            Jeep.MakeEngineNoise();
            Jeep.MakeHonkNoise();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
