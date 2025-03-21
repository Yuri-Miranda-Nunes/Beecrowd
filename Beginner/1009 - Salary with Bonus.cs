using System; 

class URI {

    static void Main(string[] args) { 

        string Nome = Console.ReadLine();
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        
        double P = (15.00 * C) / 100.00;
        double S = B + P;
        
        Console.WriteLine($"TOTAL = R$ {S:F2}");

    }

}