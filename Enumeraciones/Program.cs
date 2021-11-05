using System;

namespace Enumeraciones
{
    enum DiasSemana
    {
        Lunes=11,
        Martes,
        Miércoles=13,
        Jueves,
        Viernes,
        Sábado,
        Domingo=0
    }

    class Program
    {
        static void Main(string[] args)
        {
            for( int i=0; i <= 6; i ++  )
            {
                Console.WriteLine("El día de hoy es: {0}", DiasSemana.Lunes + i);
            }
            

            Console.ReadLine();

        }
    }


}
