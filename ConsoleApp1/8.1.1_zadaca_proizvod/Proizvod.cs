namespace _8._1._1_zadaca_proizvod
{
    internal class Proizvod
    {
        public string Naziv = "";
        public double Cijena = 0;
        public double Marza = 0;
        public double Porez = 0;


        public Proizvod(string naziv)
        {
            this.Naziv = naziv;
        }
        public double MPC()
        {
            return Cijena + Marza + Porez;
        }
    }
}