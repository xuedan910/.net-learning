using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightChess
{
    class Program
    {
        static int[] Map=new int[100];
        static void Main(string[] args)
        {
            GameHeader();
            InitialMap();

            Console.ReadKey();
        }

        public static void GameHeader()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********Flight Chess********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************");
        }
        public static void InitialMap()
        {
            int[] luckyTurn = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckyTurn.Length; i++)
            {
                Map[luckyTurn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < landMine.Length; i++)
            {
                Map[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                Map[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Map[timeTunnel[i]] = 4;
            }
        }
    }
}
