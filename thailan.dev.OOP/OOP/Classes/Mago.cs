namespace OOP.Classes
{
    public class Mago : Personagem
    {
        public Mago(string nome) : base(nome) { }
        public Mago() : base("Mago Iniciante") { }

        public int NivelMagico { get; set; }
        public int Inteligencia { get; set; }
        public override void Ataque()
        {
            //Eu vou atacar usando minha magia
        }

        public override void SubirDeNivel()
        {
            Vida += 20;
            Velocidade += 7;
            LevelUp();
        }

    }
}
