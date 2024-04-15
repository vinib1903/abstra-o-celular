namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, int memoria, string iMEI, string modelo) : base(numero, memoria, iMEI, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o aplicativo {nomeApp} via AppStore");
        }
    }
}