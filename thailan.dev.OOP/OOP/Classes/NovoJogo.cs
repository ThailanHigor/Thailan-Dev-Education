namespace OOP.Classes
{
    public class NovoJogo
    {
        public NovoJogo()
        {
            var mago = new Mago();
            mago.Morrer();

            var outroMago = new Mago("TH O Mago");

            var guerreiro = new Guerreiro("Cavaleiro Programador");

        }
    }
}
