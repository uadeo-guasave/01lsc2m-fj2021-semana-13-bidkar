using System;
using System.Collections.Generic;

namespace MusicApp
{
    class Artista: IPrintable
    {
        public int Id { get; set; }
        public string NombreReal { get; set; }
        public string NombreArtistico { get; set; }
        public string RolMusical { get; set; }
        public int AñoDeNacimiento { get; set; }
        public int DatosDeContactoId { get; set; }
        public DatosDeContacto DatosDeContacto { get; set; }
        public List<Album> Albumes { get; set; } = new List<Album>();

        public void imprimir()
        {
            Helpers.printTitle(NombreArtistico);
            Helpers.printSubTitle("Detalles del artista");
            Console.WriteLine($"Nombre real: {NombreReal}");
            Console.WriteLine($"Rol musical: {RolMusical}");
            Console.WriteLine($"Año de nac: {AñoDeNacimiento}");
            DatosDeContacto.imprimir();

            // se debe imprimir solo si la lista tiene albumes
            if (Albumes.Count > 0)
            {
                Helpers.printSubTitle("Albumes");
                foreach (var album in Albumes)
                {
                    Console.WriteLine($"{album.AñoDePublicacion}: {album.Titulo}");
                }
            }
        }
    }
}