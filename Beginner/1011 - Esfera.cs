using System; 

class URI {

    static void Main(string[] args) { 

        double Raio = double.Parse(Console.ReadLine());
        
        double Volume = (4.0/3.0) * 3.14159 * (Raio*Raio*Raio);
        
        Console.WriteLine($"VOLUME = {Volume:F3}");
        
    }

}