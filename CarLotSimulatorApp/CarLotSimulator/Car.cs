﻿using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }
        
        public Car(int year, string make, string model,string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Model = model;
            Make = make;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
        
    }
}


//DONE----Create a seperate class file called Car
//Done----Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//DONE-----Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//DONE----The methods should take one string parameter: the respective noise property