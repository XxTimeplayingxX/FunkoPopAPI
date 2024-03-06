namespace FunkoPopAPI.MODELS
{
    public class FunkoPopFranquicia
    {
        public int ID { get; set; }
        public int FunkoPopID { get; set; }
        public int FranquiciaID { get; set; }
        //Propiedad de Navegación
        public FunkoPop FunkoPop { get; set; }
        public Franquicia Franquicia { get; set; }
    }
}
