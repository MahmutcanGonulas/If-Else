using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine("Time == "+time);

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Gunaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            //ternary if
            string sonuc= time<=18 ? "İyi günler" : "İyi geceler" ;

            sonuc= time>=6 && time<=11 ? "Günaydın": time<=18 ? "İyi günler": "İyi geceler";

            Console.WriteLine(sonuc);
        }
    }
}
