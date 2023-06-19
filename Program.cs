using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вывод_картинок
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int pictures = 52;
            string rowsWillTurnOut = Convert.ToString(pictures / picturesInRow);
            Console.Write("У вас получилось " + rowsWillTurnOut + " рядов,");
            string picturesDidntFit = Convert.ToString(pictures % picturesInRow);
            Console.WriteLine(" у вас не влезла " + picturesDidntFit + " картинок.");
        }
    }
}
