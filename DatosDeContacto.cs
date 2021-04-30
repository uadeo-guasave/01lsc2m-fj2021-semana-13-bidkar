namespace MusicApp
{
    class DatosDeContacto
    {
        public int Id { get; set; }
        public string PaisDeOrigen { get; set; }
        public string Ciudad { get; set; }
        public string CorreoElectronico { get; set; }
        public string CodigoPostal { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
    }
}