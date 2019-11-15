using System;

namespace Csharp_codes
{

      
    class Program
    {
        static void Main(string[] args)
        {
           var point = new Point(10,20);
           point.Move(new Point(40, 60));
           Console.WriteLine("POINT IS AT ({0} , {1})", point.X, point.Y);

           point.Move(100, 200);
          Console.WriteLine("POINT IS AT ({0} , {1})", point.X, point.Y);
        }
    }
}
