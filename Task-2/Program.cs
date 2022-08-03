using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;           
            string str = Console.ReadLine();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    cnt++;
                    Console.WriteLine("There is 'a' in the text");
                    break;
                }
            }
            if(cnt==0) Console.WriteLine("There isn't 'a' in the text");

        }
    }
}
