using Cars;


List<Car> cars = new List<Car>()
{
    new UsedCar("Toyota", "Corolla", 2020, 30000, 15000.60),
    new Car("Toyota", "Camry", 2022, 40000),
    new Car("Audi\t", "A8", 2023, 80000),
    new Car("Audi\t", "A4", 2018, 50000),
    new UsedCar("Nissan", "Altima", 2020, 40000, 20000),
    new UsedCar("Mazda\t", "3", 2020, 28000, 12000)
};

bool runProgram = true;
while (runProgram==true)
{
    Car.ListCars(cars);
    bool buySellOption = Validator.Validator.GetContinue("Are you looking to buy or sell?", "buy", "sell");
    if (buySellOption == true)
    {
        while (true)
        {
            Console.WriteLine("Which car would you like to buy? (enter a number)");
            if (int.TryParse(Console.ReadLine(), out int userNumber) == true && Validator.Validator.InRange(userNumber, 1, cars.Count()+1) == true)
            {
                Console.WriteLine(cars[userNumber-1].ToString());
                Console.WriteLine();
                cars.Remove(cars[userNumber-1]);
                Car.ListCars(cars);
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        runProgram = Validator.Validator.GetContinue("Would you like to buy another car?");
    }
    else
    {
        Console.WriteLine("Please enter the make, model, asking price, year, and mileage of your car separated by spaces.");
        string[] userData = Console.ReadLine().Trim().Split(" ");
        UsedCar carToBeSold = new UsedCar(userData[0], userData[1], int.Parse(userData[2]), decimal.Parse(userData[3]), double.Parse(userData[4]));
        Car.BuyBack(carToBeSold, cars);
    }
    
}

