using System.ComponentModel.DataAnnotations.Schema;

namespace FunkoPopAPI.MODELS
{
    public class FranquiciaGenero
    {
        public int ID { get; set; }
        public int FranquiciaID { get; set; }
        public int GeneroID { get; set; }
        //Propiedad de Navegción
        public Franquicia Franquicia { get; set; }
        public Genero Genero { get; set; }
    }
}
