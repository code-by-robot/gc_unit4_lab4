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

Car.ListCars(cars);