using System;

abstract class Figure
{
    public abstract void Area();      // 넓이를 구하는 메소드 
    public abstract void Girth();     // 둘레를 구하는 메소드
    public abstract void Draw();      // 도형을 그리는 메소드 
}
class Squre : Figure
{
    double line1; // 사각형의 가로 길이
    double line2; // 사각형의 세로 길이
    public Squre(double line1, double line2) // 가로 길이와 세로 길이를 저장하는 생성자
    {
        this.line1 = line1;
        this.line2 = line2;
    }
    public override void Area() // override로 Area(), Girth(), Draw() 재정의
    {
        Console.WriteLine("사각형의 넓이 : {0}", line1 * line2);
    }
    public override void Girth()
    {
        Console.WriteLine("사각형의 둘레 : {0}", line1 * 2 + line2 * 2);
    }
    public override void Draw()
    {
        Console.WriteLine("사각형 그리기");
    }
}
class Circle : Figure
{
    double radius; // 원의 반지름 길이
    public Circle(double radius) // 원의 반지름 길이를 저장하는 생성자
    {
        this.radius = radius;
    }
    public override void Area() // override로 Area(), Girth(), Draw() 재정의
    {
        Console.WriteLine("원의 넓이 : {0}", radius * radius * 3.14);
    }
    public override void Girth()
    {
        Console.WriteLine("원의 둘레 : {0}", radius * 2 * 3.14);
    }
    public override void Draw()
    {
        Console.WriteLine("원 그리기");
    }
}

class Testclass
{
    public static void Main()
    {
        Console.Write("사각형의 가로길이를 입력하세요: ");
        double line1 = Double.Parse(Console.ReadLine());
        Console.Write("사각형의 세로길이를 입력하세요: ");
        double line2 = Double.Parse(Console.ReadLine());
        Console.Write("원의 반지름을 입력하세요: ");
        double radius = Double.Parse(Console.ReadLine());

        Figure s = new Squre(line1, line2);
        Figure c = new Circle(radius);

        s.Area();
        s.Girth();
        s.Draw();
        c.Area();
        c.Girth();
        c.Draw();
    }
}
