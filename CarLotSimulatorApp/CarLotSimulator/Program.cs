using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            Car ford = new Car("Ford", "Focus", 2013, "Vrooom!", "Beep!", true);
            Car mazda = new Car("Mazda", "CX-15", 2016, "Brooom!", "Beep beep!", true);
            Car vw = new Car("Volkswagen", "Jetta", 2021, "Brrrmp!", "Honk", true);

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();
            mazda.MakeEngineNoise();
            mazda.MakeHonkNoise();
            vw.MakeEngineNoise();
            vw.MakeHonkNoise();

         
        }
    }
}
