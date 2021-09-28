using System;

namespace Dz_3
{
    class Program
    {
        static void ListNames(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static bool MyPred(string s)
        {
            return s[0] == 'a' || s[0] == 'A';
        }
        static void ShowSquares(int val)
        {
            Console.WriteLine("{0:d} squared = {1:d}", val, val * val);
        }
        static int QuantitySymbols(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int a = 7;
                //int count = 0;
                if (array[i].Length < a)
                {
                    count++;
                }
                //Console.WriteLine(" количество имен короче 7 символов = " + count);
            }
            return count; 
        }
        static int RepeatingElements(string[] array)
        {
            // сортировка
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        temp++;
                    }
                }
            }
            return temp;
            // вывод
            //Console.WriteLine(" Совпаших имен = " + temp + " ! ");
        }
        static void Main(string[] args)
        {
            #region

            //string[] myArr = new string[5] {"pАнатолий","Афанасий","Антон","Анна","Анна"};
            
            Console.Write(" Введите количество Имен - (желательно 12) : \t");
            int elementsCount = int.Parse(Console.ReadLine());

            string[] myArr = new string[elementsCount];
            for (int i = 0; i < myArr.Length; i++)
            {
                //Console.Write($"\nВведите имя по индексу {i}:\t");
                Console.Write("{0}-е Имя : ", i + 1);
                myArr[i] = (Console.ReadLine());
            }
            
            Console.Clear();
            ListNames(myArr); 
            
            Console.WriteLine("----------------------------------\n");
            
            Console.WriteLine("Проверить истинность того, \n\tчто все имена не начинаются с «А»\n");
            bool rezult = Array.TrueForAll(myArr, MyPred);
            if (rezult)
            {
                Console.WriteLine(" Имена нач. с «А»");
            }
            else
            {
                Console.WriteLine("Не все имена начинаются с «А»");
            }
            Console.WriteLine(Array.TrueForAll(myArr, MyPred));
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("---- Найти количество имен\n\t короче 7 символов ----\n");
            Console.WriteLine(" количество имен короче 7 символов = " + QuantitySymbols(myArr));
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("------ Проверить то, что есть имена,\n\t которые повторяются ------\n");
            Console.WriteLine(" Совпаших имен = " + RepeatingElements(myArr));
            
            
            
    
    

           
            
            #endregion
          

            
           

            Console.ReadLine();
        }
    }
}
