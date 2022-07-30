using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap vao so cau hoi: ");
        float numQuestion = float.Parse(Console.ReadLine());
        float diem1Cau = 10 / numQuestion;
        Console.Write("Diem cua moi cau bang: ");
        Console.WriteLine(diem1Cau);
        Console.Write("Diem cua ban la: ");
        float diemCuaBan = diem1Cau * correctAnwers;
    }
}