using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] GetArray(int length)
            {
                int[] array = new int[length];

                Random r = new Random();
                for (int i = 0; i < length; i++)
                {
                    array[i] = r.Next(1, 999);
                }

                return array;
            }

            //____________________________________________________________________________________________________________________________________

            // int[] numbers = GetArray(5);
            // int i = 0;
            // int x = 0;

            // while (i < numbers.Length){
            //     if(numbers[i] % 2 == 0){
            //         x++;
            //         Console.WriteLine(numbers[i]);
            //         i++;
            //     }
            //     else {
            //         Console.WriteLine(numbers[i]);
            //         i++;
            //     }
            // }
            // Console.WriteLine(x);
            //________________________________________________________________________________________________________________________________________

            // int[] numbers = GetArray(5);
            // int i = 0;
            // int sum = 0;
            // while (i < numbers.Length){
            //     Console.Write(numbers[i]+", ");
            // if(numbers[i] % 2 == 1){
            //     sum = sum + numbers[i];
            //     i++;
            // }
            // else{
            //     i++;
            // }
            // }
            // Console.WriteLine(sum);

            //__________________________________________________________________________________________________________________________________________

            int[] numbers = GetArray(5);
            int i = 0;
            int max = 0;
            int min = 0;
            min = numbers[i];
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + ", ");
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    i++;
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine($"{max} - {min} = {max - min}");

            //░░░░░░░░░░░░▄▐░░░░░
            //░░░░░░▄▄▄░░▄██▄░░░░
            //░░░░░▐▀█▀▌░░░░▀█▄░░
            //░░░░░▐█▄█▌░░░░░░▀█▄
            //░░░░░░▀▄▀░░░▄▄▄▄▄▀▀
            //░░░░▄▄▄██▀▀▀▀░░░░░░
            //░░░█▀▄▄▄█░▀▀░░░░░░░
            //░░░▌░▄▄▄▐▌▀▀▀░░░░░░
            //▄░▐░░░▄▄░█░▀▀░░░░░░
            //▀█▌░░░▄░▀█▀░▀░░░░░░
            //░░░░░░░▄▄▐▌▄▄░░░░░░
            //░░░░░░░▀███▀█░▄░░░░
            //░░░░░░▐▌▀▄▀▄▀▐▄░░░░
            //░░░░░░▐▀░░░░░░▐▌░░░
            //░░░░░░█░░░░░░░░█░░░
            //░░░░░▐▌░░░░░░░░░█░░
            //░░░░░█░░░░░░░░░░▐▌░
            //░░░░░I HAVE AIDS░░░


        }
    }
}
