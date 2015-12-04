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

        public Array TransferIntToArray(string value)
        {
            string row = Convert.ToString(value);                //the number is a string
            double[] arrayNew = new double[row.Length];          //an empty array with type double

            for (int i = 0; i < row.Length; i++)
            {
                arrayNew[i] = row[i];
                Console.WriteLine("array[i] is " + row[i] + " " + row.Length);
                Console.ReadKey();
                Console.WriteLine("arrayNew[i] is " + arrayNew[i]);
                Console.ReadKey();
            }
            return arrayNew;
     
        }

        public int MinMax(Array arrayInput)
        {
            Array arrayLocal = arrayInput;
            double min = (double)arrayLocal.GetValue(0);
            double max = (double)arrayLocal.GetValue(0);
            int indexMin = 0;
            int indexMax = 0;
            double correction = 48;

            for (int i = 1; i < (arrayLocal.Length - 1); i++)
            {
                if ((double)arrayLocal.GetValue(i) < min)
                {
                    min = (double)arrayLocal.GetValue(i);
                    indexMin = i;
                }
                if ((double)arrayLocal.GetValue(i) > max)
                {
                    max = (double)arrayLocal.GetValue(i);
                    indexMax = i;
                }
            }
            if (indexMax > indexMin)
            {
                Console.WriteLine("Минимальное значение " + (min - correction) + " левее");
            }
            else
            {
                Console.WriteLine("Максимальное значение " + (max - correction) + " левее");
            }
            return indexMax;
        }
        static void Main(string[] args)
        {
            string n;
            Array myArray;
            int result;

            Console.Write("Enter an integer number: ");
            n = Console.ReadLine();
            LeftMinMax lmm = new LeftMinMax();
            myArray = lmm.TransferIntToArray(n);
            result = lmm.MinMax(myArray);
            Console.ReadKey();
        }
    }
}