namespace Task_1.Figures
{
    class Circle : Figures
    {
        public float Radius { get; set; }

        public override double GetPerimetr() => Radius * 2 * Math.PI;
        public override double GetArea() => Math.Pow(Radius, 2) * Math.PI;

    }
}
