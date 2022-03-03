using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI
{
    static class Les2
    {
        public static int[,] StedenKM = new int[,]
        {
            {0,50,135,120,65,65 },
            {50,0,140,75,20,70 },
            {135,140,0,220,170,75 },
            {120,75,220,0,55,145 },
            {65,20,170,55,0,90 },
            {65,70,75,145,90,0 }
        };
        public static String[] Steden = new string[]
            {
        "Arnhem",
        "Amersfoort",
        "Assen",
        "Rotterdam",
        "Utrecht",
        "Zwolle"
            };
        public static void calcMinDist()
        {
            int res = 0;
            int Total = 0;
            for (int i = 0; i < StedenKM.GetLength(0); i++)
            {
                int Calc = 0;
                for (int j = 0; j < StedenKM.GetLength(1); j++)
                {
                    Calc += StedenKM[i, j];
                }
                if(Total < Calc)
                {
                    res = i;
                    Total = Calc;
                }
            }
            Console.WriteLine($"Het beste is als in: {Steden[res]} een les wordt gegeven omdat dit over het algemeen de minste afstand is voor de meeste studenten.");
        }
    }
}
