using System; 

class URI {

    static void Main(string[] args) { 

        double R = double.Parse(Console.ReadLine());
        
        double R2 = R * R;
        double A = 3.14159 * R2;
        
        Console.WriteLine($"A={A:F4}");
        
    }

}