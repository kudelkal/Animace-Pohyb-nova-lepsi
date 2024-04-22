namespace Po1450_AnimacePohyb.Models
{
    public class Souradnice
    {
        public Souradnice(int pozX, int pozY, int velikostObrazku) 
        { 
            PozX = pozX;
            PozY = pozY;
            VelikostObrazku = velikostObrazku;
        }
        public int PozX { get; private set; }
        private int PozY { get; set;}
        public int VelikostObrazku { get; set; }
        public string Style => $"left: {PozX}px; top: {PozY}px;";
    }
}
