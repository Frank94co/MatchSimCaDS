// See https://aka.ms/new-console-template for more information
using MatchSimCaDSLibrary;
using MatchSimCaDSLibrary.Competencia;

string respuesta;
do
{
    Console.WriteLine("Bienvenido a MatchSimDalConsole, versión 0.0.1");
    Console.WriteLine("¿Qué quieres simular? (introduce el número)");
    Console.WriteLine("0) Nada");
    Console.WriteLine("1) Partido en campo neutral de Copa");
    Console.WriteLine("2) Partido con local y visitante (Liga)");
    Console.WriteLine("3) Partido de copa con local y visitante (sistema Dairos)");
    Console.WriteLine("4) Copa entera (sistema Dairos)");
    Console.WriteLine("5) Bug");
    Console.WriteLine("6) insultar a Frank");
    respuesta = Console.ReadLine();
    ushort eqLocal, eqVisitante, cLocal, cVisitante;
    if (respuesta != null)
    {
        switch (respuesta)
        {
            case "0":
                Console.WriteLine("Espero te haya servido el programa");
                break;
            case "1":
                char respuesta2;
                do
                {
                    ushort nLocal, nVisitante;
                    Console.WriteLine("¿De qué nivel es el primer equipo? (número del 1 al 5)");
                    ushort.TryParse(Console.ReadLine(), out nLocal);
                    Console.WriteLine("¿De qué nivel es el segundo equipo? (número del 1 al 5)");
                    ushort.TryParse(Console.ReadLine(), out nVisitante);
                    Console.WriteLine(Copa.Partido(true, nLocal, nVisitante));
                    Console.WriteLine("¿Quieres simular otro partido con este sistema? (S/N)");
                    respuesta2 = Console.ReadLine().ToUpper()[0];
                } while (respuesta2 == 'S');
                break;
            case "2":
                Console.WriteLine("¿De qué nivel es el equipo local? (número del 1 al 5)");
                ushort.TryParse(Console.ReadLine(), out eqLocal);
                Console.WriteLine("¿De qué nivel es el equipo visitante? (número del 1 al 5)");
                ushort.TryParse(Console.ReadLine(), out eqVisitante);
                Console.WriteLine($"El resultado es {Liga.Partido(eqLocal, eqVisitante)}");
                break;
            case "3":
                Console.WriteLine("¿De qué nivel es el equipo local? (número del 1 al 5)");
                ushort.TryParse(Console.ReadLine(), out eqLocal);
                Console.WriteLine("¿De qué nivel es el equipo visitante? (número del 1 al 5)");
                ushort.TryParse(Console.ReadLine(), out eqVisitante);
                Console.WriteLine(Copa.Partido(false, eqLocal, eqVisitante));
                break;
            case "4":
                List<Equipo> participantes = new List<Equipo>();
                Console.WriteLine("¿Cuántos equipos participarán?");
                short cantidad = Convert.ToInt16(Console.ReadLine());
                for (short i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Introduce el nombre del equipo {i + 1}");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("¿De qué nivel es? (número del 1 al 5)");
                    ushort nivel = Convert.ToUInt16(Console.ReadLine());
                    participantes.Add(new Equipo(nombre, (short)nivel));
                }
                CopaEntera(participantes);
                break;
            case "5":
                Console.WriteLine("Si encontraste algún bug, por favor avisa a @Frank9412_co en twitter. Envía pantallazo con lo que pasó y se intentará arreglar lo antes posible.");
                break;
            case "6":
                Console.WriteLine("Tus muertos pisaos");
                break;
            default:
                Console.WriteLine("Opción inválida. Inténtalo de nuevo");
                break;
        }
    }
} while (respuesta != "0");

void CopaEntera(List<Equipo> participantes)
{
    List<Equipo> ganadores = new List<Equipo>();
    _ = new Competencia((short)participantes.Count, participantes);
    if (participantes.Count == 1)
    {
        Console.WriteLine($"El ganador del torneo es: {participantes[0]}");
        return;
    }
    else
    {
        //Calcula la potencia de 2 mayor a la cantidad de participantes
        int potencia = (int)Math.Ceiling(Math.Log2(participantes.Count));
        int exentos = (int)(Math.Pow(2, potencia) - participantes.Count);
        if (exentos >= 0)
        {
            for (int i = 1; i <= exentos; i++)
            {
                participantes.Add(new Equipo("Bye", categoria: 6));
            }
        }

        short iteraciones = (short)(participantes.Count / 2);
        Random random = new Random();
        Equipo local, visitante;
        short aux;

        for (short i = 0; i < iteraciones; i++)
        {
            //programa los equipos exentos
            if (participantes.Find(e => e.Nombre == "Bye") != null)
            {
                aux = (short)random.Next(participantes.Count - exentos);
                int indiceBye = participantes.FindLastIndex(e => e.Nombre == "Bye");
                if (aux % 2 == 0)
                {
                    local = participantes[aux];
                    visitante = participantes[indiceBye];
                }
                else
                {
                    visitante = participantes[aux];
                    local = participantes[indiceBye];
                }
            }
            else
            {
                //de este bucle no se sale sino hasta que encuentre dos equipos que se llamen distinto
                do
                {
                    aux = (short)random.Next(participantes.Count);
                    local = participantes[aux];
                    aux = (short)random.Next(participantes.Count);
                    visitante = participantes[aux];
                } while (local.Nombre == visitante.Nombre);
            }
            participantes.Remove(local);
            participantes.Remove(visitante);

            if (local.Nombre == "Bye")
            {
                ganadores.Add(visitante);
                Console.WriteLine($"{visitante.Nombre} descansa");
            }
            else if (visitante.Nombre == "Bye")
            {
                ganadores.Add(local);
                Console.WriteLine($"{local.Nombre} descansa");
            }

            else
            {
                bool eLocal;
                string resultado = Copa.PartidoEquipos(false, local, visitante, out eLocal);
                if (eLocal)
                {
                    ganadores.Add(local);
                }
                else
                {
                    ganadores.Add(visitante);
                }
                Console.WriteLine(resultado);
            }
        }
    }
    Console.WriteLine("-------------------------------------------------");
    CopaEntera(ganadores);
}
