using StringManipulation.BusinessLogic;
using StringManipulation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Models
{
    class Exercise1 : IExercise1
    {
        protected internal static List<int> numbersInputed = new List<int>();
        protected internal static List<int> randomNum = new List<int>();

        public Exercise1()
        {
            AskSixInts();
        }

        public void AskSixInts()
        {
            Console.WriteLine("Give 6 integers :");

            for (int i = 0; i < 6; i++)
            {

                numbersInputed.Add(Int32.Parse(Console.ReadLine()));
            }
            GenerateRandomNums();
        }

        public void GenerateRandomNums()
        {
            var rondomNumber = new Random();
            for (int i = 0; i < numbersInputed.Count; i++)
            {
                randomNum.Add(rondomNumber.Next(0, Math.Abs(numbersInputed[i])));
            }
            PrintSumOfListElements();
        }

        public void InsertNumbersToList()
        {
            throw new NotImplementedException();
        }

        public void PrintSumOfListElements()
        {
            Console.WriteLine(randomNum.Sum());
        }

        public void RearrangeToDescending()
        {
           randomNum.Sort();
        }
    }
}
