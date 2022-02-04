namespace projeto.entities
{
    public class HeroiTerra : Heroi
    {

        public HeroiTerra(string nome, int level, int atk, int def)
        {
            this.nome = nome;
            this.level = level;
            this.atk = atk;
            this.def = def;
        } 

        public override string atacar()
        {
            return this.nome + " atacou com bola de terra.";
        }

        
    }
}