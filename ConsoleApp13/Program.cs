using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            Console.WriteLine("the first numper");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("the last numper");
            int y = int.Parse(Console.ReadLine());
            for(int i=x;i<=y;i++)
            {
                for(int j=2;j<=y;j++)
                {
                    if((i!=j&&i%j==0)||i==1)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime)
                {
                    Console.WriteLine("\t" + i);
                }
                isprime = true;
            }
        }
    }
}
