using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UssMang
{
    internal class pezim
    {
        public static int Reziim()
        {
            switch (reziim())
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;

                default: return 101;
            }

        }


        public static int reziim()
        {
            Console.SetWindowSize(30, 30);
            Console.WriteLine("Menu\n1. Kiirendatud\n2. Classic\n3. Laiendatud\n");
            int ans = Int32.Parse(Console.ReadLine());
            return ans;
        }
    }
}
