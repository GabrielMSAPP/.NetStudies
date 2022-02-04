namespace projeto.entities
{
    public class Heroi
    {
        public string nome;
        public int level;
        public int atk;
        public int def;

        public Heroi(String nome, int level, int atk, int def)
        {
            this.nome = nome;
            this.level = level;
            this.atk = atk;
            this.def = def;
        } 

        public Heroi(){

        }

        public string apresentar()
        {
            return "nome: " + this.nome + ", level: " + this.level + ", atk: " + this.atk + ", def: " + this.def;
        }

        public virtual string atacar()
        {
            return this.nome + " atacou com poder padrão.";
        }
    }
}