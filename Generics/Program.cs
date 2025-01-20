using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> citys = new List<string>();
            citys.Add("İzmir");
            citys.Add("İzmir");
            citys.Add("İzmir");
            citys.Add("İzmir");
            citys.Add("İzmir");

            MyList<string> citys2 = new MyList<string>();
            citys2.Add("İstanbul");
            citys2.Add("İstanbul");
            citys2.Add("İstanbul");
            citys2.Add("İstanbul");

        }
    }

    class MyList<T> //Generic class
    {
        public void Add(T item) { 
        }
    }

}
