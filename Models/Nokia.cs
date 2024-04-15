namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, int memoria, string iMEI, string modelo) : base(numero, memoria, iMEI, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o aplicativo {nomeApp} via PlayStore");
        }
    }
}