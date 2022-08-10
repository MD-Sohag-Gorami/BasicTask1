using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class Loop
    {
        public void LoopImplementation()
        {
            Console.WriteLine("For Loop ");
            for(int i = 1; i <= 100; i ++)
            {
                if (i == 95) continue;
                
                Console.Write(" " + i);
                if (i == 99) break;
            }
            Console.WriteLine();
            Console.WriteLine("While Loop ");
            int num = 0;
            while(num <= 100)
            {
                num++;
                if (num == 95) continue;
               
                Console.Write(" " + num);
                if (num == 99) break;
            }
            Console.WriteLine();
            Console.WriteLine("Do While Lopp");
            int cnt = 0;

            do
            {
                cnt++;
                if (cnt == 95) continue;
                
                Console.Write(" " + cnt);
                if (cnt == 99) break;
            }
            while (cnt <= 100);
            Console.WriteLine();
           
            


        }
    }
}
