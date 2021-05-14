using System;

namespace MusicApp
{
    class DatosDeContacto: IPrintable
    {
        public int Id { get; set; }
        public string PaisDeOrigen { get; set; }
        public string Ciudad { get; set; }
        public string CorreoElectronico { get; set; }
        public string CodigoPostal { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }

        public void imprimir()
        {
            Helpers.printSubTitle("Datos de contacto");
            Console.WriteLine($"Pais: {PaisDeOrigen}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Correo electrónico: {CorreoElectronico}");
            Console.WriteLine($"CP: {CodigoPostal}");
        }
    }
}