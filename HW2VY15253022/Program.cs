using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2VY15253022
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeyeEkleme<int> dList = new ListeyeEkleme<int>();

            dList.addOrdered(23);
            dList.addOrdered(11);
            dList.addOrdered(5);
            dList.addOrdered(9);
            dList.addOrdered(12);
            dList.addOrdered(6);
            dList.addOrdered(4);
            dList.addOrdered(12);
            dList.addOrdered(24);



            Console.WriteLine("\n");
            //Console.WriteLine(dList.find(12));
            Console.WriteLine("\n");
            dList.display();
            //dList.remove(12);
            Console.WriteLine();
          //  Console.WriteLine((dList.find(12)+"\n"));
           //// dList.remove(24);
            //dList.remove(23);
            //dList.remove(5);
            //dList.display();
            dList.remove(25);
            dList.display();
            dList.remove(24);
            dList.display();
            dList.remove(4);
            dList.display();
            dList.clear();
            dList.display();
           
        }
    }
}
