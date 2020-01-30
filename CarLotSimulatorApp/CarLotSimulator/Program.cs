using System;
using System.Collections.Generic;
using CarLotSimulator;

class Program
{
    static void Main(string[] args)
    {
        var carCollection = new CarLot();
        var carList = new List<Car>();


        Car mustang = new Car() { Year = 2004, Make = "Ford", Model = "Mustang" };
        mustang.MakeEngineNoise("VROOM");
        mustang.MakeHonkNoise("Beep");

        Car Cherokee = new Car();
        Cherokee.Year = 1974;
        Cherokee.Make = "Jeep";
        Cherokee.Model = "Cherokee";
        Cherokee.MakeEngineNoise("Sputter");
        Cherokee.MakeHonkNoise("Meep");


        var focus = new Car();
        focus.Year = 2013;
        focus.Model = "Focus";
        focus.Make = "Ford";
        focus.IsDriveable = true;
        focus.MakeEngineNoise("vroooom vroooom");
        focus.MakeHonkNoise("beeep beeeeep");


        //object initializer syntax - using scope with Properties inside
        var fusion = new Car();

        {
            bool IsDriveable = false;
            string Make = "Ford";
            string Model = "Fusion";

            Model = "Fusion";
            Make = "Ford";
            IsDriveable = false;
        };


        fusion.MakeEngineNoise("silent");
        fusion.MakeHonkNoise("shrill sound");

        var explorer = new Car(1999, "Ford", "Explorer", "buzz", "beeeeeeep", true);

        explorer.MakeEngineNoise(explorer.EngineNoise);
        explorer.MakeHonkNoise(focus.HonkNoise);


        carCollection.Lot.Add(focus);
        carCollection.Lot.Add(fusion);
        carCollection.Lot.Add(explorer);

        carCollection.Lot = carList;

        foreach (var car in carCollection.Lot)
        {
            Console.WriteLine(
                $"Make: {car.Make}, " +
                $"Model: {car.Model}, " +
                $"Year {car.Year}");
        }

        Car Corolla = new Car()
        {
            Year = 2008,
            Make = "Toyota",
            Model = "Corolla"
        };
        Corolla.MakeEngineNoise("whir");
        Corolla.MakeHonkNoise("Clown horn sound");
    }
}
