using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iz_bukv_v_cifrovoi_kod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вводится 5 символов - слово.
            Вывести в строчку коды букв этого слова.*/

            string s = Console.ReadLine();
            Console.WriteLine("{0} {1} {2} {3} {4}", (byte)s[0], (byte)s[1], (byte)s[2], (byte)s[3], (byte)s[4]);
        }
    }
}
