using System;

namespace MusicApp
{
    class Album: IPrintable
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string GeneroMusical { get; set; }
        public int AñoDePublicacion { get; set; }
        public int NumeroDePistas { get; set; }
        public int NumeroDeVentas { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
        public int CriticaId { get; set; }
        public Critica Critica { get; set; }

        public void imprimir()
        {
            Helpers.printTitle($"{Titulo} ({Artista.NombreArtistico})");
            Helpers.printSubTitle("Detalles del album");
            Console.WriteLine($"Género: {GeneroMusical}");
            Console.WriteLine($"Año: {AñoDePublicacion}");
            Console.WriteLine($"Pistas: {NumeroDePistas}");
            Helpers.printSubTitle("Ranking");
            Console.WriteLine($"Ventas: {NumeroDeVentas}");
            Console.WriteLine($"Rolling Stone: {Critica.RollingStone}");
            Console.WriteLine($"MTV: {Critica.Mtv}");
            Console.WriteLine($"Music Maniac: {Critica.MusicManiac}");
        }
    }
}