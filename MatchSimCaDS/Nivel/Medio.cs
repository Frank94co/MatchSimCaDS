using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchSimCaDSLibrary.Nivel
{
    public class Medio
    {
        public static byte LocalLiga()
        {
            Random random = new Random();
            byte equipo1 = 0;
            byte dado1 = (byte)(random.Next(100) + 1);

            if (dado1 < 36)
            {
                equipo1 += 0;
            }
            else if (dado1 < 90)
            {
                equipo1 += 1;
            }
            else if (dado1 < 93)
            {
                equipo1 += 2;
            }
            else if (dado1 < 100)
            {
                equipo1 += 3;
            }
            else
            {
                equipo1 += 4;
            }
            return equipo1;
        }

        public static byte VisitanteLiga()
        {
            Random random = new Random();
            byte equipo1 = 0;
            byte dado1 = (byte)(random.Next(100) + 1);

            if (dado1 < 50)
            {
                equipo1 += 0;
            }
            else if (dado1 < 95)
            {
                equipo1 += 1;
            }
            else if (dado1 < 100)
            {
                equipo1 += 2;
            }
            else
            {
                equipo1 += 3;
            }
            return equipo1;
        }

        public static byte Copa()
        {
            Random random = new Random();
            byte equipo1 = 0;
            byte dado1 = (byte)(random.Next(100) + 1);

            if (dado1 < 19)
            {
                equipo1 += 0;
            }
            else if (dado1 < 44)
            {
                equipo1 += 1;
            }
            else if (dado1 < 69)
            {
                equipo1 += 2;
            }
            else if (dado1 < 85)
            {
                equipo1 += 3;
            }
            else if (dado1 < 93)
            {
                equipo1 += 4;
            }
            else if (dado1 < 97)
            {
                equipo1 += (byte)(4 + (byte)(random.Next(4) + 1));
            }
            else
            {
                equipo1 += (byte)(5 + (byte)(random.Next(4) + 1));
            }
            return equipo1;
        }
    }
}
