using System;
using System.Collections.Generic;
using System.Linq;

public class CampañaVacunacion
{
    public static void Main(string[] args)
    {
        // Conjunto ficticio de 500 ciudadanos
        HashSet<int> ciudadanos = GenerarConjuntoCiudadanos(500);

        // Conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        HashSet<int> vacunadosPfizer = GenerarConjuntoCiudadanos(75);

        // Conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        HashSet<int> vacunadosAstraZeneca = GenerarConjuntoCiudadanos(75);

        // Conjunto ficticio de 100 ciudadanos vacunados con ambas vacunas
        HashSet<int> vacunadosAmbas = GenerarConjuntoCiudadanos(100);

        // Listado de ciudadanos que no se han vacunado
        HashSet<int> noVacunados = new HashSet<int>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);
        noVacunados.ExceptWith(vacunadosAmbas);

        // Listado de ciudadanos que han recibido las dos vacunas
        HashSet<int> vacunadosDosDosis = vacunadosAmbas;

        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        HashSet<int> soloPfizer = new HashSet<int>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);
        soloPfizer.ExceptWith(vacunadosAmbas);

        // Listado de ciudadanos que solamente han recibido la vacuna de AstraZeneca
        HashSet<int> soloAstraZeneca = new HashSet<int>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);
        soloAstraZeneca.ExceptWith(vacunadosAmbas);

        // Imprimir resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos con dos dosis: " + vacunadosDosDosis.Count);
        Console.WriteLine("Ciudadanos solo con Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos solo con AstraZeneca: " + soloAstraZeneca.Count);

        //Opcional: Imprimir los IDs de los ciudadanos en cada conjunto
        /*
        Console.WriteLine("IDs ciudadanos no vacunados: " + string.Join(", ", noVacunados));
        Console.WriteLine("IDs ciudadanos con dos dosis: " + string.Join(", ", vacunadosDosDosis));
        Console.WriteLine("IDs ciudadanos solo con Pfizer: " + string.Join(", ", soloPfizer));
        Console.WriteLine("IDs ciudadanos solo con AstraZeneca: " + string.Join(", ", soloAstraZeneca));
        */
    }

    // Método para generar un conjunto ficticio de ciudadanos
    public static HashSet<int> GenerarConjuntoCiudadanos(int cantidad)
    {
        HashSet<int> conjunto = new HashSet<int>();
        Random random = new Random();

        while (conjunto.Count < cantidad)
        {
            conjunto.Add(random.Next(1, 1000000)); // IDs ficticios
        }

        return conjunto;
    }
}
