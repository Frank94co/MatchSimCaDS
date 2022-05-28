using MatchSimCaDSLibrary.Nivel;

namespace MatchSimCaDSLibrary
{
    public class Liga
    {
        public static string Partido(ushort nivelLocal, ushort nivelVisitante)
        {
            byte resLocal = 0;
            byte resVisitante = 0;

            short diferencia = (short)(nivelLocal - nivelVisitante);
            switch (diferencia)
            {
                case -3:
                    resLocal = Base.LocalLiga();
                    resVisitante = Alto.VisitanteLiga();
                    break;
                case -2:
                    resLocal = Base.LocalLiga();
                    resVisitante = Medio.VisitanteLiga();
                    break;
                case -1:
                    resLocal = Base.LocalLiga();
                    resVisitante = Bajo.VisitanteLiga();
                    break;
                case 0:
                    resLocal = Base.LocalLiga();
                    resVisitante = Base.VisitanteLiga();
                    break;
                case 1:
                    resLocal = Bajo.LocalLiga();
                    resVisitante = Base.LocalLiga();
                    break;
                case 2:
                    resLocal = Medio.LocalLiga();
                    resVisitante = Base.LocalLiga();
                    break;
                case 3:
                    resLocal = Alto.LocalLiga();
                    resVisitante = Base.LocalLiga();
                    break;
                default:
                    if (diferencia <= -4)
                    {
                        resLocal = Base.LocalLiga();
                        resVisitante = Estelar.VisitanteLiga();
                    }
                    else
                    {
                        resLocal = Estelar.LocalLiga();
                        resVisitante = Base.VisitanteLiga();
                    }
                    break;
            }

            return resLocal + "-" + resVisitante;
        }
    }
}