using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
           var list = new ArrayList();
           list.Add(1);
           list.Add("Burak");
           list.Add(DateTime.Today);

           var anotherList = new List<int>();
           anotherList.Add();
           var names = new List<string>();
           names.Add("Lena");
        }
    }
}
