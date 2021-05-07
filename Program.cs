using System;

namespace MusicApp
{
    class Program
    {
        const int LARGO_DE_LINEA = 60;
        static void Main(string[] args)
        {
            var album1 = new Album
            {
                Id = 92564,
                Titulo = "Las nieves de enero",
                GeneroMusical = "Ranchero Regional Mexicano",
                AñoDePublicacion = 1990,
                NumeroDePistas = 12,
                NumeroDeVentas = 10000000,
                ArtistaId = 6452,
                CriticaId = 738
            };

            var critica1 = new Critica
            {
                Id = 738,
                RollingStone = 7.5f,
                Mtv = 7.3f,
                MusicManiac = 7.1f,
                AlbumId = 1
            };

            var artista1 = new Artista
            {
                Id = 6452,
                NombreReal = "Rosalino Sanchez Felix",
                NombreArtistico = "Chalino Sanchez",
                RolMusical = "Solista",
                AñoDeNacimiento = 1960,
                DatosDeContactoId = 8463
            };

            var contacto1 = new DatosDeContacto
            {
                Id = 8463,
                PaisDeOrigen = "México",
                Ciudad = "Culiacán, Sinaloa",
                CorreoElectronico = "chalino@porsiempre.vive",
                CodigoPostal = "82105",
                ArtistaId = 6452
            };

            // asignar directamente las relaciones entre objetos
            album1.Artista = artista1;
            album1.Critica = critica1;

            // TODO: album1.imprimir();
            imprimirLineaSencilla();
            Console.WriteLine($"{"Album:",9} {album1.Titulo}\n{"Artista:",9} {album1.Artista.NombreArtistico}");
            imprimirTitulo("Críticas");
            Console.WriteLine($"{"Rolling Stone:",14} {album1.Critica.RollingStone}");
            Console.WriteLine($"{"MTV:",14} {album1.Critica.Mtv}");
            Console.WriteLine($"{"Music Maniac:",14} {album1.Critica.MusicManiac}");

            // TODO: imprimir en pantalla la información completa del album
            // TODO: realizar lo conducente para imprimir en pantalla la informacion del artista,
            //       y sus datos de contacto

            /*
            // variables de tipo primitivo, se referencian a la porción de memoria de cada una
            int a = 10;
            int b = a;
            Console.WriteLine($"a:{a} b:{b}");
            a = 20;
            Console.WriteLine($"a:{a} b:{b}");

            // variable de tipo referencia, se referencian a la porción de memoria compartida
            var artistax = new Artista {
                Id = 2,
                NombreArtistico = "Snoop Dogg",
                NombreReal = "Don Motorolo"
            };

            var artistax2 = artistax;
            Console.WriteLine($"x:{artistax.NombreReal} x2:{artistax2.NombreReal}");
            artistax.NombreReal = "Calvin Cordozar Broadus Jr.";
            Console.WriteLine($"x:{artistax.NombreReal} x2:{artistax2.NombreReal}");
            */
        }

        private static void imprimirTitulo(string texto)
        {
            var longitud = texto.Length / 2;
            imprimirLineaSencilla();
            Console.WriteLine("{0," + (Helpers.LARGO_DE_LINEA / 2 + longitud) + "}", texto.ToUpper());
            imprimirLineaSencilla();
        }

        private static void imprimirLineaSencilla()
        {
            Console.WriteLine("".PadLeft(Helpers.LARGO_DE_LINEA, '-'));
        }
    }
}
