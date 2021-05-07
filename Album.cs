namespace MusicApp
{
    class Album
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

        public void imprimir() {}
    }
}