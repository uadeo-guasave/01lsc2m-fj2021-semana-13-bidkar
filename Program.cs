using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anterior();

            // PruebaBaseDeDatos();
            
            Album.mostrarAlbumesPorAño(2019);
        }

        private static void PruebaBaseDeDatos()
        {
            using (var db = new SqliteDbContext())
            {
                db.Database.EnsureCreated();
                // obtener los primeros 10 albumes con artista y crítica
                var albumes = db.Albumes
                    .Take(1)
                    .Include(album => album.Artista)
                        .ThenInclude(artista => artista.DatosDeContacto)
                    .Include(album => album.Critica)
                    .ToList();

                foreach (var album in albumes)
                {
                    // Console.WriteLine($"Album: {album.Titulo}");
                    album.imprimir();
                    album.Artista.imprimir();
                }
            }
        }

        private static void Anterior()
        {
            var album1 = new Album
            {
                Id = 92564,
                Titulo = "Las nieves de enero",
                GeneroMusical = "Ranchero Regional Mexicano",
                AñoDePublicacion = 1990,
                NumeroDePistas = 12,
                NumeroDeVentas = 10000000,
                ArtistaId = 6452
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
                AñoDeNacimiento = 1960
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
            artista1.Albumes.Add(album1);
            artista1.DatosDeContacto = contacto1;
            album1.Artista = artista1;
            album1.Critica = critica1;

            album1.imprimir();
            album1.Artista.imprimir();
        }
    }
}
