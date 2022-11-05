internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if (time>= 12 && time<= 15)
        Console.WriteLine("Öğlen!");
        
        else if(time<= 18)
        Console.WriteLine("İyi Günler!");
        else
        Console.WriteLine("İyi Geceler!");

        string sonuc = time<= 18 ? "İyi Günler" : "İyi Geceler";

        sonuc = time<= 15 ? "Öğlen": time<= 18 ? "İyi Günler": "İyi Geceler";

        Console.WriteLine(sonuc);

        
        

                
    
        
        












    }
}