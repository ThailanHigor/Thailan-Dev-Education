namespace OOP.Classes
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base(nome) { }
        public Guerreiro() : base("Guerreiro Iniciante") { }

        public int Forca { get; set; }
        public int Defesa { get; set; }

        public override void Ataque()
        {
            //Eu vou atacar usando toda minha força
        }

        public override void SubirDeNivel()
        {
            Vida += 40;
            Velocidade += 10;
            LevelUp();
        }
    }
}
