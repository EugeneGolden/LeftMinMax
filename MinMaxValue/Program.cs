using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MinMaxValue
{
    class LeftMinMax
    {
        //Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная

        public ArrayList TransferIntToList(int value)
        {
            ArrayList arrList = new ArrayList();            //an empty list
            string row = Convert.ToString(value);           //the number as a string
            char[] array = row.ToCharArray();               //now the string as an array

            for (int i = 0; i < array.Length; i++)
            {
                arrList.Add(array[i]);
            }
            return arrList;
        }
        static void Main(string[] args)
        {
            int n;
            ArrayList myList;
            Console.Write("Enter an integer number: ");
            n = int.Parse(Console.ReadLine());
            LeftMinMax lmm = new LeftMinMax();
            myList = lmm.TransferIntToList(n);
            var count = myList.Count;
            Console.WriteLine(myList);
            Console.ReadKey();


        }
    }
}
