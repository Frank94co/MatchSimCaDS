using MatchSimCaDSLibrary.Nivel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchSimCaDSLibrary.Competencia
{
    public class Copa
    {
        public static string PartidoEquipos(bool neutral, Equipo local, Equipo visitante, out bool ganadorLocal)
        {
            string resultado = "";
            byte resLocal = 0;
            byte resVisitante = 0;

            if (neutral)
            {
                resLocal = Neutral();
                resVisitante = Neutral();
            }
            else
            {
                short diferencia = (short)(local.Nivel - visitante.Nivel);
                switch (diferencia)
                {
                    case -3:
                        resLocal = Base.Copa();
                        resVisitante = Alto.Copa();
                        break;
                    case -2:
                        resLocal = Base.Copa();
                        resVisitante = Medio.Copa();
                        break;
                    case -1:
                        resLocal = Base.Copa();
                        resVisitante = Bajo.Copa();
                        break;
                    case 0:
                        resLocal = Base.Copa();
                        resVisitante = Base.Copa();
                        break;
                    case 1:
                        resLocal = Bajo.Copa();
                        resVisitante = Base.Copa();
                        break;
                    case 2:
                        resLocal = Medio.Copa();
                        resVisitante = Base.Copa();
                        break;
                    case 3:
                        resLocal = Alto.Copa();
                        resVisitante = Base.Copa();
                        break;
                    default:
                        if (diferencia <= -4)
                        {
                            resLocal = Base.Copa();
                            resVisitante = Estelar.Copa();
                        }
                        else
                        {
                            resLocal = Estelar.Copa();
                            resVisitante = Base.Copa();
                        }
                        break;
                }
            }
            resultado = $"{local} {resLocal}-{resVisitante} {visitante}. ";
            if (resLocal > resVisitante)
            {
                ganadorLocal = true;
            }
            else if (resLocal < resVisitante)
            {
                ganadorLocal = false;
            }
            else
            {
                var tanda = EjecutarTandaPenaltis();
                resultado += $"En la tanda quedaron {tanda.Item1}-{tanda.Item2}, después de {tanda.Item3} penaltis lanzados.";
                if (tanda.Item1 > tanda.Item2)
                {
                    ganadorLocal = true;
                }
                else
                {
                    ganadorLocal = false;
                }
            }
            return resultado.Trim();
        }

        public static string Partido(bool neutral, ushort nivelLocal, ushort nivelVisitante)
        {
			string resultado = "";
			byte resLocal = 0;
            byte resVisitante = 0;

            if (neutral)
            {
				resLocal = Neutral();
				resVisitante = Neutral();
            }
            else
            {
                short diferencia = (short)(nivelLocal - nivelVisitante);
                switch (diferencia)
                {
                    case -3:
                        resLocal = Base.Copa();
                        resVisitante = Alto.Copa();
                        break;
                    case -2:
                        resLocal = Base.Copa();
                        resVisitante = Medio.Copa();
                        break;
                    case -1:
                        resLocal = Base.Copa();
                        resVisitante = Bajo.Copa();
                        break;
                    case 0:
                        resLocal = Base.Copa();
                        resVisitante = Base.Copa();
                        break;
                    case 1:
                        resLocal = Bajo.Copa();
                        resVisitante = Base.Copa();
                        break;
                    case 2:
                        resLocal = Medio.Copa();
                        resVisitante = Base.Copa();
                        break;
                    case 3:
                        resLocal = Alto.Copa();
                        resVisitante = Base.Copa();
                        break;
                    default:
                        if (diferencia <= -4)
                        {
                            resLocal = Base.Copa();
                            resVisitante = Estelar.Copa();
                        }
                        else
                        {
                            resLocal = Estelar.Copa();
                            resVisitante = Base.Copa();
                        }
                        break;
                }
            }
			resultado = $"El partido quedó {resLocal}-{resVisitante}. ";
			if (resLocal == resVisitante)
			{
				var tanda = EjecutarTandaPenaltis();
				resultado += $"En la tanda quedaron {tanda.Item1}-{tanda.Item2}, después de {tanda.Item3} penaltis lanzados.";
			}
			return resultado.Trim();
		}
        private static byte Neutral()
        {
            Random random = new Random();
            byte equipo1 = 0;
            byte dado1 = (byte)(random.Next(100) + 1);

            if (dado1 < 27)
            {
                equipo1 += 0;
            }
            else if (dado1 < 58)
            {
                equipo1 += 1;
            }
            else if (dado1 < 81)
            {
                equipo1 += 2;
            }
            else if (dado1 < 92)
            {
                equipo1 += 3;
            }
            else if (dado1 < 98)
            {
                equipo1 += 4;
            }
            else if (dado1 < 100)
            {
                equipo1 += (byte)(4 + (byte)(random.Next(4) + 1));
            }
            else
            {
                equipo1 += (byte)(5 + (byte)(random.Next(4) + 1));
            }
            return equipo1;
        }

		private static Tuple<int, int, int> EjecutarTandaPenaltis()
		{
			int pLocal = 0, pVisitante = 0, diferenciaInt = 0, iaux = 0;
			for (int i = 1; i <= 5; i++)
			{
				iaux = i;
				Random random = new Random();
				int dadoLocal = random.Next(1000) + 1;
				int dadoVisitante = random.Next(1000) + 1;
				switch (i)
				{
					case 1:
						if (dadoLocal >= 206)
							pLocal++;
						if (dadoVisitante >= 206)
							pVisitante++;
						break;
					case 2:
						if (dadoLocal >= 206)
							pLocal++;
						if (dadoVisitante >= 206)
							pVisitante++;
						break;
					case 3:
						if (dadoLocal >= 274)
							pLocal++;
						if (dadoVisitante >= 274)
							pVisitante++;
						break;
					case 4:
						if (dadoLocal >= 236)
							pLocal++;
						if (dadoVisitante >= 236)
							pVisitante++;
						break;
					case 5:
						if (dadoLocal >= 160)
							pLocal++;
						if (dadoVisitante >= 160)
							pVisitante++;
						break;
				}
				diferenciaInt = Math.Abs(pLocal - pVisitante);
				if (diferenciaInt >= 3 && i >= 3)
					break;
				if (diferenciaInt >= 2 && i >= 4)
					break;
			}
			if (diferenciaInt > 0)
			{
				return new Tuple<int, int, int>(pLocal, pVisitante, iaux);
			}
			else
			{
				int penalLanzado = 6;
				while (diferenciaInt == 0)
				{
					Random random = new Random();
					int dadoLocal = random.Next(1000) + 1;
					int dadoVisitante = random.Next(1000) + 1;
					if (dadoLocal >= 327)
						pLocal++;
					if (dadoVisitante >= 327)
						pVisitante++;
					diferenciaInt = Math.Abs(pLocal - pVisitante);
					if (diferenciaInt > 0)
						break;
					else
						penalLanzado++;
				}
				return new Tuple<int, int, int>(pLocal, pVisitante, penalLanzado);
			}
		}
	}
}
