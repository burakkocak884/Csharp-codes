using System;

namespace Csharp_codes
{

      
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    var number = int.Parse("abcdfr");
                 Console.WriteLine(number);
                }
                catch(Exception)
                {
                Console.WriteLine("Conversion failed..");
                }
           // int number; 
            //var result = int.TryParse("abc", out number);
            //if(result)
            //Console.WriteLine(number);
           // else
          //  Console.WriteLine("Conversion failed.");

        }
         
         
         
         static void UseParams()
            {
                var calculator =  new Calculator();
                Console.WriteLine(calculator.Add(1,2));
                Console.WriteLine(calculator.Add(1,2,3));
                Console.WriteLine(calculator.Add(1,2,3,4));
                Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5}));

            }
            
            
            static void UsePoints()
            {
             try
            {
                
           
           var point = new Point(10,20);
           Console.WriteLine("POINT IS AT ({0} , {1})", point.X, point.Y);
           point.Move(null);
           Console.WriteLine("POINT IS AT ({0} , {1})", point.X, point.Y);

           point.Move(100, 200);
           Console.WriteLine("POINT IS AT ({0} , {1})", point.X, point.Y);
        }
        catch (Exception)
        {
        Console.WriteLine("An unexpected Error in handling");
        }
            }
        }
    }

