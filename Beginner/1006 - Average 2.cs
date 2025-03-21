using System;
 
class URI {
 
    static void Main(string[] args) {
 
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double M = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0 ;
        Console.WriteLine($"MEDIA = {M:F1}");
 
    }
 
}