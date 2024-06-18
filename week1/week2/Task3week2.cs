using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteAcademy.week2
{
    internal class Task3week2
    {
        static void Main(string[] args)
        {
            int a = 1221;
            string b = a.ToString();

            if (b[0] == b[3] && b[1] == b[2])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

    }
}
