using System;

namespace MusicApp
{
    class Program
    {
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

            Console.WriteLine("".PadLeft(60, '-'));
            Console.WriteLine($"Album: {album1.Titulo}\nArtista: {album1.Artista.NombreArtistico}");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.WriteLine($"Críticas\nRolling Stone: {album1.Critica.RollingStone}");
            Console.WriteLine($"MTV: {album1.Critica.Mtv}");
            Console.WriteLine($"Musica Maniac: {album1.Critica.MusicManiac}");

            // TODO: imprimir en pantalla la información completa del album
            // TODO: realizar lo conducente para imprimir en pantalla la informacion del artista,
            //       y sus datos de contacto
        }
    }
}
