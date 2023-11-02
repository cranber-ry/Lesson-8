namespace Task_1
{
    abstract public class Animal
    {
        public string Name;

        public string SetName(string name)
        {
            Name = name;
            return Name;
        }

        public void GetName()
        {
            Console.WriteLine($"Имя собаки {Name}");
        }

        public abstract void Eat();
    }
}
