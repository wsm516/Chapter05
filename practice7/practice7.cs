using System;

class Temperature
{
    double degree;
    public Temperature(double degree) // 생성자 
    {
        this.degree = degree;
    }
    public double Degree // 프로퍼티 
    {
        get { return degree; }
    }
}
class Celsius : Temperature
{
    public Celsius(double t): base(t) { }
    public static explicit operator Celsius(double d) // double을 Celsius로 변환하는 형 변환 연산자 1-1
    {
        return new Celsius(d);
    }
    public static explicit operator Celsius(Fahrenheit f) // Fahrenheit를 Celsius로 변환하는 형 변환 연산자 1-2 
    {
        double d = (f.Degree - 32) * 5 / 9;
        return new Celsius(d);
    }
    public static explicit operator double(Celsius c) // Celsius를 double로 변환하는 형 변환 연산자 1-3
    {
        return c.Degree;
    }
}
class Fahrenheit : Temperature
{
    public Fahrenheit(double t) : base(t) { }
    public static explicit operator Fahrenheit(double d) // double을 Fahrenheit로 변환하는 형 변환 연산자 2-1
    {
        return new Fahrenheit(d);
    }
    public static explicit operator Fahrenheit(Celsius c) //Celsius를 Fahrenheit로 변환하는 형 변환 연산자 2-2 
    {
        double d = c.Degree * 9 / 5 + 32;
        return new Fahrenheit(d);
    }
    public static explicit operator double(Fahrenheit f) // Fahrenheit를 double로 변환하는 형 변환 연산자 2-3
    {
        return f.Degree;
    }
}
