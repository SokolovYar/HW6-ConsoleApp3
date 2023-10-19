using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    internal class MyArray : IOutput2
    {
        int[] _array;
        public MyArray(int[] array) { _array = array; }
        public MyArray() { _array = new int[0]; }
        public MyArray(int arrayLength) //конструктор с рандомайзером
        {
            if (arrayLength < 0) throw new IndexOutOfRangeException("Array length can`t be less than zero!");
            _array = new int[arrayLength];
            Random r = new Random();
            for (int i = 0; i < arrayLength; i++)
                _array[i] = r.Next(-10, 11);
        }

        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            temp.Capacity = _array.Length;

            foreach (var item in _array)
                temp.Append(item + "; ");
            return Convert.ToString(temp);
        }

        public void ShowEven()
        {
            for (int i = 0; i < _array.Length; i++)
                if ((_array[i] % 2) == 0) Console.Write(_array[i] + "; ");
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            for (int i = 0; i < _array.Length; i++)
                if (_array[i] % 2 != 0) Console.Write(_array[i] + "; ");  
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray test = new MyArray(10);
            Console.WriteLine(test);

            test.ShowEven();
            test.ShowOdd();
        }
    }
}
