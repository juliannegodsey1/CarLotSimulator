using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            var ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Focus";
            ford.Year = 2013;
            ford.EngineNoise = "Vrooom!";
            ford.HonkNoise = "Beep beep!";
            ford.IsDriveable = true;

            var mazda = new Car();
            mazda.Make = "Mazda";
            mazda.Model = "CX-15";
            mazda.Year = 2016;
            mazda.EngineNoise = "Brooom!!";
            mazda.HonkNoise = "Honk!";
            mazda.IsDriveable = true;


            var vw = new Car();
            vw.Make = "Volkswagen";
            vw.Model = "Jetta";
            vw.Year = 2021;
            vw.EngineNoise = "Brmmmp!";
            vw.HonkNoise = "Honk!";
            vw.IsDriveable = true;

      

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();
            mazda.MakeEngineNoise();
            mazda.MakeHonkNoise();
            vw.MakeEngineNoise();
            vw.MakeHonkNoise();

            Console.WriteLine("");
            Console.WriteLine("--------------");
            Console.WriteLine("");
            Console.WriteLine($"Number of cars currently in the lot: {CarLot.numberOfCars}");

         
        }

    }
}
