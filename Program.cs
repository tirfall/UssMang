using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UssMang
{
    public class Program
    {
        public static void Main()
        {
            switch (Menu())
            {
                case 1:
                    break; 
                case 2:
                    switch (pezim.Reziim())
                    {
                        case 1:
                            Kiirendatud.kiirem();
                            break;
                        case 2:
                            Classic.classic();
                            break;
                        case 3:
                            Laiendatud.laiend();
                            break;
                    }
                    break; 
                case 3:
                    

                    break;
                default: break;
            }

        }
        

       public static int Menu() {
            Console.SetWindowSize(30, 30);
            Console.WriteLine("Menu\n1. Registreeri\n2. Alustada mäng\n3. Sätted\n4. Vaatada rekordid \n5. Mine välja");
            int ans = Int32.Parse(Console.ReadLine());
            return ans;
        }
    }
}