using ClassesExercise;

int carNum = 1;

Car car1 = new Car();
car1.Make = "Tesla";
car1.Model = "Model S";
car1.Year = 3000;
car1.ItemNum = carNum++;

var car2 = new Car();
car2.Make = "Ford";
car2.Model = "Focus";
car2.Year = 2222;
car2.ItemNum = carNum++;

car1.Print();
car2.Print();

var joseCar = new Car()
{
    Make = "Bettle",
    Model = "VW",
    ItemNum = carNum++
};
joseCar.Print();

var car3 = new Car();
car3.Print();
