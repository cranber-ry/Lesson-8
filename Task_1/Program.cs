using Task_1;

Dog dog = new Dog();

Console.WriteLine("Как зовут собаку?");
var name = Console.ReadLine();
dog.SetName(name);
dog.GetName();
dog.Eat();