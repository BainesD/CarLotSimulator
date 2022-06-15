using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            CarLot myCarLot = new CarLot();
            Car myFirstCar = new Car { Year = "2005", Make = "Dodge", Model = "Dakota", EngineNoise = "brrrrrm", HonkNoise = "BEEP!", IsDriveable = false };
            myCarLot.CarList.Add(myFirstCar);
            Console.WriteLine($"There is {CarLot.numberOfCars} car in the car lot.");
            Car mySecondCar = new Car("Dodge", "Durango", "2010", "putputputputput", "HONK!", false);
            myCarLot.CarList.Add(mySecondCar);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the car lot.");
            Car myThirdCar = new Car();
            myThirdCar.Make = "Ford";
            myThirdCar.Model = "Crown Vic";
            myThirdCar.Year = "1994";
            myThirdCar.EngineNoise = "BRRRTTUMTUMTUMTUM";
            myThirdCar.HonkNoise = "HONK!";
            myThirdCar.IsDriveable = false;
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the car lot.");
            myCarLot.CarList.Add(myThirdCar);
            //Call each of the methods for each car
            myFirstCar.MakeEngineNoise(myFirstCar.EngineNoise);
            myFirstCar.MakeHonkNoise(myFirstCar.HonkNoise);
            mySecondCar.MakeEngineNoise(mySecondCar.EngineNoise);
            mySecondCar.MakeHonkNoise(mySecondCar.HonkNoise);
            myThirdCar.MakeEngineNoise(myThirdCar.EngineNoise);
            myThirdCar.MakeHonkNoise(myThirdCar.HonkNoise);

            foreach (var car in myCarLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} \nMake: {car.Make} \nModel: {car.Model}");
            }


        }
    }
}
