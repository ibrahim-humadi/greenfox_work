Lines

public static void DrawGreenLines(FoxDraw foxDraw)
{
    foxDraw.SetStrokeColor(Colors.Green);
    foxDraw.DrawLine(0, 10, 100, 10);

    var startPoint = new Point(0, 20);
    var endPoint = new Point(100, 20);
    foxDraw.DrawLine(startPoint, endPoint);
}

Ellipse

public static void DrawEllipse(FoxDraw foxDraw)
{
    foxDraw.DrawEllipse(10, 10, 150, 50);
}

Rectangle

public static void DrawRectangle(FoxDraw foxDraw)
{
    foxDraw.DrawRectangle(10, 10, 150, 50);
}

Polygons

public static void DrawGreenPolygon(FoxDraw foxDraw)
{
    var points = new List<Point>();
    points.Add(new Point(10, 10));
    points.Add(new Point(40, 210));
    points.Add(new Point(170, 190));
    points.Add(new Point(130, 40));
    foxDraw.SetFillColor(Colors.Green);
    foxDraw.DrawPolygon(points);
}