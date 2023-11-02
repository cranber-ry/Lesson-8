using Task_1.Figures;

Task_1.Figures.Figures[] figures = new Task_1.Figures.Figures[5];
figures[0] = new Circle
{
    Radius = 10
};
figures[1] = new Rectangle
{
    Height = 12,
    Width = 12
};
figures[2] = new Treangle
{
    A = 35,
    B = 45,
    C = 55
};
figures[3] = new Rectangle
{
    Height = 65,
    Width = 56
};
figures[4] = new Treangle
{
    A = 10,
    B = 5,
    C = 15
};

for (var i = 0; i < figures.Length; i++)
{
    if (figures[i] is Circle)
    {
        Console.WriteLine($"Площадь круга равна {Math.Round(figures[i].GetArea(), 2)}\n" +
            $"Периметр круга равен {Math.Round(figures[i].GetPerimetr(), 2)}\n");
    }
    else if (figures[i] is Rectangle)
    {
        Console.WriteLine($"Площадь прямоугольника равна {Math.Round(figures[i].GetArea(), 2)}\n" +
                    $"Периметр прямоугольника равен {Math.Round(figures[i].GetPerimetr(), 2)}\n");
    }
    else if (figures[i] is Treangle)
    {
        Console.WriteLine($"Площадь треугольника равна {Math.Round(figures[i].GetArea(), 2)}\n" +
                    $"Периметр треугольника равен {Math.Round(figures[i].GetPerimetr(), 2)}\n");
    }
}

double totalPerimetr = 0;
foreach (Task_1.Figures.Figures figure in figures)
{
    totalPerimetr += figure.GetPerimetr();
}
Console.WriteLine($"Сумма периметров всех фигур равна {Math.Round(totalPerimetr, 2)}");