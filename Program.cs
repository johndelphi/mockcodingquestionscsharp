using System;
using System.Collections.Generic;

namespace mockcodingquestionscsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //prime numbers 
            //examples of prime numbers 2,3,5,7


            Console.WriteLine("ENTER PRIME NUMBER LIMIT");
            int MaxNumber = Convert.ToInt32(Console.ReadLine());
            //loop responsible for checking the max number 
            for (int i =2; i<=MaxNumber;i++)
            {
                if (i%2==0 &&i !=2)
                {
                    Console.WriteLine(i);
                }


            }
        }

    }

    }

