using System;

namespace Employee_Attendnence
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPresent)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
