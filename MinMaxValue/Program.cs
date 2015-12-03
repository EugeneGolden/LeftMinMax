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

        public Array TransferIntToArray(int value)
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
            int indexMin = 0;
            int indexMax = 0;
            
            for (int i = 1; i < (arrayLocal.Length - 1); i++)
            {
                if ((int)arrayLocal.GetValue(i) < min)
                {
                    min = (int)arrayLocal.GetValue(i);
                    indexMin = i;
                }
                if ((int)arrayLocal.GetValue(i) > max)
                {
                    max = (int)arrayLocal.GetValue(i);
                    indexMax = i;
                }
            }
            if (indexMax > indexMin)
            {
                Console.WriteLine("Минимальное значение " + min + " левее");
            }
            else
            {
                Console.WriteLine("Максимальное значение " + max + " левее");
            }
            return max;
        }
        static void Main(string[] args)
        {
            int n;
            ArrayList myList;
            Array myArray;
            int result;
            
            Console.Write("Enter an integer number: ");
            n = int.Parse(Console.ReadLine());
            LeftMinMax lmm = new LeftMinMax();
            myArray = lmm.TransferIntToArray(n);
            result = lmm.MinMax(myArray);
            Console.ReadKey();


        }
    }
}
