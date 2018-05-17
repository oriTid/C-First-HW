using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCsharp
{
    class Program
    {
        private static bool Calculate(int num1, int num2)
        {
            return Convert.ToBoolean((num1 + num2) % 2);
        }


        static void Main(string[] args)
        {
            bool flag = true;
            string str = "";
            int[] userArr = new int[8];
            int counter = 0;
            do
            {
                if (flag) Console.WriteLine("Please enter a number:");
                else Console.WriteLine($"{str} is not a number please re-enter a number:");

                str = Console.ReadLine();
                int i;
                for (i = 0; i < str.Length; i++)
                {
                    //check if current char is numeric
                    if (!(str[i] >= 48 && str[i] <= 57))
                    {
                        break;
                    }
                }
                flag = (i == str.Length);
                if (flag)
                {
                    userArr[counter++] = Convert.ToInt32(str);
                }


            } while (counter < 8);

            for (int j = 0; j < userArr.Length - 2; j++)
                if (Calculate(userArr[j], userArr[j + 1]))
                {
                   Console.WriteLine($"Array index [{j}]={userArr[j]}, index [{j + 1}]={userArr[j + 1]} ---> Sum {userArr[j]+userArr[j + 1]} is Odd!!");
                }


            Console.ReadLine();

        }


    }
}