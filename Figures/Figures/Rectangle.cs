namespace Task_1.Figures
{
    class Rectangle : Figures
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public override double GetArea() => Width * Height;
        public override double GetPerimetr() => Width * 2 + Height * 2;
    }
}
