using System;
namespace SocialJ
{
    public class ofertaTrabajo
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Requisitos { get; set; }
        public string Labores { get; set; }
        public string RangoSal { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
