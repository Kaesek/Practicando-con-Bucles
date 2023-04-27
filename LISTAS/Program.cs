using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> favoritas = new List<string>();
        string agregar = "si";
        string peliculaFavorita = "";
        string eliminar = "Si";

        while (agregar.ToLower() == "si")
        {

            List<string> peliculas = new List<string>() {
            "IT 1",
            "IT 2",
            "IT 3",
            "Shrek 1",
            "Shrek 2",
            "Shrek 3",
            "Shrek 4",
            "Shrek 5",
            "Spider-Man 1",
            "Spider-Man 2",
            "Spider-Man 3",
            "Que paso ayer 1",
            "Que paso ayer 2",
            "Que paso ayer 3",
            "Tiburon 1",
            "Tiburon 2",
            "Wall-e",
            "KungFu Panda",
            };

            Console.WriteLine("Peliculas: ");
            foreach (string pelicula in peliculas)
            {
                Console.WriteLine(pelicula);
            }

            Console.WriteLine("\nAgregar a favoritas: ");
            peliculaFavorita = Console.ReadLine();
            if (peliculas.Contains(peliculaFavorita) && !favoritas.Contains(peliculaFavorita))
            {
                favoritas.Add(peliculaFavorita);
            }
            else
            {
                Console.WriteLine("Esta pelicula ya se encuentra registrada o no esta dentro del catalogo.");
            }

            Console.WriteLine("Deseas agregar otra peliculas a favoritos?");
            agregar = Console.ReadLine();
        }

        Console.WriteLine("Deseas eliminar peliculas de tu lista de favoritos?");
        eliminar = Console.ReadLine();

        if (eliminar.ToLower() == "si")
        {
            while (eliminar.ToLower() == "si")
            {
                Console.WriteLine("\nEliminar de favoritas: ");
                peliculaFavorita = Console.ReadLine();
                if (favoritas.Contains(peliculaFavorita))
                {
                    favoritas.Remove(peliculaFavorita);
                }

                Console.WriteLine("Deseas eliminar otra pelicula de tu lista? si/no");
                eliminar = Console.ReadLine();
            }
        }

        Console.WriteLine("\nFavoritas actualizadas: ");
        foreach (string peliculaFav in favoritas)
        {
            Console.WriteLine(peliculaFav);
        }
        Console.ReadKey();
    }
}