using System;
using System.Data;

class MyClass
{
    public int number;
    public MyClass(int n)
    {
        number = n;

    }
    public override string ToString()
    {
        return "Pole number: " + number;
    
    }
    public static MyClass operator+(MyClass a,MyClass b)
    {
        int m = a.number + b.number;
        MyClass t = new MyClass(m);
        return t;
    }
    public static MyClass operator+(MyClass a,int x)
    {
        int m=a.number+x;
        return new MyClass(m);
    }
    
    
    
    public static MyClass operator+(int x,MyClass a)
    {
        return a + x;
    }
    public static int operator+(MyClass a)
    {
        return a.number;
    }
}
class MoreOverloadingPlusDemo
{


    static void Main()
    {
        MyClass  A = new MyClass(100);
        MyClass  B= new MyClass(200)            ;
        MyClass C = A = B;
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
        C = A + 1;
        Console.WriteLine(C);
        C = 10 + A;
        Console.WriteLine(C);
        Console.Write("Unarnii operator: ");
        Console.WriteLine(+C);
        int num=(+A)+(+B);
        Console.WriteLine("Summa chisel: "+num);
    }
}