using System.Collections.Generic;

namespace MusicApp
{
    class Artista
    {
        public int Id { get; set; }
        public string NombreReal { get; set; }
        public string NombreArtistico { get; set; }
        public string RolMusical { get; set; }
        public int AñoDeNacimiento { get; set; }
        public int DatosDeContactoId { get; set; }
        public DatosDeContacto DatosDeContacto { get; set; }
        public List<Album> Albumes { get; set; }
    }
}