namespace Po1450_AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string nazev, string cestaObrazek, int width) 
        { 
            Nazev = nazev;
            CestaObrazek = cestaObrazek;
            AktualniPozice = -1;
            Width = width;
        }
        public string Nazev { get; private set; }
        public string CestaObrazek { get; private set; }
        private List<Souradnice> Pozice { get; set; } = new List<Souradnice>();
        public int AktualniPozice { get; private set; }
        public int Width { get; set; }
        private bool JduDopredu { get; set; } = true;

        private bool HlavaVpravo { get; set; } = true;

        public string Style
        {
            get
            {
                if (AktualniPozice < 0)
                {
                    return $" width: {Width}px;";
                }
                else
                {
                    var poz = Pozice[AktualniPozice];
                    return poz.Style + $" width: {Width * poz.VelikostObrazku / 100}px; ";
                }
                
                
            }
        }

        public string TransformRotateY => HlavaVpravo ? "transform: rotateY(0deg);" : "transform: rotateY(180deg);";
        


        public void PridejPozici(int pozX, int pozY, int velikostObrazku)
        {
            var souradnice = new Souradnice(pozX, pozY, velikostObrazku);
            Pozice.Add(souradnice);
        }

        public void Presun()
        {
            if (JduDopredu)
            {
                if (AktualniPozice + 1 == Pozice.Count)
                {
                    JduDopredu = false;
                }

            }
            else
            {
                if (AktualniPozice == 0)
                {
                    JduDopredu = true;
                }

            }
            var predchoziPozice = AktualniPozice;

            if (JduDopredu) 
            {
                AktualniPozice++;
            }
            else
            {
                AktualniPozice--;
            }

            HlavaVpravo = predchoziPozice<0 || Pozice[predchoziPozice].PozX < Pozice[AktualniPozice].PozX;
        }
    }
}
