using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //ctrl+k+c yorum satırına al. ctrl+k+u yorum satırını kaldır.

            //string[] isimler = new string[] { "engin", "mehmet", "kerem" };
            ////console.writeline(isimler[0]);

            //isimler = new string[4];
            //isimler[3] = "ahmet";
            //console.writeline(isimler[2]);


            List<string> isimler2 = new List<string> { "Ahmet","Eren"};
            isimler2.Add("Engin");
            Console.WriteLine(isimler2[2]);

            List<int> ints = new List<int> { 1, 2, 3, 4 };
            ints.Add(1);
            Console.WriteLine(ints[0]);
            Console.WriteLine(ints[4]);

        }
    }
}