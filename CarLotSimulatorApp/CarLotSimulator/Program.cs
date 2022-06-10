using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            CarLot myCarLot = new CarLot();
            Car myFirstCar = new Car { Year = "2005", Make = "Dodge", Model = "Dakota", EngineNoise = "brrrrrm", HonkNoise = "BEEP!", IsDriveable = false };
            myCarLot.CarList.Add(myFirstCar);
            Car mySecondCar = new Car("Dodge", "Durango", "2010", "putputputputput", "HONK!", false);
            myCarLot.CarList.Add(mySecondCar);
            Car myThirdCar = new Car();
            myThirdCar.Make = "Ford";
            myThirdCar.Model = "Crown Vic";
            myThirdCar.Year = "1994";
            myThirdCar.EngineNoise = "BRRRTTUMTUMTUMTUM";
            myThirdCar.HonkNoise = "HONK!";
            myThirdCar.IsDriveable = false;
            myCarLot.CarList.Add(myThirdCar);
            //Call each of the methods for each car
            myFirstCar.MakeEngineNoise(myFirstCar.EngineNoise);
            myFirstCar.MakeHonkNoise(myFirstCar.HonkNoise);
            mySecondCar.MakeEngineNoise(mySecondCar.EngineNoise);
            mySecondCar.MakeHonkNoise(mySecondCar.HonkNoise);
            myThirdCar.MakeEngineNoise(myThirdCar.EngineNoise);
            myThirdCar.MakeHonkNoise(myThirdCar.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in myCarLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} \nMake: {car.Make} \nModel: {car.Model}");
            }
        }
    }
}
