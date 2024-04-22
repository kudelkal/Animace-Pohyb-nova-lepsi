using Po1450_AnimacePohyb.Models;

namespace Po1450_AnimacePohyb.Pages
{
    public partial class Animace1
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) 
            {
                await Task.Run(()=>Postava.Presun());
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        public Postava Postava { get; set; }

        private void InicializaceHry()
        {
            Postava = new Postava(nazev: "Maxipes", cestaObrazek: "../img/maxipes.png", width:150);
            Postava.PridejPozici(pozX: 45, pozY: 280, velikostObrazku: 70);
            Postava.PridejPozici(pozX: 480, pozY: 240, 40);
            Postava.PridejPozici(pozX: 840, pozY: 340, 80);
            Postava.PridejPozici(pozX: 110, pozY: 470, 100);
        }
    }
}
