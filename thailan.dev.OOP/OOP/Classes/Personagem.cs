namespace OOP.Classes
{
    // Classe
    public abstract class Personagem
    {
        protected Personagem(string nome)
        {
            Nome = nome;
            Vida = 100;
            Velocidade = 0;
            Nivel = 0;
        }

        public string Nome { get; set; }
        protected int Vida { get; set; }
        protected int Velocidade { get; set; }

        private int Nivel;

        protected void LevelUp()
        {
            Nivel += 1;
        }

        public virtual void SubirDeNivel() {
            Vida += 10;
            Velocidade += 5;
            Nivel += 1;
            LevelUp();
        }

        public void Morrer()
        {
            Vida = 0;
        }
        public abstract void Ataque();
    }
}