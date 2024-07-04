using System;

namespace inheritance
{ 
    public class Inheritance
    {
    }
  



     class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.ParentalProperty = "Cheyya aapan ko paisay aabbu ka";
            Console.WriteLine(c.ParentalProperty);
            Console.ReadKey();
        }
    }
}
