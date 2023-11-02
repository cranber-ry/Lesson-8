namespace Task_1.Figures
{
    class Treangle : Figures
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public override double GetArea() => A + B + C;
        public override double GetPerimetr() => Math.Sqrt((GetArea() / 2) * ((GetArea() / 2) - A) * ((GetArea() / 2) - B) * (GetArea() / 2) - C);
    }
}
