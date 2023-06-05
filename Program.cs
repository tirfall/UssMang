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
        public static void Main(string[] args)
        {
            switch (Menu())
            {
                case 1:
                    break; 
                case 2:
                    break; 
                case 3:
                    Classic.classic();

                    break;
                default: break;
            }

        }
        

       public static int Menu() {
            Console.SetWindowSize(30, 30);
            Console.WriteLine("Menu\n1. Registreeri\n2. Mängu režiimid\n3. Alustada mäng\n4. Sätted\n5. Vaatada rekordid \n6. Mine välja");
            int ans = Int32.Parse(Console.ReadLine());
            return ans;
        }
    }
}