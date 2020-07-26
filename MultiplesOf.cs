using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Project_Euler
{
    public static class MultiplesOf
    {
        public static void Start()
        {
            Console.WriteLine("Эта программа находит сумму всех чисел кратных х и y, которые меньше z");
            Console.WriteLine("Вам будет предложенно ввести три целых числа");
            Action();
        }

        public static List<int> Action()
        {
            List<int> inputMultiplse = new List<int>();
            string input;

            do
            {
                Console.WriteLine("Введите число: ");
                input = Console.ReadLine();
                inputMultiplse.Add(Convert.ToInt32(input));
            } while (inputMultiplse.Count < 3);

            inputMultiplse.ForEach(Console.WriteLine);


            return inputMultiplse;
        }
    }
}
