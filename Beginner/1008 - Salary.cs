using System; 

class URI {

    static void Main(string[] args) { 

        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        
        decimal Sal = B * C;
        
        Console.WriteLine($"NUMBER = {A}");
        Console.WriteLine($"SALARY = U$ {Sal:F2}");

    }

}