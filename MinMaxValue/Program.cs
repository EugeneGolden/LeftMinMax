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

        public Array TransferIntToList(int value)
        {
            string row = Convert.ToString(value);          //the number is a string
            char[] array = row.ToCharArray();              //the string is an array
            int[] arrayNew = new int[row.Length];          //an empty array

            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = (int)array[i];
            }
            return arrayNew;
        }

        public int MinMax(Array arrayInput)
        {
            Array arrayLocal = arrayInput;
            int min = (int)arrayLocal.GetValue(0);
            int max = (int)arrayLocal.GetValue(0);
            
            for (int i = 1; i < (arrayLocal.Length - 1); i++)
            {
                if ((int)arrayLocal.GetValue(i) < min)
                {
                    min = (int)arrayLocal.GetValue(i);
                }
            }
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
